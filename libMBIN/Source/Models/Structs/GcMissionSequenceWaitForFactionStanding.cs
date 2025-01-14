﻿namespace libMBIN.Models.Structs
{
    public class GcMissionSequenceWaitForFactionStanding : NMSTemplate      // size: 0x110
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string Message;
        /* 0x080 */ public GcFactionSelectOptions SelectFrom;
        /* 0x088 */ public int AmountMin;
        /* 0x08C */ public int AmountMax;
        [NMS(Size = 0x80)]
        /* 0x090 */ public string DebugText;
    }
}
