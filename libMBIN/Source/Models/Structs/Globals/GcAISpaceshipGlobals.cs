﻿namespace libMBIN.Models.Structs
{
    public class GcAISpaceshipGlobals : NMSTemplate
    {
        /* 0X0 */ public float ShipAlertPirateRange;
        /* 0X4 */ public float EscapeRollTime;
        /* 0X8 */ public float EscapeRollPlanet;
        /* 0XC */ public float EscapeRoll;
        /* 0X10 */ public float Unknown10; // = 70; PirateSpawnSpacing?
        /* 0X14 */ public int CrashedShipMinNonBrokenSlots;
        /* 0X18 */ public float CrashedShipBrokenSlotChance;
        /* 0X1C */ public float CrashedShipBrokenTechChance;
        /* 0X20 */ public float CrashedShipRepairSlotCostIncreaseFactor;
        /* 0X24 */ public float CrashedShipGeneralCostDiscount;
        /* 0X28 */ public float CrashedShipTechSlotsCostDiscount;
        /* 0X2C */ public float DistanceFlareMinDistance;
        /* 0X30 */ public float DistanceFlareRange;
        /* 0X34 */ public float DistanceFlareMinScale;
        /* 0X38 */ public float DistanceFlareMaxScale;
        /* 0X3C */ public float DistanceFlareMinSpeed;
        /* 0X40 */ public float DistanceFlareSpeedRange;
        /* 0X44 */ public float DistanceFlareFlickerFreq;
        /* 0X48 */ public float DistanceFlareFlickerAmp;
        /* 0X4C */ public bool AttackRepositionBoost;         // just a WORD // [ethan]: changed from int to bool, guessing here
        /* 0X50 */ public float AttackTooCloseMinRelSpeed;
        /* 0X54 */ public float RewardLootOffset;
        /* 0X58 */ public float RewardLootOffsetSpeed;
        /* 0x5C */ public float RewardLootAngularSpeed; 
        /* 0x60 */ public GcSpaceshipTravelData PirateTravel;
        /* 0xB8 */ public GcSpaceshipTravelData PoliceTravel;
        /* 0x110 */ public GcSpaceshipTravelData TraderAttackTravel;
        /* 0X168 */ public float AttackShipAvoidStartTime;
        /* 0X16C */ public float AttackMinimumTimeBeforeTargetSwitch;
        /* 0x170 */ public GcShipAIAttackData Attack;
        /* 0X240 */ public float PirateExtraDamage;
        /* 0X244 */ public float ShieldCollisionRadiusMultiplier;
        /* 0X248 */ public float CollisionRayLengthMin;
        /* 0X24C */ public float CollisionRayLengthMax;
        /* 0x250 */ public GcSpaceshipTravelData OutpostLanding;
        /* 0X2A8 */ public float OutpostDockMaxApproachSpeed;
        /* 0X2AC */ public float OutpostDockOverspeedBrake;
        /* 0X2B0 */ public float OutpostDockGetToApproachForce;
        /* 0X2B4 */ public float OutpostDockGetToApproachBrakeForce;
        /* 0X2B8 */ public float OutpostDockApproachSpeedForce;
        /* 0X2BC */ public float OutpostDockApproachDistance;
        /* 0X2C0 */ public float OutpostDockAIGetToApproachForce;
        /* 0X2C4 */ public float OutpostDockAIGetToApproachBrakeForce;
        /* 0X2C8 */ public float OutpostDockAIApproachSpeedForce;
        /* 0X2CC */ public float OutpostDockMaxForce;
        /* 0X2D0 */ public float OutpostDockMinTipLength;
        /* 0X2D4 */ public float OutpostDockMaxTipLength;
        /* 0X2D8 */ public float OutpostDockApproachUpAmount;
        /* 0X2DC */ public float OutpostDockApproachRenderRadius;
        /* 0X2E0 */ public float OutpostDockApproachRenderFlickerOffset;
        /* 0X2E4 */ public float LandingTipAngle;
        /* 0X2E8 */ public float LandingLongTipAngle;
        /* 0X2EC */ public Vector2f SpaceBattleSpawnAngle;
        /* 0X2F4 */ public Vector2f SpaceBattleSpawnPitch;
        /* 0X2FC */ public Vector2f SpaceBattleSpawnOffset;
        /* 0X304 */ public Vector2f SpaceBattleSunHeightAngle;
        /* 0X30C */ public Vector2f SpaceBattleSunAroundAngle;
        [NMS(Size = 3)]
        /* 0X314 */ public Vector2f[] SpaceBattleSpawnRange;
        [NMS(Size = 3)]
        /* 0X32C */ public Vector2f[] SpaceBattlePirateRange;
        [NMS(Size = 3)]
        /* 0X340 */ public Vector2f[] SpaceBattleGuardsRange;
        /* 0X35C */ public float SpaceBattleGuardOffset;
        /* 0X360 */ public float SpaceBattleGuardUpOffset;
        /* 0X364 */ public float SpaceBattleInitialPirateUpOffset;
        /* 0X368 */ public float SpaceBattleInitialPirateOffset;
        /* 0X36C */ public float SpaceBattleObstructionRadius;
        /* 0X370 */ public float SpaceBattleFlybyTime;
        /* 0X374 */ public float SpaceBattleLevel;
        /* 0X378 */ public Vector2f ConeSpawnOffsetFactor;
        /* 0X380 */ public float ConeSpawnFlattenUp;
        /* 0X384 */ public float ConeSpawnFlattenDown;
        /* 0X388 */ public bool FreighterAlertLights;
        /* 0X38C */ public float FreighterAlertLightCapitalSize;
        [NMS(Size = 0x80)]
        /* 0x390 */ public string HangarFilename; // line 293 in NEXT exml
        /* 0X410 */ public float Unknown410;
        /* 0X414 */ public float Unknown414;
        /* 0X418 */ public float Unknown418;
        /* 0X41C */ public float Unknown41C;
        /* 0X420 */ public float Unknown420;
        /* 0X424 */ public float Unknown424;
        /* 0X428 */ public float Unknown428;
        /* 0X42C */ public float Unknown42C;
        /* 0X430 */ public float Unknown430;
        /* 0X434 */ public float Unknown434;
        /* 0X438 */ public float Unknown438;
        /* 0X43C */ public float Unknown43C;
        /* 0X440 */ public float Unknown440;
        /* 0X444 */ public float Unknown444;
        /* 0X448 */ public float Unknown448;
        /* 0X44C */ public float Unknown44C;
        /* 0X450 */ public float Unknown450;
        /* 0X454 */ public float Unknown454;
        /* 0X458 */ public int UnknownInt458;
        /* 0X45C */ public int UnknownInt45C;
        /* 0X460 */ public float Unknown460;
        /* 0X464 */ public float Unknown464;
        /* 0X468 */ public float Unknown468;
        /* 0X46C */ public float Unknown46C;
        /* 0X470 */ public float Unknown470;
        /* 0X474 */ public float Unknown474;
        /* 0X478 */ public float Unknown478;
        /* 0X47C */ public float Unknown47C;
        /* 0X480 */ public float Unknown480;
        /* 0X484 */ public float Unknown484;
        /* 0X488 */ public float Unknown488;
        /* 0X48C */ public float Unknown48C;
        /* 0X490 */ public float Unknown490;
        /* 0X494 */ public float Unknown494;
        /* 0X498 */ public float Unknown498;
        /* 0X49C */ public float Unknown49C;
        /* 0X4A0 */ public float Unknown4A0;
        /* 0X4A4 */ public float Unknown4A4;
        /* 0X4A8 */ public float Unknown4A8;
        /* 0X4AC */ public float Unknown4AC;
        /* 0X4B0 */ public float Unknown4B0;
        /* 0X4B4 */ public float Unknown4B4;
        /* 0X4B8 */ public float Unknown4B8;
        /* 0X4BC */ public float Unknown4BC;
        /* 0X4C0 */ public float Unknown4C0;
        /* 0X4C4 */ public float Unknown4C4;
        /* 0X4C8 */ public float Unknown4C8;
        /* 0X4CC */ public float Unknown4CC;
        /* 0X4D0 */ public float Unknown4D0;
        /* 0X4D4 */ public float Unknown4D4;
        /* 0X4D8 */ public float Unknown4D8;
        /* 0X4DC */ public float Unknown4DC;
        /* 0X4E0 */ public float Unknown4E0;
        /* 0X4E4 */ public float Unknown4E4;
        /* 0X4E8 */ public float Unknown4E8;
        /* 0X4EC */ public float Unknown4EC;
        /* 0X4F0 */ public float Unknown4F0;
        /* 0X4F4 */ public float Unknown4F4;
        /* 0X4F8 */ public float Unknown4F8;
        /* 0X4FC */ public float Unknown4FC;
        /* 0X500 */ public float Unknown500;
        /* 0X504 */ public float Unknown504;
        /* 0X508 */ public float Unknown508;
        /* 0X50C */ public float Unknown50C;
        /* 0X510 */ public float Unknown510;
        /* 0X514 */ public float Unknown514;
        /* 0X518 */ public float Unknown518;
        /* 0X51C */ public float Unknown51C;
        /* 0X520 */ public float Unknown520;
        /* 0X524 */ public float Unknown524;
        /* 0X528 */ public int UnknownInt528;
        /* 0X52C */ public float Unknown52C;
        /* 0x530 */ public GcShipAIAttackData Unknown530;
        /* 0X600 */ public float Unknown600;
        /* 0X604 */ public float Unknown604;
        /* 0X608 */ public float Unknown608;
        /* 0X60C */ public float Unknown60C;
        /* 0X610 */ public float Unknown610;
        /* 0X614 */ public float Unknown614;
        /* 0X618 */ public float Unknown618;
        /* 0X61C */ public float Unknown61C;
        /* 0X620 */ public int UnknownInt620;
        /* 0X624 */ public int UnknownInt624;
        /* 0X628 */ public float Unknown628;
        /* 0X62C */ public float Unknown62C;
        /* 0X630 */ public float Unknown630;
        /* 0X634 */ public float Unknown634;
        /* 0X638 */ public float Unknown638;
        /* 0X63C */ public float Unknown63C;
        /* 0X640 */ public float Unknown640;
        /* 0X644 */ public float Unknown644;
        /* 0X648 */ public float Unknown648;
        /* 0X64C */ public float Unknown64C;
        /* 0X650 */ public float Unknown650;
        /* 0X654 */ public float Unknown654;
        /* 0X658 */ public float Unknown658;
        /* 0X65C */ public bool Unknown65C;
        /* 0X660 */ public float Unknown660;
        /* 0X664 */ public float Unknown664;
        /* 0X668 */ public float Unknown668;
        /* 0X66C */ public bool Unknown66C;
        /* 0X670 */ public int UnknownInt670;
        /* 0X674 */ public float Unknown674;
        /* 0X678 */ public float Unknown678;
        /* 0X67C */ public float Unknown67C;
        /* 0X680 */ public float Unknown680;
        /* 0X684 */ public float Unknown684;
        /* 0X688 */ public float Unknown688;
        /* 0X68C */ public float Unknown68C;
        /* 0X690 */ public float Unknown690;
        /* 0X694 */ public float Unknown694;
        /* 0X698 */ public float Unknown698;
        /* 0X69C */ public float Unknown69C;
        /* 0X6A0 */ public int UnknownInt6A0;
        /* 0X6A4 */ public float Unknown6A4;
        /* 0X6A8 */ public float Unknown6A8;
        [NMS(Size = 0x100)]
        /* 0x6AC */ public string CrosshairTexture;
        /* 0X7AC */ public float Unknown7AC;
        /* 0X7B0 */ public float Unknown7B0;
        /* 0X7B4 */ public float Unknown7B4;
        /* 0X7B8 */ public float Unknown7B8;
        /* 0X7BC */ public float Unknown7BC;
        /* 0X7C0 */ public float Unknown7C0;
        /* 0X7C4 */ public float Unknown7C4;
        /* 0X7C8 */ public float Unknown7C8;
        /* 0X7CC */ public int UnknownInt7CC;
        /* 0X7D0 */ public float Unknown7D0;
        /* 0X7D4 */ public float Unknown7D4;
        /* 0X7D8 */ public int UnknownInt7D8;
        /* 0X7DC */ public float Unknown7DC;
        /* 0X7E0 */ public float Unknown7E0;
        /* 0X7E4 */ public float Unknown7E4;
        /* 0X7E8 */ public float Unknown7E8;
        /* 0X7EC */ public float Unknown7EC;
        /* 0X7F0 */ public float Unknown7F0;
        /* 0X7F4 */ public float Unknown7F4;
        /* 0X7F8 */ public float Unknown7F8;
        /* 0X7FC */ public float Unknown7FC;
        /* 0X800 */ public float Unknown800;
        /* 0X804 */ public float Unknown804;
        /* 0X808 */ public float Unknown808;
        /* 0X80C */ public float Unknown80C;
        /* 0X810 */ public float Unknown810;
        /* 0X814 */ public float Unknown814;
        /* 0X818 */ public float Unknown818;
        /* 0X81C */ public float Unknown81C;
        /* 0X820 */ public float Unknown820;
        /* 0X824 */ public float Unknown824;
        /* 0X828 */ public float Unknown828;
        /* 0X82C */ public float Unknown82C;
        /* 0X830 */ public bool Unknown830;
        /* 0X834 */ public float Unknown834;
        /* 0X838 */ public float Unknown838;
        /* 0X83C */ public int UnknownInt83C;
        /* 0X840 */ public float Unknown840;
        /* 0X844 */ public float Unknown844;
        /* 0X848 */ public float Unknown848;
        /* 0X84C */ public float Unknown84C;
        /* 0X850 */ public float Unknown850;
        /* 0X854 */ public float Unknown854;
        /* 0X858 */ public float Unknown858;
        /* 0X85C */ public float Unknown85C;
        /* 0X860 */ public float Unknown860;
        /* 0X864 */ public float Unknown864;
        /* 0X868 */ public float Unknown868;
        /* 0X86C */ public float Unknown86C;
        /* 0X870 */ public float Unknown870;
        /* 0X874 */ public float Unknown874;
        /* 0X878 */ public float Unknown878;
        /* 0X87C */ public float Unknown87C;
        /* 0X880 */ public int UnknownInt880;
        /* 0X884 */ public int UnknownInt884;
        /* 0X888 */ public float Unknown888;
        /* 0X88C */ public float Unknown88C;
        /* 0X890 */ public float Unknown890;
        /* 0X894 */ public float Unknown894;
        /* 0X898 */ public float Unknown898;
        /* 0X89C */ public float Unknown89C;
        /* 0X8A0 */ public float Unknown8A0;
        /* 0X8A4 */ public float Unknown8A4;
        /* 0X8A8 */ public float Unknown8A8;
        /* 0X8AC */ public float Unknown8AC;
        /* 0X8B0 */ public float Unknown8B0;
        /* 0X8B4 */ public float Unknown8B4;
        /* 0X8B8 */ public float Unknown8B8;
        /* 0X8BC */ public float Unknown8BC;
        /* 0X8C0 */ public float Unknown8C0;
        /* 0X8C4 */ public float Unknown8C4;
        /* 0X8C8 */ public float Unknown8C8;
        /* 0X8CC */ public float Unknown8CC;
        /* 0X8D0 */ public float Unknown8D0;
        /* 0X8D4 */ public int UnknownInt8D4;
        /* 0X8D8 */ public float Unknown8D8;
        /* 0X8DC */ public float Unknown8DC;
        /* 0X8E0 */ public float Unknown8E0;
        /* 0X8E4 */ public float Unknown8E4;
        /* 0X8E8 */ public float Unknown8E8;
        /* 0X8EC */ public float Unknown8EC;
        /* 0X8F0 */ public float Unknown8F0;
        /* 0X8F4 */ public float Unknown8F4;
        /* 0X8F8 */ public float Unknown8F8;
        /* 0X8FC */ public float Unknown8FC;
        /* 0X900 */ public float Unknown900;
        /* 0X904 */ public float Unknown904;
        /* 0X908 */ public float Unknown908;
        /* 0X90C */ public float Unknown90C;
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
        /* 0X940 */ public int UnknownInt940;
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
        /* 0X978 */ public int UnknownInt978;
        /* 0X97C */ public float Unknown97C;
        /* 0X980 */ public float Unknown980;
        /* 0X984 */ public float Unknown984;
        /* 0X988 */ public float Unknown988;
        /* 0x98C */ public float Unknown98C;
        /* 0x990 */ public GcSpaceshipTravelData Unknown990;
        /* 0X9E8 */ public float Unknown9E8;
        /* 0X9EC */ public float Unknown9EC;
        /* 0X9F0 */ public float Unknown9F0;
        /* 0X9F4 */ public float Unknown9F4;
        /* 0X9F8 */ public float Unknown9F8;
        /* 0X9FC */ public float Unknown9FC;
        /* 0XA00 */ public float UnknownA00;
        /* 0XA04 */ public float UnknownA04;
        /* 0XA08 */ public float UnknownA08;
        /* 0XA0C */ public float UnknownA0C;
        /* 0XA10 */ public float UnknownA10;
        /* 0XA14 */ public float UnknownA14;
        /* 0XA18 */ public float UnknownA18;
        /* 0XA1C */ public float UnknownA1C;
        /* 0XA20 */ public float UnknownA20;
        /* 0XA24 */ public float UnknownA24;
        /* 0XA28 */ public float UnknownA28;
        /* 0XA2C */ public float UnknownA2C;
        /* 0XA30 */ public float UnknownA30;
        /* 0XA34 */ public float UnknownA34;
        /* 0XA38 */ public float UnknownA38;
        /* 0XA3C */ public float UnknownA3C;
        /* 0XA40 */ public float UnknownA40;
        /* 0XA44 */ public float UnknownA44;
        /* 0XA48 */ public float UnknownA48;
        /* 0XA4C */ public float UnknownA4C;
        /* 0XA50 */ public float UnknownA50;
        /* 0XA54 */ public float UnknownA54;
        /* 0XA58 */ public float UnknownA58;
        /* 0XA5C */ public float UnknownA5C;
        /* 0XA60 */ public float UnknownA60;
        /* 0XA64 */ public float UnknownA64;
        /* 0XA68 */ public float UnknownA68;
        /* 0XA6C */ public float UnknownA6C;
        /* 0XA70 */ public float UnknownA70;
        /* 0XA74 */ public float UnknownA74;
        /* 0XA78 */ public float UnknownA78;
        /* 0XA7C */ public float UnknownA7C;
        /* 0XA80 */ public float UnknownA80;
        /* 0XA84 */ public float UnknownA84;
        /* 0XA88 */ public float UnknownA88;
        /* 0XA8C */ public float UnknownA8C;
        /* 0XA90 */ public float UnknownA90;
        /* 0XA94 */ public float UnknownA94;
        /* 0XA98 */ public float UnknownA98;
        /* 0XA9C */ public float UnknownA9C;
        /* 0XAA0 */ public float UnknownAA0;
        /* 0XAA4 */ public GcShipAIDeathData UnknownAA4;
        /* 0xAC0 */ public GcShipAIAttackData UnknownAC0;
        /* 0xB90 */ public GcShipAIAttackData UnknownB90;
        /* 0xC60 */ public GcShipAIPlanetPatrolData UnknownC60;
        [NMS(Size = 0x8, Ignore = true)]
        public byte[] EndPadding;
    }
}
