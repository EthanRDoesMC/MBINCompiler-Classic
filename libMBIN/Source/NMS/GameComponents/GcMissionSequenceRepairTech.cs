using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x110, GUID = 0x0000000000000000, NameHash = 0xF83A832D3507037F)]
    public class GcMissionSequenceRepairTech : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string Message;
        public List<GcTechnologyTableEnum> TechsToRepair;
        [NMS(Size = 0x80)]
        public string DebugText;
    }
}
