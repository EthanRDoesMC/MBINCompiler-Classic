﻿namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0A385A1C7FA49076F)]
    public class GcSolarSystemLocator : NMSTemplate // 0x60 bytes
    {
        [NMS(Size = 0x20)]
        public string Name;
        public GcSolarSystemLocatorTypes LocatorType;
        [NMS(Size = 0xC, Ignore = true)]
        public byte[] Padding24;

        public Vector4f Position;
        public Vector4f Direction;
        public float Radius;

        [NMS(Size = 0xC, Ignore = true)]
        public byte[] Padding54;
    }
}