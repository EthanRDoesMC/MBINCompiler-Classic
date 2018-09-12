﻿namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x70, GUID = 0x0DAB31CFBF20311E9)]
    public class GcColourPaletteData : NMSTemplate
    {
        [NMS(Size = 0x5)]
        public Colour[] Colours;
        [NMS(Size = 0x5)]
        public int[] ColourIndices;
        [NMS(Size = 0xC, Ignore = true)]
        public byte[] EndPadding;
    }
}