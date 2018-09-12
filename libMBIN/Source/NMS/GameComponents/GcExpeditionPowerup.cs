﻿namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x58, GUID = 0x8D71FA6CE0ED29EA)]
    public class GcExpeditionPowerup : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string ProductId;
        public GcFrigateStatType StatModified;
        public int ChargeValue;
        [NMS(Size = 0x20)]
        public string SelectionDescription;
        [NMS(Size = 0x20)]
        public string ModuleDescription;
    }
}