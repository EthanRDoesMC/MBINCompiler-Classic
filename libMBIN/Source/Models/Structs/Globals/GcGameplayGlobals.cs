namespace libMBIN.Models.Structs
{
    public class GcGameplayGlobals : NMSTemplate
    {
        /* 0X0 */ public float MissionEventAllowResetDistance; // ?
        /* 0X4 */ public float Unknown4; // maybe AllRecipesKnownNaniteMin/Max?
        /* 0X8 */ public float Unknown8;
        /* 0XC */ public float MaxPossibleShipDamagePotential;
        /* 0X10 */ public float BuildingPlayerBaseIconOffset;
        /* 0X14 */ public float Unknown14; // i have no idea what these are
        /* 0X18 */ public float Unknown18;
        /* 0X1C */ public float Unknown1C;
        /* 0X20 */ public float Unknown20;
        /* 0X24 */ public float Unknown24;
        /* 0X28 */ public float Unknown28;
        /* 0X2C */ public float Unknown2C;
        /* 0X30 */ public float Unknown30;
        /* 0X34 */ public float Unknown34;
        /* 0X38 */ public float Unknown38;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x3C */ public byte[] Padding3C;
        /* 0x40 */ public GcScanEffectData Unknown40; // table 40..130
        /* 0x90 */ public GcScanEffectData Unknown90;
        /* 0xE0 */ public GcScanEffectData UnknownE0;
        /* 0x130 */ public GcScanEffectData Unknown130;

        /* 0X180 */ public int MaxNumMissionsFromMissionGiver;
        /* 0X184 */ public float InteractionMessageModuleDisplayTime;
        /* 0X188 */ public float InteractionAttractTime;
        /* 0X18C */ public float InteractionDescriptionTextTime;
        /* 0X190 */ public float InteractionMinTimeForResponseText;
        /* 0X194 */ public bool InteractionOverride; // = false
        /* 0X198 */ public int InteractionOverrideFrom; // = 2
        /* 0X19C */ public int InteractionOverrideTo; // = 47, probably an enum?
        /* 0X1A0 */ public float DestroyEffectHeight;
        /* 0X1A4 */ public float DestroyEffectMaxScale;
        /* 0X1A8 */ public float EventTargetSpeed;
        /* 0X1AC */ public int SpecialMiningAmount;
        /* 0X1B0 */ public float SpecialMiningTime;
        /* 0X1B4 */ public int HardModeTechDamageMidNum;
        /* 0X1B8 */ public int HardModeTechDamageMidPercent;
        /* 0X1BC */ public int HardModeTechDamageHighPercent;
        /* 0X1C0 */ public float PirateInterestOverride;
        /* 0X1C4 */ public float PirateInterestDistance;
        /* 0X1C8 */ public int UnknownInt1C8; // PirateInterestLevels 1C8..1D0
        /* 0X1CC */ public int UnknownInt1CC;
        /* 0X1D0 */ public int UnknownInt1D0;
        /* 0X1D4 */ public float SpaceCombatRadius;
        /* 0X1D8 */ public int WarpsBetweenBattles; // line 256 in NEXT exml
        /* 0X1DC */ public float HoursBetweenBattles;
        /* 0X1E0 */ public float SpaceBattleRadius;
        /* 0X1E4 */ public float FreighterBattleRadius;
        /* 0X1E8 */ public float MissileMaxTurnAngle;
        /* 0X1EC */ public float MissileLockTime;
        /* 0X1F0 */ public float MissileReloadTime;
        /* 0X1F4 */ public float MissileRotateMin;
        /* 0X1F8 */ public float MissileRotateMax;
        /* 0X1FC */ public float MissileMaxSpeed;
        /* 0X200 */ public float MissileForceMin;
        /* 0X204 */ public float MissileForceMax;
        /* 0X208 */ public float MissileBrakeForceMin;
        /* 0X20C */ public float MissileBrakeForceMax;
        /* 0X210 */ public float MissileThreatTime;        // not used??
        /* 0X214 */ public float MissileBreakTime;
        /* 0X218 */ public float MissileHitRadius;
        /* 0X21C */ public float MissileOffset;
        /* 0X220 */ public float MissileMinCircleTime;
        /* 0X224 */ public float MissileApproachTime;
        /* 0X228 */ public float MissileRotateSpeed;
        /* 0X22C */ public float Unknown22C; // likely related to scanning?
        /* 0X230 */ public float Unknown230;
        /* 0X234 */ public float Unknown234;
        /* 0X238 */ public float NewDiscoveryDisplayTime;
        /* 0X23C */ public bool FailToFindBuildings;         // something to do with building generation?? Maybe 'Don't generate buildings'? // CLOSE, you got close! leaving annotation as it may help explain how finding buildings works
        /* 0X240 */ public int CritDamage; //RearShotDamageMultiplier;
        /* 0X244 */ public float CritScale;
        /* 0X248 */ public int NumMissionsPerSolarSystem;
        /* 0X24C */ public float EmergencyBuildingScanEventDistance;
        /* 0X250 */ public float EmergencyBuildingScanEventTime;
        /* 0X254 */ public float ProjectileLightIntensity;
        /* 0X258 */ public float AggressiveSentinelProbability;

        /* the following is a GcExperienceTimers struct, but 
        I have expanded it so that the individual values can be named appropriately */
	    /* 0x25C */ public int SentinelTimer_Default_Chance_percent;        // if *rand* > value, sentinel timer is A, then check Timer_B chance
	    /* 0x260 */ public int SentinelTimer_B_Chance_percent;
	    /* 0x264 */ public Vector2f SentinelTimer_Default_or_Aggressive;       // for agressive sentinals and...
	    /* 0x26C */ public Vector2f SentinelTimer_A;
	    /* 0x274 */ public Vector2f SentinelTimer_B;
// keeping expansion, this is good
        
        /* 0x27C */ public int FreighterStartPercent;

        /* 0x280 */ public GcExperienceTimers FreighterTimers;
        /* 0x2A0 */ public GcExperienceTimers PirateTimers; // for normal mode
        /* 0x2C0 */ public GcExperienceTimers HardPirateTimers; // for hard mode
        /* 0X2E0 */ public float Unknown2E0; // PirateEarlySpawnChances 2E0..2E8
        /* 0X2E4 */ public float Unknown2E4;
        /* 0X2E8 */ public float Unknown2E8;
        /* 0X2EC */ public float PirateEarlySpawnTime;

        // OnPlanet FlybyTimer determination
        /* 0x2F0 */ public int FlybyTimer_Default_Chance_percent;
	    /* 0x2F4 */ public int FlyByTimer_B_Chance_percent;
	    /* 0x2F8 */ public Vector2f FlybyTimer_Default;
	    /* 0x300 */ public Vector2f FlybyTimer_A;                     
	    /* 0x308 */ public Vector2f FlybyTimer_B_or_Aggressive;                            // planetdata flyby on agressive sentinal planets (maybe??)
// maybe these should be their own type? wouldn't hurt anything
        /* 0x310 */ public GcExperienceTimers SpaceFlybyTimers;

        /* 0x330 */ public int UnknownInt330;
        /* 0X334 */ public int UnknownInt334;
        /* 0X338 */ public int UnknownInt338;
        /* 0X33C */ public float Unknown33C;
        /* 0X340 */ public float Unknown340;
        /* 0X344 */ public int UnknownInt344;
        /* 0X348 */ public int UnknownInt348;
        /* 0X34C */ public int UnknownInt34C;
        /* 0X350 */ public float Unknown350;
        /* 0X354 */ public float Unknown354;
        /* 0X358 */ public int UnknownInt358;
        /* 0X35C */ public int UnknownInt35C;
        /* 0X360 */ public int UnknownInt360;
        /* 0X364 */ public int UnknownInt364;
        /* 0X368 */ public int UnknownInt368;
        /* 0X36C */ public int MinedMetalMultipierMin;
        /* 0X370 */ public int MinedMetalMultipierMax;
        /* 0X374 */ public int UnknownInt374;
        /* 0X378 */ public int UnknownInt378;
        /* 0X37C */ public int UnknownInt37C;

        [NMS(Size = 0x20)]
        /* 0x380 */ public string Unknown380;
        [NMS(Size = 0x20)]
        /* 0x3A0 */ public string Unknown3A0;

        /* 0X3C0 */ public float Unknown3C0;
        /* 0X3C4 */ public float Unknown3C4;
        /* 0X3C8 */ public float ShipTransferRange;
        /* 0X3CC */ public GcResourceCollectEffect Unknown3CC;
        /* 0X400 */ public float Unknown400;

        /* 0x404 */ public GcScanData NormalModeScanning;
        /* 0x418 */ public GcScanData SurvivalModeScanning;
        /* 0x42C */ public GcScanData Unknown42C;
        /* 0x440 */ public GcScanData Unknown440;
        /* 0x454 */ public GcScanData Unknown454;
        /* 0x468 */ public GcScanData Unknown468;
        /* 0x47C */ public GcScanData Unknown47C;
        /* 0x490 */ public GcScanData Unknown490;
        /* 0x4A4 */ public GcScanData Unknown4A4;
        /* 0x4B8 */ public GcScanData ShipScanning;

        /* 0x4CC */ public float Unknown4CC;
        /* 0x4D0 */ public float Unknown4D0;
        /* 0x4D4 */ public float Unknown4D4;
        /* 0x4D8 */ public int UnknownInt4D8;
        /* 0x4DC */ public int UnknownInt4DC;

        /* 0x4E0 */ public GcZoomData Unknown4E0;
        /* 0x4FC */ public GcZoomData Unknown4FC;
        /* 0x518 */ public GcZoomData Unknown518;
        /* 0x534 */ public GcZoomData Unknown534;

        /* 0x550 */ public GcScanEffectData Unknown550;
        /* 0x5A0 */ public GcScanEffectData Unknown5A0;
        /* 0x5F0 */ public GcScanEffectData Unknown5F0;
        /* 0x640 */ public GcScanEffectData Unknown640;
        /* 0x690 */ public GcScanEffectData Unknown690;
        /* 0x6E2 */ public GcScanEffectData Unknown6E2;
        /* 0x730 */ public GcScanEffectData Unknown730;
        /* 0x780 */ public GcScanEffectData Unknown780;
        /* 0x7D0 */ public GcScanEffectData Unknown7D0;
        /* 0x820 */ public GcScanEffectData Unknown820;
        /* 0x870 */ public GcScanEffectData Unknown870;

        /* 0X8C0 */ public float Unknown8C0;
        /* 0X8C4 */ public float Unknown8C4;
        /* 0X8C8 */ public float Unknown8C8;
        /* 0X8CC */ public float Unknown8CC;
        /* 0X8D0 */ public int UnknownInt8D0;
        /* 0X8D4 */ public float Unknown8D4;
        /* 0X8D8 */ public float Unknown8D8;
        /* 0X8DC */ public float Unknown8DC;
        /* 0X8E0 */ public float Unknown8E0;
        /* 0X8E4 */ public float AbovegroundScanCubeTime;
        /* 0X8E8 */ public float Unknown8E8;
        /* 0X8EC */ public float Unknown8EC;
        /* 0X8F0 */ public float Unknown8F0;
        /* 0X8F4 */ public float Unknown8F4;
        /* 0X8F8 */ public float Unknown8F8;
        /* 0X8FC */ public float Unknown8FC;
        /* 0X900 */ public float Unknown900;
        /* 0X904 */ public float Unknown904;
        /* 0X908 */ public float Unknown908;
        /* 0X90C */ public bool Unknown90C;
        /* 0X910 */ public float Unknown910;
        /* 0X914 */ public float Unknown914;
        /* 0X918 */ public float Unknown918;
        /* 0X91C */ public float Unknown91C;
        /* 0X920 */ public float Unknown920;
        /* 0X924 */ public float Unknown924;
        /* 0X928 */ public float Unknown928;
        /* 0X92C */ public float Unknown92C;
        /* 0X930 */ public float Unknown930;
        /* 0X934 */ public float Unknown934;
        /* 0X938 */ public float Unknown938;
        /* 0X93C */ public float Unknown93C;
        /* 0X940 */ public float Unknown940;
        /* 0X944 */ public float Unknown944;
        /* 0X948 */ public float Unknown948;
        /* 0X94C */ public float Unknown94C;
        /* 0X950 */ public float Unknown950;
        /* 0X954 */ public float Unknown954;
        /* 0X958 */ public float Unknown958;
        /* 0X95C */ public float Unknown95C;
        /* 0X960 */ public float Unknown960;
        /* 0X964 */ public float Unknown964;
        /* 0X968 */ public float Unknown968;
        /* 0X96C */ public float Unknown96C;
        /* 0X970 */ public float Unknown970;
        /* 0X974 */ public float Unknown974;
        /* 0X978 */ public float Unknown978;
        /* 0X97C */ public float Unknown97C;
        /* 0X980 */ public float Unknown980;
        /* 0X984 */ public float Unknown984;
        /* 0X988 */ public float Unknown988;
        /* 0X98C */ public float Unknown98C;
        /* 0X990 */ public float Unknown990;
        /* 0X994 */ public float Unknown994;
        /* 0X998 */ public float Unknown998;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x99C */ public byte[] Padding99C;

        /* 0x9A0 */ public GcShipHUDTargetData Unknown9A0;

        /* 0XDD0 */ public float UnknownDD0;
        /* 0XDD4 */ public float UnknownDD4;
        /* 0XDD8 */ public float UnknownDD8;
        /* 0XDDC */ public float UnknownDDC;
        /* 0XDE0 */ public float UnknownDE0;
        /* 0XDE4 */ public float UnknownDE4;
        /* 0XDE8 */ public float UnknownDE8;
        /* 0XDEC */ public float UnknownDEC;

        [NMS(Size = 0x80)]
        /* 0xDF0 */ public string UnknownDF0;

        /* 0XE70 */ public float UnknownE70;
        /* 0XE74 */ public float UnknownE74;
        /* 0XE78 */ public int UnknownIntE78;
        /* 0XE7C */ public int UnknownIntE7C;
        /* 0XE80 */ public float UnknownE80;
        /* 0XE84 */ public float UnknownE84;
        /* 0XE88 */ public float UnknownE88;
        /* 0XE8C */ public float UnknownE8C;
        /* 0XE90 */ public float UnknownE90;
        /* 0XE94 */ public float UnknownE94;
        /* 0XE98 */ public float UnknownE98;
        /* 0XE9C */ public float UnknownE9C;
        /* 0XEA0 */ public float UnknownEA0;
        /* 0XEA4 */ public float UnknownEA4;
        /* 0XEA8 */ public float UnknownEA8;
        /* 0XEAC */ public float UnknownEAC;
        /* 0XEB0 */ public float UnknownEB0;
        /* 0XEB4 */ public float UnknownEB4;
        /* 0XEB8 */ public float UnknownEB8;
        /* 0XEBC */ public float UnknownEBC;
        /* 0XEC0 */ public int UnknownIntEC0;
        /* 0XEC4 */ public float UnknownEC4;
        /* 0XEC8 */ public float UnknownEC8;
        /* 0XECC */ public float UnknownECC;
        /* 0XED0 */ public float UnknownED0;
        /* 0XED4 */ public float UnknownED4;
        /* 0XED8 */ public float UnknownED8;
        /* 0XEDC */ public float UnknownEDC;
        /* 0XEE0 */ public float UnknownEE0;
        /* 0XEE4 */ public float UnknownEE4;
        /* 0XEE8 */ public float UnknownEE8;
        /* 0XEEC */ public float UnknownEEC;
        /* 0XEF0 */ public float UnknownEF0;
        /* 0XEF4 */ public float UnknownEF4;
        /* 0XEF8 */ public float UnknownEF8;
        /* 0XEFC */ public GcTracerData UnknownEFC;
        /* 0XF14 */ public GcTracerData UnknownF14;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0xF2C */ public byte[] PaddingF2C;

        [NMS(Size = 0x3)]
        /* 0xF30 */ public string UnknownF30;           // RUN
        [NMS(Size = 0xD, Ignore = true)]
        /* 0xF33 */ public byte[] PaddingF33;
        /* 0xF40 */ public bool UnknownF40;

        /* 0XF44 */ public float UnknownF44;
        /* 0XF48 */ public float UnknownF48;
        /* 0XF4C */ public float FlashlightAngle;
        /* 0XF50 */ public float FlashlightIntensity;
        /* 0XF54 */ public float FlashlightXoffset;
        /* 0XF58 */ public float FlashlightYoffset;     // this and the value following are grouped together in a QWORD in the exe
        /* 0XF5C */ public float FlashlightZoffset;
        /* 0XF60 */ public float UnknownF60;            // read by flashlight function, but doesn't seem to do anything...
        /* 0XF64 */ public float UnknownF64;            // unused?
        /* 0XF68 */ public float UnknownF68;            // unused?
        /* 0XF6C */ public float UnknownF6C;            // unused?
        /* 0XF70 */ public float UnknownF70;            // colour?
        /* 0XF74 */ public float UnknownF74;
        /* 0XF78 */ public float UnknownF78;
        /* 0XF7C */ public float UnknownF7C;
        /* 0XF80 */ public float UnknownF80;
        /* 0XF84 */ public float UnknownF84;
        /* 0XF88 */ public float UnknownF88;
        /* 0XF8C */ public float UnknownF8C;
        /* 0XF90 */ public float UnknownF90;
        /* 0XF94 */ public float UnknownF94;
        /* 0XF98 */ public float UnknownF98;
        /* 0XF9C */ public float UnknownF9C;
        /* 0XFA0 */ public float UnknownFA0;
        /* 0XFA4 */ public float UnknownFA4;
        /* 0XFA8 */ public float UnknownFA8;

        [NMS(Size = 0x80)]
        /* 0xFAC */ public string UnknownFAC;

        /* 0X102C */ public float AdditiveAdjacencyBonus;
        /* 0X1030 */ public float MultiplicativeAdjacencyBonus;
        /* 0X1034 */ public float LesserAdditiveAdjacencyBonus;
        /* 0X1038 */ public float LesserMultiplicativeAdjacencyBonus;
        /* 0X103C */ public float Unknown103C;
        /* 0X1040 */ public float Unknown1040;
        /* 0X1044 */ public float Unknown1044;          // only checked on game boot? Value directly below also...
        /* 0X1048 */ public float Unknown1048;
        /* 0X104C */ public float Unknown104C;          // unused?
        /* 0X1050 */ public int WarpsBetweenAnomalySpawns;
        /* 0X1054 */ public float HoursBetweenAnomalySpawns;

        [NMS(Size = 0x80)]
        /* 0x1058 */ public string Unknown1058;

        /* 0X10D8 */ public int UnknownInt10D8;
        /* 0X10DC */ public float Unknown10DC;
        /* 0X10E0 */ public float Unknown10E0;
        /* 0X10E4 */ public float Unknown10E4;
        /* 0X10E8 */ public int UnknownInt10E8;     // possibly two bools? WORD
        /* 0X10EC */ public float Unknown10EC;
        /* 0X10F0 */ public short UnknownShort10F0;
        /* 0x10F2 */ public bool Unknown10F2;
        /* 0x10F4 */ public int UnknownInt10F4;
        /* 0x10F8 */ public int UnknownInt10F8;
        /* 0x10FC */ public int UnknownInt10FC;
        /* 0x1100 */ public int UnknownInt1100;

        /* 0X1104 */ public GcPortalData Unknown1104;
        /* 0X110C */ public int UnknownInt110C;
        /* 0X1110 */ public float Unknown1110;
        /* 0X1114 */ public float HardModeHighStormFrequencyChance;
        /* 0X1118 */ public float HardModeExtremeWeatherChance;

        [NMS(Size = 0x4, Ignore = true)]
        /* 0x111C */ public byte[] EndPadding;
    }
}

/* Notes and algorithms:

Since the names for the sentinal timer and flyby timers are a bit hard to understand,
this is the algorithm that shows how the game uses them:

if SentinelLevel == Agressive:
	MaxActiveDrones = 1
	SentinelTimer = SentinelTimer_Default_or_Aggressive
	FlybyTimer = FlybyTimer_B_or_Aggressive
else:
	MaxActiveDrones = 2
	if RNG(0,100) >= SentinelTimer_Default_Chance_percent:
		SentinelTimer = SentinelTimer_A
		if RNG(0,100) < SentinelTimer_B_Chance_percent:
			SentinelTimer = SentinelTimer_B
	else:
		SentinelTimer = SentinelTimer_Default_or_Aggressive
	
	if RNG(0,100) >= FlybyTimer_Default_Chance_percent:
		FlybyTimer = FlybyTimer_A
		if RNG(0,100) < FlybyTimer_B_Chance_percent:
			FlybyTimer = FlybyTimer_B_or_Aggressive
	else:
		FlybyTimer = FlybyTimer_Default
*/