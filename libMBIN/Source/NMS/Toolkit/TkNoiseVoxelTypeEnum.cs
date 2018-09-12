﻿namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x68CC5C66BE9C1E10)]
    public class TkNoiseVoxelTypeEnum : NMSTemplate
    {
		public enum NoiseVoxelTypeEnum { Base, Rock, Mountain, Sand, Cave, Substance_1, Substance_2, Substance_3, RandomRock, RandomRockOrSubstance }
		public NoiseVoxelTypeEnum NoiseVoxelType;
    }
}