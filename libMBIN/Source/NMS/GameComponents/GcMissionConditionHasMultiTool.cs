using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x8, GUID = 0x0000000000000000, NameHash = 0xF65D2CFF75A05B47)]
    public class GcMissionConditionHasMultiTool : NMSTemplate
    {
        public GcInventoryClass InventoryClass;
        public bool CheckAllTools;
        public bool BetterClassMatches;
        public bool TakeValueFromSeasonData;
        [NMS(Size = 0x1, Ignore = true)]
        public byte[] Endpadding;
    }
}
