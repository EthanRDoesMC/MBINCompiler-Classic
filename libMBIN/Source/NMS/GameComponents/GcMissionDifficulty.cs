﻿using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0AFF99D684E9C68AD)]
    public class GcMissionDifficulty : NMSTemplate
    {
		public enum MissionDifficultyEnum { Easy, Normal, Hard }
		public MissionDifficultyEnum MissionDifficulty;
    }
}