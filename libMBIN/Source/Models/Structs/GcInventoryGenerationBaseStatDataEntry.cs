﻿using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    public class GcInventoryGenerationBaseStatDataEntry : NMSTemplate     // size: 0x20
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string BaseStatID;
        /* 0x10 */ public float Min;
        /* 0x14 */ public float Max;
        /* 0x18 */ public float MinFixedAdd;
        /* 0x1C */ public float MaxFixedAdd;
    }
}
