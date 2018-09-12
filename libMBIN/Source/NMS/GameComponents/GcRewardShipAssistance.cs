﻿namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0E3FCFF5B621FA649)]
    public class GcRewardShipAssistance : NMSTemplate
    {
		public enum AssistanceTypeEnum { Police, Wingmen }
		public AssistanceTypeEnum AssistanceType;

        public float Time;
    }
}