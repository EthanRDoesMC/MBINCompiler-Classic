﻿namespace libMBIN.Models.Structs
{
    public class TkNGuiGraphicStyleData :NMSTemplate        // size: 0x80
    {
        public float PaddingX;
        public float PaddingY;
        public float MarginX;
        public float MarginY;
        public Colour Colour;
        public Colour IconColour;
        public Colour StrokeColour;
        public int Shape;

        public string[] ShapeValues()
        { return new string[] { "Rectangle", "Ellipse" }; }


        public bool SolidColour;
        public bool HasDropShadow;
        public bool HasOuterGradient;
        public bool HasInnerGradient;
        public int Gradient;

        public string[] GradientValues()
        { return new string[] { "None", "Vertical", "Horizontal", "HorizontalBounce" }; }


        public float GradientStartOffset;
        public float GradientEndOffset;

        [NMS(Size = 0xC, Ignore = true)]
        public byte[] Padding1;

        public Colour GradientColour;
        public float CornerRadius;
        public float StrokeSize;
        public int Image;
        public int Icon;
    }
}
