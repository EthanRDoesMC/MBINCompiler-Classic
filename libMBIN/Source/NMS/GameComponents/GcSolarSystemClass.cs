﻿namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x5AC84A35CBFF4798)]
    public class GcSolarSystemClass : NMSTemplate
    {
		public enum SolarSystemClassEnum { Default, Initial, Anomaly, GameStart }
		public SolarSystemClassEnum SolarSystemClass;
    }
}