﻿using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x8E0C4DD242A5FA5D)]
    public class GcPlayerStatsGroup : NMSTemplate // 0x28 bytes
    {
        [NMS(Size = 0x10)]
        public string GroupId;

        public ulong Address;

        public List<GcPlayerStat> Stats;
    }
}