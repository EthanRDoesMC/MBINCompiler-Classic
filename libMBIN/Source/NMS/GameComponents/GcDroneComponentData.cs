﻿namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0F3A65944C96C7E77)]
    public class GcDroneComponentData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Id;
        public GcPrimaryAxis PrimaryAxis;
        public float Scaler;
        public GcCreatureHealthData Health;
    }
}