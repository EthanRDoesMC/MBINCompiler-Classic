﻿namespace libMBIN.Models.Structs.Unfinished
{
    public class GcEnvironmentGlobals : NMSTemplate
    {
        /* 0x000 */ public Vector2f SpaceBuildingTemperature;
        [NMS(Size = 8, Ignore = true)]
        public byte[] Padding8;
        /* 0x010 */ public GcCloudProperties CloudProperties;
        /* 0x100 */ public float SenseProbingValueSmoothingTime;
        /* 0x104 */ public float SenseProbingValueSmoothingTimeSlow;
        /* 0x108 */ public float MaxElevation;
        /* 0x10C */ public float SphereLodTextureScale;
        /* 0x110 */ public bool ForceAddUnderwaterProps;         // only checked on system warp          related to caves
        /* 0x111 */ public bool ForceAddCaveProps;               // only checked on system warp          related to caves
        public float Unknown114;
        public float Unknown118;
        public float Unknown11C;
        public float Unknown120;
        public float Unknown124;
        public float Unknown128;
        public float Unknown12C;
        public float Unknown130;
        public float Unknown134;
        public float Unknown138;
        public float Unknown13C;
        public float Unknown140;
        public float Unknown144;
        public float Unknown148;
        public float Unknown14C;
        public float Unknown150;
        public float Unknown154;
        public float Unknown158;
        public float Unknown15C;
        public bool Unknown160;         // makes a bunch of colours get swapped around too
        public float Unknown164;        // something to do with colour palettes for terrain generation
        public int UnknownInt168;
        public float Unknown16C;
        public float Unknown170;
        public float Unknown174;
        public float Unknown178;
        public float Unknown17C;
        public float Unknown180;
        public float Unknown184;
        public float Unknown188;
        public float Unknown18C;
        public float Unknown190;
        public float Unknown194;
        public float Unknown198;
        /* 0x19C */ public float TerrainLODFadeSpeed;
        public float Unknown1A0;
        public float Unknown1A4;
        public float Unknown1A8;
        public float Unknown1AC;
        public float Unknown1B0;
        public float Unknown1B4;
        public float Unknown1B8;
        public float Unknown1BC;
        public float Unknown1C0;
        public float Unknown1C4;
        public float Unknown1C8;
        public float Unknown1CC;
        public float Unknown1D0;
        public float Unknown1D4;
        public float Unknown1D8;
        /* 0x1DC */ public float MinCloudHeight;
        /* 0x1E0 */ public float MaxCloudHeight;
        public float Unknown1E4;
        public float Unknown1E8;
        public float Unknown1EC;
        public float Unknown1F0;
        public float Unknown1F4;
        public float Unknown1F8;
        public float Unknown1FC;
        public float Unknown200;
        public float Unknown204;
        public float Unknown208;
        public float Unknown20C;
        /* 0x210 */ public float HiLODStartHeight;
        public float Unknown214;
        public float Unknown218;
        /* 0x21C */ public float PlanetActiveZoneHeight;
        /* 0x220 */ public float AtmosphericCloudsDrawDistance;
        public float Unknown224;
        public float Unknown228;
        public float Unknown22C;
        public float Unknown230;
        public float Unknown234;
        public float Unknown238;
        public float Unknown23C;
        public float Unknown240;
        public float Unknown244;
        public float Unknown248;
        public float Unknown24C;
        public float Unknown250;
        public float Unknown254;
        public float Unknown258;
        public float Unknown25C;
        public float Unknown260;
        public float Unknown264;
        public float Unknown268;
        public float Unknown26C;
        public float Unknown270;
        /* 0x274 */ public float MinBaseFogIntensity;
        /* 0x278 */ public float MaxBaseFogIntensity;
        public float Unknown27C;
        public float Unknown280;
        public float Unknown284;
        public float Unknown288;
        public float Unknown28C;
        public float Unknown290;
        public float Unknown294;
        public float Unknown298;
        public float Unknown29C;
        public float Unknown2A0;
        public float Unknown2A4;
        public float Unknown2A8;
        public float Unknown2AC;
        public float Unknown2B0;
        public float Unknown2B4;
        public float Unknown2B8;
        /* 0x2BC */ public float SurfaceSunlightActiveHeight;       // used with 0x2C0 to scale a value
        public float Unknown2C0;                                    // scale factor used with the above
        public float Unknown2C4;
        public float Unknown2C8;
        public float Unknown2CC;
        public float Unknown2D0;
        public float Unknown2D4;
        public float Unknown2D8;
        public bool Unknown2DC;
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] Padding2DD;

        /* 0x2E0 */ public TkShearWindData WindData;
        /* 0x360 */ public TkShearWindData StrongWindData;
        /* 0x3E0 */ public TkShearWindData UnderwaterWindData;
    }
}
