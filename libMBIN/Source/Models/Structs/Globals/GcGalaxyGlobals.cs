namespace libMBIN.Models.Structs
{
    public class GcGalaxyGlobals : NMSTemplate
    {
        /* 0X0 */ public float PathUIWidth;
        /* 0X4 */ public float StarPathUIWidth;
        /* 0X8 */ public float FadeGameOutTimeCentreJourney;
        /* 0XC */ public float FadeMapInTimeCentreJourney;
        /* 0X10 */ public float PathUIAlpha;
        /* 0X14 */ public float PathUIDotLength;
        /* 0X18 */ public float PathUIGapLength;      // possibly NextStarSelectionLineThickness? (old comment)
        /* 0X1C */ public float PathUISelectionMultiplierPad;
        /* 0X20 */ public float PathUISelectionMultiplierMouse;
        /* 0X24 */ public float PathUISelectionMultiplierPushing;
        /* 0X28 */ public float PathUISelectionGenerosity;
        /* 0X2C */ public float PathUISelectionMouseSmoothRate;
        /* 0X30 */ public float PathUISelectionMouseDeadZone;
        /* 0X34 */ public float PathUIHeight;
        /* 0X38 */ public float PathUIXOffset;
        /* 0X3C */ public float PathUIYOffset;
        /* 0X40 */ public float PathUISlotSpacing;
        /* 0X44 */ public float PathUISlotRadiusInner;
        /* 0X48 */ public float PathUISlotRadiusOuter;
        /* 0X4C */ public float PathUISlotRadiusRing;
        /* 0X50 */ public float PathUISlotWidthRing;
        /* 0X54 */ public float MarkerDropShadowSize;
        /* 0X58 */ public float MarkerDropShadowMult;
        /* 0X5C */ public float PlanetUIIconLargeScale;
        /* 0X60 */ public float PlanetUIIconMediumScale;
        /* 0X64 */ public float PlanetUIIconSmallScale;
        /* 0X68 */ public float ShowPopupAtCameraMinDistance;
        /* 0X6C */ public float GalacticPathMaximumJumpDistanceLightyears;
        /* 0X70 */ public float GalacticPathPreferGuideStarsTillJump;
        /* 0X74 */ public float ShowUIHelpDuration;
        /* 0X78 */ public float SystemInfoPanelGeneralAlpha;
        /* 0X7C */ public TkCurveType MarkerPulseStartCurve;
        /* 0X80 */ public TkCurveType MarkerPulseEndCurve;
        /* 0X84 */ public float Unknown84; // == 0
        /* 0X88 */ public float Unknown88; // == 0
        /* 0X8C */ public float Unknown8C; // == 0, none of these are in NEXT?
        [NMS(Size = 0x5, EnumValue = new[] { "Core", "FreeRoam", "Waypoint", "Blackhole", "Atlas" })]
        /* 0x90 */ public Colour[] PathIconColours;
        /* 0XE0 */ public Colour UnknownE0; // from here to 0x1F0 is actually arrays of colors
        /* 0XF0 */ public Colour UnknownF0; // they are for the filters
        /* 0X100 */ public Colour Unknown100; // probably best to just steal these from mbinc 1.55 lol
        /* 0X110 */ public Colour Unknown110;
        /* 0X120 */ public Colour Unknown120;       // possibly another GcGalaxyStarColours. Probably this one because alignment makes sense...
        /* 0X130 */ public Colour Unknown130;       // somewhere here?
        /* 0X140 */ public Colour Unknown140;
        /* 0X150 */ public Colour Unknown150;
        /* 0X160 */ public Colour Unknown160;
        /* 0X170 */ public Colour Unknown170;
        /* 0X180 */ public Colour Unknown180;
        /* 0X190 */ public Colour Unknown190;
        /* 0X1A0 */ public Colour Unknown1A0;
        /* 0X1B0 */ public Colour Unknown1B0;
        /* 0X1C0 */ public Colour Unknown1C0;
        /* 0X1D0 */ public Colour Unknown1D0;
        /* 0X1E0 */ public Colour Unknown1E0;
        /* 0X1F0 */ public Colour Unknown1F0;
        [NMS(Size = 0xA, EnumValue = new[] { "StartingLocation", "Home", "Waypoint", "Contact",
                           "Blackhole", "AtlasStation", "Selection", "PlanetBase",
                           "Visited", "ScanEvent"})] // labels for mbinc exml out
        /* 0x200 */ public GcGalaxyMarkerSettings[] MarkerSettings;
        /* 0XD40 */ public float IntroFadeInRate;
        /* 0XD44 */ public float IntroTitleFadeTrigger;
        /* 0XD48 */ public float IntroTitleHoldTime;
        /* 0XD4C */ public float IntroFadeOutRate;
        /* 0XD50 */ public float IntroCameraLookSmoothRate;
        /* 0XD54 */ public float IntroTitleTextureScale;
        /* 0XD58 */ public float TransitionTime;
        /* 0XD5C */ public float TransitionOutCurve;
        /* 0XD60 */ public float FinalHoldTime;
        /* 0XD64 */ public float FinalFadedTime;
        /* 0XD68 */ public float FinalHoldTowardsCenterTime;
        /* 0XD6C */ public float FinalFadeInRate;
        /* 0XD70 */ public float FinalFadeOutRate;
        /* 0XD74 */ public float FinalTransitionMaxSpeed;
        /* 0XD78 */ public float FinalTransitionAcceleration;
        /* 0XD7C */ public float FinalTransitionInterpolationValue;
        /* 0XD80 */ public float EarlyStageMultiplier;
        /* 0XD84 */ public float OffWorldDistance;
        /* 0XD88 */ public float DistanceComputerScale;
        /* 0XD8C */ public float PathRenderingSelectedStartAlpha;
        /* 0XD90 */ public float PathRenderingSelectedEndAlpha;
        /* 0XD94 */ public float PathRenderingSelectedStepAlpha;
        /* 0XD98 */ public float PathRenderingUnselectedStartAlpha;
        /* 0XD9C */ public float PathRenderingUnselectedEndAlpha;
        /* 0XDA0 */ public float PathRenderingUnselectedStepAlpha;
        /* 0XDA4 */ public float StarBlurMaxDistanceFromCamera;
        /* 0XDA8 */ public float StarBlurMaxBlurLength;
        /* 0XDAC */ public float StarBlurSizeMultiplier;
        /* 0XDB0 */ public float StarBlurLineWidth;
        /* 0XDB4 */ public float StarBlurIntroMultiplier;
        /* 0XDB8 */ public float AnostreakAlpha;
        /* 0XDBC */ public TkCurveType AnostreakAlphaCurve;
        /* 0XDC0 */ public TkCurveType AnostreakValueCurve;
        /* 0XDC4 */ public float UnknownDC4; // 0
        /* 0XDC8 */ public float UnknownDC8; // 0
        /* 0XDCC */ public float UnknownDCC; // 0... again. Vector3f?
        /* 0XDD0 */ public GcGalaxyRenderAnostreakData AnostreakAway;
        /* 0XE00 */ public GcGalaxyRenderAnostreakData AnostreakFacing;
        /* 0XE30 */ public float SelectionTreeAlpha;
        /* 0XE34 */ public float UnknownE34; // 0
        /* 0XE38 */ public float UnknownE38; // 0
        /* 0XE3C */ public float UnknownE3C; // can you guess
        /* 0XE40 */ public Colour SelectionTreeColour;
        /* 0XE50 */ public Vector2f GoalDistanceRange;
        /* 0XE58 */ public float UnknownE58; // 0
        /* 0XE5C */ public float UnknownE5C; // 0
        /* 0XE60 */ public GcGalaxyStarColours BaseStarColours;
        /* 0xEA0 */ public GcGalaxyCameraData Camera;
        /* 0xF04 */ public GcGalaxyAudioSetupData Audio;
        /* 0xF48 */ public float FadeGameOutTime;
        /* 0xF4C */ public float FadeMapInTime;
        /* 0xF50 */ public float MadeMapOutTime;
        /* 0xF54 */ public float FadeGameInTime;
        /* 0xF58 */ public float LargeAreaColourScale;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0xF5C */ public byte[] PaddingF5C;
        /* 0xF60 */ public GcGalaxyRenderSetupData DefaultRenderSetup;
        /* 0x1170 */ public GcGalaxyGenerationSetupData DefaultGeneration;
        /* 0x12F0 */ public GcGalaxyRenderSetupData FinalAnimationRenderSetup;
        /* 0x1500 */ public GcGalaxyGenerationSetupData FinalAnimationGeneration;

        /* 0X1680 */ public GcGalaxySolarSystemParams SolarSystemParameters;
        [NMS(Size = 0x8, Ignore = true)]
        public byte[] EndPadding;
    }
}
