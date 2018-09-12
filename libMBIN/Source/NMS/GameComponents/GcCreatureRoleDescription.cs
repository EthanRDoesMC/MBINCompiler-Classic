﻿namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x40, GUID = 0x0FB244025F9941C1A)]
    public class GcCreatureRoleDescription : NMSTemplate
    {
        public GcCreatureRoles CreatureRole;
        public GcCreatureTypes CreatureType;

        [NMS(Size = 0x10)]
        public string ForceID;

        public float MinGroupScale;
        public float MaxGroupScale;
        public int MinGroupSize;
        public int MaxGroupSize;
        public float GroupsPerSquareKm;
        public float FractionActiveInDay;
        public float FractionActiveInNight;
        public float ProbabilityOfBeingEnabled;
        public float IncreasedSpawnDistance;
    
        [NMS(Ignore = true)]
        public int Padding;
    }
}