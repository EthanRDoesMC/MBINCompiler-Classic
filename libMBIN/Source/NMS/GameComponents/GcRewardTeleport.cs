﻿namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x91B99EE82BD627C2)]
    public class GcRewardTeleport : NMSTemplate
    {
		public enum TeleportRewardTypeEnum { None, ToBase, Station0, Station1, Station2, Station3, Atlas }
		public TeleportRewardTypeEnum TeleportRewardType;
    }
}