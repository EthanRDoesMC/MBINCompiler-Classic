# Extract all the class definitions from the NMS.exe

from abc import ABC
import configparser
import os
import os.path as op
import pathlib
import re
from signal import SIGTERM
import struct
import subprocess
import time
from typing import Optional

from jinja2 import Template
import pymem


EXTRA_CLASSES = ['cAxisSpecification', 'cCgExpeditionCategoryStrength']
# Classes that don't look like globals but actually are.
ACTUALLY_GLOBALS = ['GcSceneOptions', 'GcSmokeTestOptions', 'GcDebugOptions']
NAME_MAPPING = {
    'GcDefaulMissionProduct': 'GcDefaultMissionProduct',
    'GcDefaulMissionSubstance': 'GcDefaultMissionSubstance',
    'gcwordcategorytableEnum': 'GcWordCategoryTableEnum',
    'GCHUDEffectRewardData': 'GcHUDEffectRewardData',
}
# Flag enums fixes
FLAG_ENUM_FIXES = {
    'false_positives': [],
    'false_negatives': [
        'HotspotType',
        'CollisionGroup',
        'MetadataReadMask',
        'InputActionInfoFlags',
    ],
}
# List of classes to avoid overwriting as the have custom deserialisation
# methods.
DONT_OVERRIDE = [
    'TkGeometryData',
    'TkMeshData',
    'TkSceneNodeData',
    'TkAnimNodeFrameData',
]

SUMMARY_FILE = op.join(op.dirname(__file__), 'summary.txt')

STATIC_BASE = 0x140000000
TYPE_MAPPING = {
    0x00: 'undefined',
    0x01: 'bool',
    0x02: 'byte',
    0x03: 'CUSTOM',
    0x04: 'NMSTemplate',
    0x05: 'Colour',
    0x06: 'LIST',
    0x07: 'VariableSizeString',
    0x09: 'ENUM',
    0x0A: 'NMSString0x80',  # Technically a "filename" -> GcFilename (?)
    0x0B: 'FLAGENUM',
    0x0C: 'float',
    0x0D: 'NMSString0x10',
    0x0E: 'NMSString0x20A',  # There seems to be no difference in use between this
    0x0F: 'NMSString0x20A',  # and this...
    0x11: 'short',
    0x12: 'int',
    0x13: 'long',
    0x14: 'GcNodeID',
    0x15: 'GcResource',
    0x16: 'GcSeed',
    0x17: 'ARRAY',
    0x18: 'NMSString0x20',
    0x19: 'NMSString0x40',
    0x1A: 'NMSString0x80',
    0x1B: 'NMSString0x100',
    0x1C: 'NMSString0x200',
    0x1D: 'NMSString0x400',
    0x1E: 'NMSString0x800',
    0x20: 'ushort',
    0x21: 'uint',
    0x22: 'ulong',
    0x24: 'Vector2f',
    0x25: 'Vector3f',
    0x26: 'Vector4f',
}
PREFIX_MAPPING = {
    'ccg': 'GameComponents',
    'cgc': 'GameComponents',
    'ctk': 'Toolkit'
}
USING_MAPPING = {
    'gc': 'libMBIN.NMS.GameComponents',
    'cg': 'libMBIN.NMS.GameComponents',
    'tk': 'libMBIN.NMS.Toolkit'
}

FIELD_TEMPLATE = "        /* {0} */ public {1} {2};"
ENUM_TEMPLATE = """        // size: {3}{5}
        public enum {1}Enum{4} {{
{2}
        }}
        /* {0} */ public {1}Enum {1};"""
ARRAY_TEMPLATE = """        [NMS(Size = {3})]
        /* {0} */ public {1} {2};"""
ARRAY_ENUM_TEMPLATE = """        // size: {2}
        public enum {0}Enum {{
{1}
        }}"""
TYPED_ARRAY_TEMPLATE = """        [NMS(Size = {3}, EnumType = typeof({4}))]
        /* {0} */ public {1} {2};"""

# 0: usings: NB: End with two \n's
# 1: namespace
# 2: GUID
# 3: namehash
# 4: Extra attributes (optional, normally '')  # TODO: Remove?
# 5: class name
# 6: fields

CLASS_TEMPLATE = """{0}namespace {1}
{{
    [NMS(GUID = {2}, NameHash = {3}{4})]
    public class {5} : NMSTemplate
    {{
{6}
    }}
}}
"""


"""
Details on the format of the 0x60 bytes for each field:

0x00: (uint64*) pointer to the name of the field. This is null-terminated.
0x08: ???
0x10: (uint64*) pointer to the string 'Base'
0x18: ???
0x1C: (uint32) Type of field (see conversion table)
0x20: (if 0x1C == 0x6 || 0x17): List/Array type (see conversion table)
0x24: (uint32) Size of field in bytes.
0x28: (uint32) Array Size. 1 if not an array.
0x2C: (uint32) Relative offset within the class.
0x30: (if 0x1C == 0x03 || 0x20 == 0x03) (uint64* -> uint64*) pointer to pointer
        to type name
0x38: (if 0x1C == 0x09): (uint64*) pointer to a table with the enum values and
        pointers to the values:
    table of:
        (uint64): enum index
        (uint64*): pointer to name of enum value.
      (if 0x1C == 0x17) pointer to a table with the enum values for the array
0x40: (if 0x1C == 0x09): enum count.
0x44: (float) 1.0 (always?)
0x48: ??? (seems to always be (uint32) 3 or 4) Can't see why it's which or what
        it even means...
0x50: ???
"""


def fmt_hex(x: int) -> str:
    """ Return the integer input formatted as a upper-case hexadecimal value """
    return '0x' + hex(x).upper()[2:]


class Field(ABC):
    # Field ABC which will be inherited by the other Field concrete sub-classes.
    # This gives some basic functionality and does some common processing.
    def __init__(self, data: bytes, nms_mem):
        self.data = data
        self.raw_field_type = 0x00
        self.field_size = 0x0

        # Get the name of the field.
        self._field_name = nms_mem.read_string(
            struct.unpack_from('<Q', data, offset=0x0)[0], byte=128
        )
        # Some field names are annoyingly duplicated in the exe. c# doesn't
        # allow this, so we need to add something to the name to make it unique.
        self._field_name_is_duplicate = False
        self.field_size = struct.unpack_from('<I', data, offset=0x24)[0]
        self._array_size = struct.unpack_from('<I', data, offset=0x28)[0]
        self._field_offset = struct.unpack_from('<I', data, offset=0x2C)[0]

        # Sort out the requirements for this field.
        self.required_using: set = set()

        # The number of hexadecimal digits the maximum offset has.
        self.max_offset_width = 1

    @property
    def field_type(self):
        return TYPE_MAPPING.get(
            self.raw_field_type,
            f'unknown ({self.raw_field_type:X})'
        )

    @property
    def field_name(self):
        if self._field_name[0].isdigit():
            return '_' + self._field_name
        if self._field_name_is_duplicate:
            return self._field_name + '_' + self.field_type
        if self._field_name[:2].lower() in {'gc', 'tk'}:
            return self._field_name[2:]
        return self._field_name

    @property
    def field_offset(self):
        return '0x{0:>0{width}}'.format(
            fmt_hex(self._field_offset)[2:], width=self.max_offset_width
        )

    @property
    def array_size(self):
        return fmt_hex(self._array_size)

    def __str__(self):
        return FIELD_TEMPLATE.format(
            self.field_offset, self.field_type, self.field_name
        )

    @classmethod
    def instantiate(cls, data: bytes, nms_mem: pymem.Pymem):
        """ Return an instance of a subclass which is of the appropriate type
        based on the raw type specified in the data.
        This allows us to simplify the logic regarding deserialising the field
        by deferring it to the individual classes.
        """
        raw_type = struct.unpack_from('<I', data, offset=0x1C)[0]
        if raw_type == 0x09 or raw_type == 0x0B:
            ef = EnumField(data, nms_mem)
            if raw_type == 0x0B:
                ef.is_flag = True
            ef.check_flag_overwrites()
            return ef
        elif raw_type == 0x06:
            return ListField(data, nms_mem)
        elif raw_type == 0x17:
            return ArrayField(data, nms_mem)
        elif raw_type == 0x03:
            return CustomField(data, nms_mem)
        else:
            return NormalField(data, nms_mem, raw_type)


class NormalField(Field):
    def __init__(self, data: bytes, nms_mem: pymem.Pymem, raw_field_type):
        super().__init__(data, nms_mem)
        self.raw_field_type = raw_field_type


class CustomField(Field):
    def __init__(self, data: bytes, nms_mem: pymem.Pymem):
        super().__init__(data, nms_mem)
        self.raw_field_type = 0x03

        # Get the pointer to the custom type name.
        ptr_custom_type = nms_mem.read_ulonglong(
            struct.unpack_from('<Q', data, offset=0x30)[0]
        )
        # Now get the actual name.
        self._field_type = nms_mem.read_string(ptr_custom_type, byte=128)[1:]

        if self.field_type[:2].lower() in ('cg', 'gc', 'tk'):
            self.required_using.add(
                USING_MAPPING.get(self.field_type[:2].lower(),
                                  'libMBIN.NMS.GameComponents')
            )
        elif self.field_type == 'AxisSpecification':
            self.required_using.add('libMBIN.NMS.GameComponents')

    @property
    def field_type(self):
        return NAME_MAPPING.get(self._field_type, self._field_type)


class ArrayField(Field):
    def __init__(self, data: bytes, nms_mem: pymem.Pymem):
        super().__init__(data, nms_mem)
        self.raw_field_type = 0x17
        # Multiply the field size by the array size to get the correct size
        self.field_size *= self._array_size
        self.array_enum = None
        self.ptr_enum: int = 0
        self.array_enum_type: Optional[str] = None

        array_type_raw = struct.unpack_from('<I', data, offset=0x20)[0]
        # A custom array subtype.
        if array_type_raw == 0x03:
            ptr_custom_type = nms_mem.read_ulonglong(
                struct.unpack_from('<Q', data, offset=0x30)[0]
            )
            self._field_type = nms_mem.read_string(ptr_custom_type, byte=128)[1:]
            self.required_using.add(
                USING_MAPPING.get(self._field_type[:2].lower(),
                                  'libMBIN.NMS.GameComponents')
            )
        else:
            self._field_type = TYPE_MAPPING.get(
                array_type_raw, f'unknown {array_type_raw:X}'
            )
        # Determine the associated EnumType
        self.ptr_enum = struct.unpack_from('<Q', data, offset=0x38)[0]
        # This may be a nullptr, in which case we end as we have no enum to get.
        if self.ptr_enum == 0:
            return
        # If the pointer is non-zero, then it will be a pointer to the enums
        # either associated with some other class, or an inline one.
        # We need to keep track of the pointer do we can determine what class
        # it was later.
        # Get all the values of the enum:
        self.array_enum = []
        for i in range(self._array_size):
            ptr_enum_name = nms_mem.read_ulonglong(self.ptr_enum + i * 0x10 + 0x8)
            name = nms_mem.read_string(ptr_enum_name, byte=128)
            # 'default' (all lowercase) is a resticted word in c#.
            # Replace the leading 'd' with 'D'.
            if name == 'default':
                name = 'Default'
            self.array_enum.append(name)

    @property
    def field_type(self):
        return f'{NAME_MAPPING.get(self._field_type, self._field_type)}[]'

    def __str__(self):
        if self.array_enum is None:
            return ARRAY_TEMPLATE.format(
                self.field_offset,
                self.field_type,
                self.field_name,
                self.array_size,
            )
        else:
            if self.array_enum_type is None:
                enum_vals = ',\n'.join([' ' * 12 + x for x in self.array_enum])
                _enum = ARRAY_ENUM_TEMPLATE.format(
                    self.field_name,
                    enum_vals,
                    fmt_hex(self._array_size),
                )
                _field = TYPED_ARRAY_TEMPLATE.format(
                    self.field_offset,
                    self.field_type,
                    self.field_name,
                    self.array_size,
                    self.field_name + 'Enum',
                )
                return _enum + '\n' + _field
            else:
                return TYPED_ARRAY_TEMPLATE.format(
                    self.field_offset,
                    self.field_type,
                    self.field_name,
                    self.array_size,
                    self.array_enum_type,
                )



class ListField(Field):
    def __init__(self, data: bytes, nms_mem: pymem.Pymem):
        super().__init__(data, nms_mem)
        self.raw_field_type = 0x06
        self.field_size = 0x10
        self.required_using.add('System.Collections.Generic')

        array_type_raw = struct.unpack_from('<I', data, offset=0x20)[0]
        if array_type_raw == 0x03:
            ptr_custom_type = nms_mem.read_ulonglong(
                struct.unpack_from('<Q', data, offset=0x30)[0]
            )
            self._field_type = nms_mem.read_string(ptr_custom_type, byte=128)[1:]
            self.required_using.add(
                USING_MAPPING.get(self._field_type[:2].lower(),
                                  'libMBIN.NMS.GameComponents')
            )
        else:
            self._field_type = TYPE_MAPPING.get(
                array_type_raw, f"unknown {array_type_raw:X}"
            )

    @property
    def field_type(self):
        return f'List<{NAME_MAPPING.get(self._field_type, self._field_type)}>'


class EnumField(Field):
    def __init__(self, data: bytes, nms_mem: pymem.Pymem):
        super().__init__(data, nms_mem)
        self._is_flag: bool = False
        self.raw_field_type = 0x09
        self.requires_values = False

        enum_count = struct.unpack_from('<I', data, offset=0x40)[0]
        self.ptr_enum = struct.unpack_from('<Q', data, offset=0x38)[0]
        self.enum_data = []
        # For each enum value, read the index, and a pointer to the name.
        for i in range(enum_count):
            idx = nms_mem.read_uint(self.ptr_enum + i * 0x10)
            ptr_enum_name = nms_mem.read_ulonglong(self.ptr_enum + i * 0x10 + 0x8)
            enum_name = nms_mem.read_string(ptr_enum_name, byte=128)
            # If the string starts with a number we need to prefix with an
            # underscore so that the name is not illegal.
            if enum_name:
                if enum_name[0].isdigit():
                    enum_name = '_' + enum_name
                # 'default' (all lowercase) is a resticted word in c#.
                # Replace the leading 'd' with 'D'.
                if enum_name == 'default':
                    enum_name = 'Default'
            else:
                enum_name = 'None'
            self.enum_data.append((idx, enum_name))
        # Most enums have keys which are concurrent. Some however are not, so
        # we detect this by comparing to the expected range.
        if [x[0] for x in self.enum_data] != list(range(enum_count)):
            self.requires_values = True

    def check_flag_overwrites(self):
        # Check our overwrites and modify the `is_flag` property appropriately.
        if self.field_name in FLAG_ENUM_FIXES['false_negatives']:
            self.is_flag = True
        elif self.field_name in FLAG_ENUM_FIXES['false_positives']:
            self.is_flag = False

    @property
    def is_flag(self) -> bool:
        return self._is_flag

    @is_flag.setter
    def is_flag(self, value: bool):
        self._is_flag = value
        if value is True:
            self.required_using.add('System')
        elif value is False:
            # Remove the System using requirement.
            self.required_using -= {'System', }

    def __str__(self):
        if self.requires_values:
            enum_vals = [
                f'            {x[1]} = {fmt_hex(x[0])}' for x in self.enum_data
            ]
            enum_vals = ',\n'.join(enum_vals)
        else:
            enum_vals = ',\n'.join([' ' * 12 + x[1] for x in self.enum_data])
        enum_type = ''
        if self.requires_values:
            enum_type = ' : uint'
        flags_string = ''
        if self.is_flag:
            flags_string = '\n        [Flags]'
        return ENUM_TEMPLATE.format(
            self.field_offset,
            self.field_name,
            enum_vals,
            fmt_hex(len(self.enum_data)),
            enum_type,
            flags_string,
        )


class NMSClass():
    enum_reference_data: dict = {}

    def __init__(self, name: str, name_hash: int, guid: int):
        self.fields = []
        self._field_names = set()
        self.name = name
        self.name_hash = fmt_hex(name_hash)
        self.guid = fmt_hex(guid)
        self.required_usings = set()
        if self.name not in ACTUALLY_GLOBALS and not self.name.endswith('Globals'):
            self.namespace = USING_MAPPING.get(
                self.name[:2].lower(), 'libMBIN.NMS.GameComponents'
            )
        else:
            self.namespace = 'libMBIN.NMS.Globals'
        self.is_enum_class = False
        self.ptr_enum = None
        self.output_fname = None
        self.has_enum_arrays = False

    def add_fields(self, fields: list[Field]):
        # Add a list of field objects.
        # This is a little hacky and could be done a bit better but this does
        # work...
        self.fields = fields
        max_offset_width = 1
        # For each field find if it requires something and add it to the
        # required usings.
        for field in fields:
            if field.required_using:
                self.required_usings.update(field.required_using)
            if field.field_name not in self._field_names:
                self._field_names.add(field.field_name)
            else:
                field._field_name_is_duplicate = True
        # If there are some fields, calculate the maximum offset so that we can
        # nicely format the offset comments.
        if self.fields:
            max_offset_width = len(self.fields[-1].field_offset) - 2
        # Finally, for each field, give it this found max_offset_width
        for field in self.fields:
            field.max_offset_width = max_offset_width

        # Determine if the class is an enum class
        if len(fields) == 1 and isinstance(fields[0], EnumField):
            self.is_enum_class = True
            self.ptr_enum = fields[0].ptr_enum
            NMSClass.enum_reference_data[fields[0].ptr_enum] = f'{self.name}.{fields[0].field_name}Enum'

    def update_array_enum_refs(self):
        # Update the enum array references for the required fields.
        # To make it faster, only do this for classes which need it.
        if self.has_enum_arrays:
            for field in self.fields:
                if isinstance(field, ArrayField):
                    field.array_enum_type = NMSClass.enum_reference_data.get(field.ptr_enum)

    def __str__(self):
        # String representation. This will be the contents of the .cs file.
        if self.required_usings:
            ru = [f'using {x};' for x in self.required_usings]
            ru.sort(reverse=True)
            usings = '\n'.join(ru) + '\n\n'
        else:
            usings = ''
        return CLASS_TEMPLATE.format(
            usings,
            self.namespace,
            self.guid,
            self.name_hash,
            '',  # TODO: add this if needed?
            self.name,
            '\n'.join([str(x) for x in self.fields]),
        )

    def write(self):
        with open(self.output_fname, 'w') as f:
            f.write(str(self))


def read_class(nms_mem: pymem.Pymem, address: int, filepaths: list[str]) -> NMSClass:
    """
    Take an array of 24 bytes and extract some information:
    0x00: (uint64*): Class name
    0x08: (uint64): Name Hash
    0x10: (uint64): GUID
    0x18: (uint64*): Data
    0x20: (uint32): Number of fields.
    """
    data = nms_mem.read_bytes(address, 0x24)
    ptr_name, name_hash, guid, ptr_data, field_num = struct.unpack(
        '<QQQQI', data)
    name = nms_mem.read_string(ptr_name, byte=128)
    if (name.startswith('cGc') and name.endswith('Globals')) or name[1:] in ACTUALLY_GLOBALS:
        dir_ = 'Globals'
    else:
        dir_ = PREFIX_MAPPING.get(name[:3].lower(), "GameComponents")
    out_dir = f'./output/{dir_}'
    if not op.exists(out_dir):
        os.makedirs(out_dir, exist_ok=True)
    fields, has_enum_arrays = extract(nms_mem, ptr_data, field_num)
    # If the name needs to be fix do so here.
    name = NAME_MAPPING.get(name[1:], name[1:])
    cls = NMSClass(name, name_hash, guid)
    cls.add_fields(fields)
    cls.output_fname = op.join(out_dir, name + '.cs')
    cls.has_enum_arrays = has_enum_arrays
    filepaths.append(f'{dir_}\\{name}')
    return cls


def extract(nms_mem: pymem.Pymem, address: int, field_count: int) -> tuple[list[Field], bool]:
    # Take the 0x60 bytes and process them.
    fields = []
    has_enum_arrays = False
    for i in range(field_count):
        data = nms_mem.read_bytes(address + i * 0x60, 0x60)
        field = Field.instantiate(data, nms_mem)
        # As we add fields, determine if the field is an array with an
        # associated enum. If it is then set a flag.
        if (not has_enum_arrays
            and isinstance(field, ArrayField)
            and field.array_enum is not None
        ):
            has_enum_arrays = True
        fields.append(field)

    return fields, has_enum_arrays


def find_classes(nms_path: pathlib.Path):
    with open(nms_path, 'rb') as f:
        data = f.read()
        # First, find the start and ends of the .rdata section.
        rdata_hdr = data.find(b'.rdata')
        rdata_size, rdata_offset, _, ptr_address = struct.unpack_from(
            '<IIII',
            data,
            offset=rdata_hdr + 8
        )

        # The pointer will different from the actual offset by some amount we
        # need to take into account.
        virtual_offset = rdata_offset - ptr_address

        subdata = data[rdata_offset: rdata_offset + rdata_size]
        # Find all the classes which match the regex.
        for m in re.finditer(b'(c((?:Gc)|(?:Tk))\w+)\x00', data, flags=re.IGNORECASE):
            # For each one, extract the name, and also record the location the
            # name occurs at.
            name = m[0].strip(b'\x00').decode()
            if not name.startswith('c'):
                continue
            addr = m.span()[0] + virtual_offset + STATIC_BASE
            # Now search the exe for this address.
            found_addr = subdata.find(struct.pack('<Q', addr))
            # If we find it, then at this location we will have all the data we
            # need.
            if found_addr != -1:
                found_addr += rdata_offset
                yield name, found_addr + virtual_offset
        for name in EXTRA_CLASSES:
            # For the extra classes we'll be lazy and find them slightly
            # differently...
            addr = data.find(name.encode())
            addr = addr + virtual_offset + STATIC_BASE
            # Now search the exe for this address.
            found_addr = subdata.find(struct.pack('<Q', addr))
            # If we find it, then at this location we will have all the data we
            # need.
            if found_addr != -1:
                found_addr += rdata_offset
                yield name, found_addr + virtual_offset


if __name__ == '__main__':
    # First, handle the configuration loading.
    config = configparser.ConfigParser()
    config_path = op.join(op.dirname(__file__), 'extract.cfg')
    if not op.exists(config_path):
        raise FileNotFoundError('extract.cfg not found in same directory as '
                                'this script. Please copy the '
                                'extract.cfg.sample file, rename it '
                                'extract.cfg, and modify any values as needed.')
    config.read(config_path)
    binary_path = config['NMS']['binary_path']

    nms_proc = subprocess.Popen(binary_path)
    print(f'Opened NMS with PID: {nms_proc.pid}')
    filepaths = []
    with open('./libMBIN-Shared.projitems.j2', 'r') as f:
        template = Template(f.read())

    try:
        # Wait some time for the data to be written to memory.
        time.sleep(config['general'].getint('wait_time', fallback=10))
        # Now find the process with pymem.
        # If there is for some reason multiple instances of NMS running this
        # will probably have issues...
        nms = pymem.Pymem('NMS.exe')
        nms_base = nms.base_address
        t1 = time.time()
        names = []
        classes: list[NMSClass] = []
        for name, offset in find_classes(binary_path):
            cls_ = read_class(nms, nms_base + offset, filepaths)
            if name[1:] in NAME_MAPPING:
                name = 'c' + NAME_MAPPING[name[1:]]
            names.append(f'{name}, {nms_base + offset:X}')
            classes.append(cls_)
        names.sort()
        with open(SUMMARY_FILE, 'w') as f:
            f.write('\n'.join(names))
        for cls_ in classes:
            # Before writing out, loop over the fields of the class also to
            # determine if any of the array fields need to have updated enum
            # references.
            cls_.update_array_enum_refs()
            cls_.write()
        filepaths.sort()
        with open('./libMBIN-Shared.projitems', 'w') as f:
            f.write(template.render(filepaths=filepaths))
        print(f'Took {time.time() - t1}s')
    except Exception as exc:
        raise exc
    finally:
        # Kill the NMS process.
        if config['general'].getboolean('close_NMS_process', fallback=True):
            nms_proc.terminate()
            nms_pid = nms.process_id
            if nms_pid != nms_proc.pid:
                os.kill(nms_pid, SIGTERM)
