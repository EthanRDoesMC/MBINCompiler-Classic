using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAE9C4532C268B69A, NameHash = 0xB8C015B2B3985468)]
    public class GcSentinelSpawnData : NMSTemplate
    {
        /* 0x0 */ public GcSentinelTypes Type;
        /* 0x4 */ public int MinAmount;
        /* 0x8 */ public int MaxAmount;
    }
}