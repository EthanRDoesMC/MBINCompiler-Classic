﻿namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0D616F53EB85ECEEC)]
    public class GcBlockedMessage : NMSTemplate        // size: 0x80
    {
        [NMS(Size = 0x80)]
        public string MessageID;
    }
}