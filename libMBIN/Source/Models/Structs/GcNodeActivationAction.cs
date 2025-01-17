﻿namespace libMBIN.Models.Structs
{
    public class GcNodeActivationAction : NMSTemplate   // size: 0x88 
    {
        public int NodeActiveState;
        /*0x00 */ public string[] NodeActiveStateValues()
        {
            return new[] { "Activate", "Deactivate", "Toggle" };
        }

        [NMS(Size = 0x80)]
        /* 0x04 */ public string Name;
        /* 0x84 */ public bool IncludePhysics;
        /* 0x85 */ public bool NotifyNPC;
        /* 0x86 */ public bool UseMasterModel;
        [NMS(Size = 1, Ignore = true)]
        /* 0x87 */ public byte[] EndPadding;
    }
}
