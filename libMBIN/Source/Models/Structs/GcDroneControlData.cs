﻿namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x2C)]
    public class GcDroneControlData : NMSTemplate
    {
        public float MaxSpeed;                  // 41A00000h
        public float Strength;                  // 3FC00000h
        public float DirectionBrake;            // 3F800000h
        public float MinHeight;                 // 40A00000h
        public float MaxHeight;                 // 40A00000h
        public float HeightAdjustStrength;      // 40000000h
        public float HeightAdjustDownStrength;  // 3DCCCCCDh
        public float LookStrength;              // 3F800000h
        public float StopTime;                  // 3ECCCCCDh
        public float RepelForce;                // 41200000h
        public float RepelRange;                // 40A00000h
    }
}
