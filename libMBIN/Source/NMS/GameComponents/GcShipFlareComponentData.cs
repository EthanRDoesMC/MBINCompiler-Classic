﻿namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x1E6DFC2F6689E5A4)]
    public class GcShipFlareComponentData : NMSTemplate
    {
		public enum FlareTypeEnum { Default }
		public FlareTypeEnum FlareType;
    }
}