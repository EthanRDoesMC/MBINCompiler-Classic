namespace libMBIN.Models.Structs
{
    public class GcSkyGlobals : NMSTemplate
    {
        /* 0X0 */ public float NightThreshold;
        /* 0X4 */ public GcPhotoModeAdjustData FogAdjust;
        /* 0X1C */ public GcPhotoModeAdjustData CloudAdjust;
        /* 0X34 */ public GcPhotoModeAdjustData VignetteAdjust;
        /* 0X4C */ public float Unknown4C; // = 0; DoFAdjustMagnitudeMaxCurve = Linear?
        /* 0X50 */ public float DayLength;
        /* 0X54 */ public bool EnableDayNightCycle;      // if False then the time of day will not change
        [NMS(Size = 11, Ignore = true)]
        /* 0X55 */ public byte[] Padding55;
        /* 0X60 */ public Vector4f SunRotationAxis

        /* 0X70 */ public float SunClampAngle; // MaximumShadowAngle;     // this is the maximum angle the shadows will go to (relative to the 
        /* 0X74 */ public bool ForceStormSetting;
        /* 0X78 */ public float ForceStormStrength;
        // option 1's are the default ones
        /* 0X7C */ public float Unknown7C;              // option 1a-min
        /* 0X80 */ public float Unknown80;              // option 1a-max
        /* 0X84 */ public float Unknown84;              // option 2a-min
        /* 0X88 */ public float Unknown88;              // option 2a-max
        /* 0X8C */ public float Unknown8C;              // option 1b-min
        /* 0X90 */ public float Unknown90;              // option 1b-max
        /* 0X94 */ public float Unknown94;              // option 2b-min
        /* 0X98 */ public float Unknown98;              // option 2b-max
        /* 0X9C */ public float Unknown9C;              // something to do with the weather warning maybe?
        /* 0XA0 */ public bool ForceFlightSetting; // force flight - no idea what that means
        /* 0XA4 */ public float ForceFlightStrength;
        /* 0XA8 */ public float ToFootFadeTime;
        /* 0XAC */ public float ToFlightFadeTime;
        /* 0XB0 */ public float InFlightStormStrength;
        /* 0XB4 */ public float CreatureStormThreshold;
        /* 0XB8 */ public float TakeoffStormThreshold;
        /* 0XBC */ public float ExtremeAudioLevel;
        /* 0XC0 */ public float StormAudioLevel;
        /* 0XC4 */ public bool SleepSunFromSettings;
        /* 0XC8 */ public float UnknownC8; // = 0
        /* 0XCC */ public float UnknownCC; // = 0
        /* 0XD0 */ public Vector4f SleepSunFromSettingsPos;
        /* 0XE0 */ public Vector4f SunPosition;
        /* 0XF0 */ public Colour AsteroidColour;
        /* 0X100 */ public Colour DayLightColour;
        /* 0X110 */ public Colour NightLightColour;
        /* 0X120 */ public Colour DuskLightColour;
        /* 0X130 */ public Colour NightHeavyAirColour;
        /* 0X140 */ public Colour SpaceLightColour;
        /* 0X150 */ public float HeavyAirScale;
        /* 0X154 */ public float AmbientFactor;
        /* 0X158 */ public float Unknown158;
        /* 0X15C */ public float Unknown15C;
        /* 0X160 */ public float Unknown160;        // min
        /* 0X164 */ public float Unknown164;        // max
        /* 0X168 */ public float Unknown168;        // min
        /* 0X16C */ public float Unknown16C;        // max
        /* 0X170 */ public float Unknown170;        // min
        /* 0X174 */ public float Unknown174;        // max
        /* 0X178 */ public float Unknown178;
        /* 0X17C */ public float Unknown17C;
        /* 0X180 */ public float Unknown180;
        /* 0X184 */ public float Unknown184;
        /* 0X188 */ public float Unknown188;
        /* 0X18C */ public float Unknown18C;
        /* 0X190 */ public float Unknown190;
        /* 0X194 */ public float Unknown194;
        /* 0X198 */ public float Unknown198;
        /* 0X19C */ public float Unknown19C;
        /* 0X1A0 */ public float Unknown1A0;
        /* 0X1A4 */ public float Unknown1A4;
        /* 0X1A8 */ public float Unknown1A8;
        /* 0X1AC */ public float Unknown1AC;
        /* 0X1B0 */ public float Unknown1B0;
        /* 0X1B4 */ public float Unknown1B4;
        /* 0X1B8 */ public float Unknown1B8;
        /* 0X1BC */ public float Unknown1BC;
        /* 0X1C0 */ public float Unknown1C0;
        /* 0X1C4 */ public float Unknown1C4;
        /* 0X1C8 */ public float Unknown1C8;
        /* 0X1CC */ public float Unknown1CC;
        /* 0X1D0 */ public float Unknown1D0;
        /* 0X1D4 */ public float Unknown1D4;
        /* 0X1D8 */ public float Unknown1D8;
        /* 0X1DC */ public float Unknown1DC;
        /* 0X1E0 */ public float Unknown1E0;
        /* 0X1E4 */ public float Unknown1E4;
        /* 0X1E8 */ public float Unknown1E8;
        /* 0X1EC */ public float Unknown1EC;
        /* 0X1F0 */ public float Unknown1F0;
        /* 0X1F4 */ public float Unknown1F4;
        /* 0X1F8 */ public float WaterHeavyAirAlpha;           // value will be between 0 and 1. If it is set to a negative number then the value in the palette file is used.
        /* 0X1FC */ public float Unknown1FC;
        /* 0X200 */ public float Unknown200;
        /* 0X204 */ public float Unknown204;
        /* 0X208 */ public float Unknown208;
        /* 0X20C */ public float Unknown20C;
        /* 0X210 */ public float Unknown210;
        /* 0X214 */ public float Unknown214;
        /* 0X218 */ public float Unknown218;
        /* 0X21C */ public float Unknown21C;
        /* 0X220 */ public float Unknown220;
        /* 0X224 */ public float Unknown224;
        /* 0X228 */ public float Unknown228;
        /* 0x22C */ public float Unknown22C;
        /* 0X22C */ public GcSkyProperties PlanetSky;

        [NMS(Size = 0x4, EnumValue = new[] {"ClearFog", "StormFog", "ExtremeWeatherFog", "InFlightFog" })]
        /* 0x260 */ public GcFogProperties[] PlanetFogProperties;

        /* 0X5D0 */ public GcSpaceSkyProperties SpaceSkyMin;
        /* 0X670 */ public GcSpaceSkyProperties SpaceSkyMax;
        /* 0X710 */ public GcSpaceSkyColours Unknown710;    // array ending after 9B0
        /* 0X7F0 */ public GcSpaceSkyColours Unknown7F0;
        /* 0X8D0 */ public GcSpaceSkyColours Unknown8D0;
        /* 0X9B0 */ public GcSpaceSkyColours Unknown9B0;
        /* 0XA90 */ public GcPlanetWeatherColourData NightSkyColours;
        /* 0XB40 */ public float HackSpaceInterp1;
        /* 0XB44 */ public float HackSpaceInterp2;
        /* 0XB48 */ public long HackSpaceColourIndex; // <--- may be weird; set to -1 in NEXT
        ///* 0XB4C */ public float UnknownB4C;
        /* 0XB50 */ public Colour HeavyAirColour1;
        /* 0XB60 */ public Colour HeavyAirColour2;
        /* 0XB70 */ public Colour NightHorizonColour;
        /* 0XB80 */ public Colour NightSkyColour;
        /* 0XB90 */ public Colour NightFogColour;
        /* 0XBA0 */ public Colour NightHeightFogColour;
    }
}
