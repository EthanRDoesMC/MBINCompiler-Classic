namespace libMBIN.Models.Structs
{
    public class GcSmokeTestOptions : NMSTemplate
    {
        /* 0x00 */ public float InitialPause; // 20.0
        /* 0x04 */ public float SmokeTestFlashTimeDuration; // 0.1
        /* 0x08 */ public float CameraHeight; // 4.5
        /* 0x0C */ public float CameraMoveSpeed; // 5
        
        // have these changed? are smoke tests in use? 
        /* 0x10 */ public int Unknown10; // 0 (unused?)
        /* 0x14 */ public int Unknown14; // 0
        /* 0x18 */ public int Unknown18; // 0 (unused?)
        /* 0x1C */ public int Unknown1C; // 25 (unused?)

        /* 0x20 */ public float Unknown20; // 0.3
        /* 0x24 */ public float Unknown24; // 60.0
    }
}
