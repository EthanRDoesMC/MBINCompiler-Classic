﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcWeatherColourModifiers : NMSTemplate
    {
        public GcColourModifier SkyColour;
        public GcColourModifier HorizonColour;
        public GcColourModifier SunColour;
        public GcColourModifier FogColour;
        public GcColourModifier HeightFogColour;
        public GcColourModifier LightColour;
        public GcColourModifier CloudColour1;
        public GcColourModifier CloudColour2;

        [NMS(Size = 5)]
        public GcColourModifier[] HeavyAirColour;
    }
}
