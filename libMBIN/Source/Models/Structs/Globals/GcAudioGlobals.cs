namespace libMBIN.Models.Structs
{
    public class GcAudioGlobals : NMSTemplate
    {
        /* 0x000 */ public GcAudioNPCDoppler NPCEngines;
         
        /* 0x03C */ public GcAudio3PointDopplerData DroneDoppler;
        /* 0x048 */ public float AuxSendCaveRampDistance;
        /* 0x04C */ public float AuxSendOutdoorsRampDistance;
        /* 0x050 */ public float LadderStepDistance;
        /* 0x054 */ public float ShorelineSenseStartUp;
        /* 0x058 */ public float ShorelineSenseProbeDist;
        /* 0x05C */ public float ShorelineSenseBlend;
        /* 0x060 */ public float ShorelineSenseBaseU;
        /* 0x064 */ public Vector2f ShorelineSenseUJitter;
        /* 0x06C */ public Vector2f ShorelineSenseVJitter;
        /* 0x074 */ public Vector2f ShorelineSenseRadius;
        /* 0x07C */ public float ShorelineValidityRate;

        /* 0x080 */ public float ShorelineRTPCSmoothRate;
        /* 0x084 */ public float ShorelineObstructionSmoothRate;
        /* 0x088 */ public float ShorelineObstructionMul;
        /* 0x08C */ public float DroneDopplerExtentsFactor;
        /* 0x090 */ public float DistanceReportMin;
        /* 0x094 */ public float DistanceReportMax;
        /* 0x098 */ public float DistanceSquishScaleToListener;
        /* 0x09C */ public float DistanceSquishMaxTravel;
        /* 0x0A0 */ public float AtlasStationActiveDistance;
        /* 0x0A4 */ public float MiniStationActiveDistance;
        /* 0x0A8 */ public float PlayerDepthUnderwaterMax;
        /* 0x0AC */ public float PlayerLowerOffsetEmitterMul; //multiplier?
        /* 0x0B0 */ public bool ObstructionEnabled; // if false, main code chunk inside cGcAudioManager::RunObstructionQueries won't get run (default true)

        /* 0x0B4 */ public float ObstructionSmoothTime;
        /* 0x0B8 */ public float ObstructionValueMax;
        /* 0x0BC */ public float ObstructionAuxControlWhenVisible;
        /* 0x0C0 */ public float ObstructionAuxControlWhenHidden;

        /* 0x0C4 */ public bool PulseMusicEnabled; // if true, loads music from /MUSIC/PULSE.XML? (default true)        // WORD

        /* 0x0C8 */ public Vector2f CommsChatterFalloffFreighters;
        /* 0x0D0 */ public Vector2f CommsChatterFalloffShips;
    }
}
