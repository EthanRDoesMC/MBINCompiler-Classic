using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x997EFD1FBFF7CE9F, NameHash = 0x409E4BD41C6295C9)]
    public class GcPulseEncounterSpawnFrigateFlyby : NMSTemplate
    {
        /* 0x00 */ public GcFrigateFlybyType FlybyType;
        /* 0x08 */ public NMSString0x20A CommunicatorOSDLocId;
        /* 0x28 */ public GcPlayerCommunicatorMessage CommunicatorMessage;
    }
}