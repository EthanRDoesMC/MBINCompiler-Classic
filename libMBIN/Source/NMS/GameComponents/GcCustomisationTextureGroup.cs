﻿namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x40, GUID = 0x8437059D0EF05BF2)]
    public class GcCustomisationTextureGroup : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string GroupID;
        [NMS(Size = 0x20)]
        public string Title;
        [NMS(Size = 0x10)]
        public string TextureOptionsGroup;
    }
}