﻿using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    public class GcMaintenanceGroupEntry : NMSTemplate      // size: 0x20
    {
        /* 0x00 */ public GcInventoryType Type;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x04 */ public byte[] Padding4;
        [NMS(Size = 0x10)]
        /* 0x08 */ public string Id;
        /* 0x18 */ public float ProbabilityWeighting;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x1C */ public byte[] EndPadding;
    }
}
