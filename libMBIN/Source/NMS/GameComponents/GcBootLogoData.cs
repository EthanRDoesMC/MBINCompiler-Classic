﻿namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x8B913442E7E83049)]
    public class GcBootLogoData : NMSTemplate
    {
        [NMS(Size = 0x100)]
        public string Texture1;
        [NMS(Size = 0x100)]
        public string Texture2;
        [NMS(Size = 0x100)]
        public string Texture3;
        [NMS(Size = 0x100)]
        public string Texture4;

        public float DisplayTime1;
        public float DisplayTime2;
        public float DisplayTime3;
        public float DisplayTime4;
    }
}