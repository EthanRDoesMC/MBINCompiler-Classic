﻿namespace libMBIN.Models.Structs
{
    public class GcMissionSequenceWaitForDepots : NMSTemplate       // size: 0x108
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string Message;
        /* 0x080 */ public int AmountMin;
        /* 0x084 */ public int AmountMax;
        [NMS(Size = 0x80)]
        /* 0x088 */ public string DebugText;
    }
}
