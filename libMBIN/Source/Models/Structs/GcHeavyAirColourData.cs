﻿namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x20)]
    public class GcHeavyAirColourData : NMSTemplate
    {
        /* 0x000 */ public Colour Colour1;
        /* 0x010 */ public Colour Colour2;
    }
}
