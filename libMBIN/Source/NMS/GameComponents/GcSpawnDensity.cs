﻿namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0D5F1AEB0209042C6)]
    public class GcSpawnDensity : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x000 */ public string Name;
        /* 0x010 */ public bool Active;
		[NMS(Size = 3, Ignore = true)]
        /* 0x011 */ public byte[] Padding011;
		public enum CoverageTypeEnum { Total, SmoothPatch, GridPatch }
		public CoverageTypeEnum CoverageType;

        /* 0x018 */ public float PatchSize;
        /* 0x01C */ public float RegionScale;
    }
}