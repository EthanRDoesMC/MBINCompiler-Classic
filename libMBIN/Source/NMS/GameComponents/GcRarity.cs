﻿namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x254FD01AB6B98C6A)]
    public class GcRarity : NMSTemplate
    {

		public enum RarityEnum { Common, Uncommon, Rare, Extraordinary, None }
		public RarityEnum Rarity;
    }
}