using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x228, GUID = 0xD657E0B02AB57A76, NameHash = 0x9DC327D85EF1681E)]
    public class GcMissionSequenceConstructSettlementBuildingWithScanEvent : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 Message;
        /* 0x080 */ public NMSString0x80 MessageWhileBuilding;
        /* 0x100 */ public NMSString0x80 MessageWithItemsGathered;
        /* 0x180 */ public NMSString0x20A ScanEvent;
        /* 0x1A0 */ public float ForceCompleteSequenceAtStagePercentage;
        /* 0x1A4 */ public NMSString0x80 DebugText;
    }
}