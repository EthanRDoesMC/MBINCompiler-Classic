﻿namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x88175D4FD88CF82D)]
    public class GcExpeditionCategory : NMSTemplate
    {
		public enum ExpeditionCategoryEnum { Combat, Exploration, Mining, Diplomacy, Balanced }
		public ExpeditionCategoryEnum ExpeditionCategory;
    }
}