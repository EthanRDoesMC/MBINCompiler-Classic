﻿namespace libMBIN.Models.Structs
{
    public class GcSpaceSkyColours : NMSTemplate        // size: 0xE0
    {
	  /* 0x00 */ public Colour CloudColour;
	  /* 0x10 */ public Colour ColourTop;
	  /* 0x20 */ public Colour ColourMid;
	  /* 0x30 */ public Colour ColourBottom;
	  /* 0x40 */ public Colour ColourTopPlanet;
	  /* 0x50 */ public Colour ColourMidPlanet;
	  /* 0x60 */ public Colour ColourBottomPlanet;
	  /* 0x70 */ public Colour SunColour;
	  /* 0x80 */ public Colour NebulaColour1;
	  /* 0x90 */ public Colour NebulaColour2;
	  /* 0xA0 */ public Colour NebulaColour3;
	  /* 0xB0 */ public Colour NebulaShadowColour;
	  /* 0xC0 */ public Colour FogColour;
	  /* 0xD0 */ public Colour FogColour2;
    }
}
