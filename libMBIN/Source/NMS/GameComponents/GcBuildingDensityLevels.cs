﻿namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x281D38B223BF41D8)]
    public class GcBuildingDensityLevels : NMSTemplate
    {
        public enum BuildingDensityEnum { Dead, Low, Mid, Full, Weird }
        public BuildingDensityEnum BuildingDensity;
    }
}