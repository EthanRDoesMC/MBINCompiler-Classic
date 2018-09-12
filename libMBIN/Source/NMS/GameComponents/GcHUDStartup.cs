﻿using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0A90AA742B60AEFD2)]
    public class GcHUDStartup : NMSTemplate     // size: 0x8
    {
        /* 0x00 */ public GcAudioWwiseEvents Audio;
        /* 0x04 */ public float Time;
    }
}