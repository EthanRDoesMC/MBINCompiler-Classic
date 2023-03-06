using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF363A7A9323D1D2A, NameHash = 0x84BBBF70C34631CA)]
    public class GcMissionConditionHasIngredientsForItem : NMSTemplate
    {
        /* 0x00 */ public List<NMSString0x10> TargetItems;
        /* 0x10 */ public bool Repair;
    }
}