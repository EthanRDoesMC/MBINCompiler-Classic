using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(Size = 0x3910, GUID = 0x35C1342ED25FD595)]
    public class GcCreatureGlobals : NMSTemplate
    {
        [NMS(Size = 0xA)]
        /* 0x0000 */ public NMSString0x20[] Temperments;
        [NMS(Size = 0xA)]
        /* 0x0140 */ public NMSString0x20[] TempermentDescriptions;
        [NMS(Size = 0x4)]
        /* 0x0280 */ public NMSString0x20[] Diets;
        [NMS(Size = 0x4)]
        /* 0x0300 */ public NMSString0x20[] WaterDiets;
        [NMS(Size = 0x10)]
        /* 0x0380 */ public NMSString0x20[] DietMeat;
        [NMS(Size = 0x10)]
        /* 0x0580 */ public NMSString0x20[] DietVeg;
        [NMS(Size = 0x4)]
        /* 0x0780 */ public NMSString0x20[] DietDescriptions;
        [NMS(Size = 0x4)]
        /* 0x0800 */ public NMSString0x20[] WaterDietDescriptions;
        [NMS(Size = 0x10)]
        /* 0x0880 */ public NMSString0x20[] BiomeDescriptions;
        [NMS(Size = 0x10)]
        /* 0x0A80 */ public NMSString0x20[] BiomeWaterDescriptions;
        [NMS(Size = 0x10)]
        /* 0x0C80 */ public NMSString0x20[] BiomeAirDescriptions;
        [NMS(Size = 0x1B)]
        /* 0x0E80 */ public NMSString0x20[] WeirdBiomeDescriptions;
        /* 0x11E0 */ public bool OverrideIKParams;
                                        
                                               
        /* 0x11E4 */ public float BodyMassWeight;
        /* 0x11E8 */ public float Omega;
        /* 0x11EC */ public float OmegaDropOff;
        /* 0x11F0 */ public float MovementDamp;
        /* 0x11F4 */ public bool IsHurtingCreaturesACrime;
        /* 0x11F5 */ public bool EnableFlyingSnakeTails;
        /* 0x11F6 */ public bool EnableNewStuff;
        /* 0x11F7 */ public bool InstantCreatureRide;
        /* 0x11F8 */ public bool EnableVRCreatureRide;
        /* 0x11F9 */ public bool EnableMPCreatureRide;
                                        
                                               
        /* 0x11FC */ public float RidingReplicationRangeMultiplier;
        /* 0x1200 */ public float RidingRollAdjustMaxAngle;
        /* 0x1204 */ public float RidingRollMaxAngleAt;
        /* 0x1208 */ public float RidingFirstPersonOffsetFwd;
        /* 0x120C */ public float RidingFirstPersonOffsetUp;
        /* 0x1210 */ public float CreatureScaleMangle;
        /* 0x1214 */ public bool CreatureRideDirectControl;
        /* 0x1215 */ public bool StaticCreatureRide;
                                        
                                               
        /* 0x1218 */ public float RideSpeedSlow;
        /* 0x121C */ public float RideSpeedFast;
        /* 0x1220 */ public float RideSpeedChangeTime;
        /* 0x1224 */ public float RiderLeanTime;
        /* 0x1228 */ public float PostRideMoveTime;
        /* 0x122C */ public float RideIdleTime;
        /* 0x1230 */ public float MinRideSize;
        /* 0x1234 */ public float MaxCreatureSize;
        /* 0x1238 */ public float MaxRideLeanCounterRotate;
        /* 0x123C */ public float PetMinSummonDistance;
        /* 0x1240 */ public float PetMaxSummonDistance;
        /* 0x1244 */ public float PetSummonRotation;
        /* 0x1248 */ public float PlayerDamageTransferScale;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x124C */ public byte[] Padding124C;
        /* 0x1250 */ public GcSeed CreatureSeed;
        [NMS(Size = 0x20)]
        /* 0x1260 */ public string CreatureFilter;
        /* 0x1280 */ public int MaxEcosystemCreaturesNormal;
        /* 0x1284 */ public int MaxEcosystemCreaturesLow;
        /* 0x1288 */ public float LowPerfFlockReduce;
        /* 0x128C */ public bool UncapSpawningforVideo;
        /* 0x128D */ public bool AllowSpawningOnscreen;
                                        
                                               
        /* 0x1290 */ public float ResourceSpawnTime;
        /* 0x1294 */ public float TurnInPlaceIdleTime;
        /* 0x1298 */ public float TurnInPlaceMaxAngle;
        /* 0x129C */ public float TurnInPlaceMinTime;
        /* 0x12A0 */ public float TurnInPlaceMaxSpeed;
        /* 0x12A4 */ public float SceneTerrainSpawnMinDistance;
        /* 0x12A8 */ public float CreatureMinAlignSpeed;
        /* 0x12AC */ public float PatrolMinDist;
        /* 0x12B0 */ public float PatrolMaxDist;
        /* 0x12B4 */ public float PatrolHeightOffset;
        /* 0x12B8 */ public float PatrolGradientFactor;
        /* 0x12BC */ public float CreatureWaryTime;
        /* 0x12C0 */ public float CreatureMinRunTime;
        /* 0x12C4 */ public float CreatureHearingRange;
        /* 0x12C8 */ public float CreatureSightRange;
        /* 0x12CC */ public float CreatureMoveIdle;
        /* 0x12D0 */ public float CreatureTurnMin;
        /* 0x12D4 */ public float CreatureTurnMax;
        /* 0x12D8 */ public float CreatureBrakeForce;
        /* 0x12DC */ public float CreatureMinAnimMoveSpeed;
        /* 0x12E0 */ public float CreatureLookBeforeGoingTime;
        /* 0x12E4 */ public float CreatureLookBeforeFleeingTime;
        /* 0x12E8 */ public float CreatureLookBeforeFleeingIfShotTime;
        /* 0x12EC */ public float CreatureLookScaryThingTime;
        /* 0x12F0 */ public float CreatureLookPlayerForceLookTime;
        /* 0x12F4 */ public float FootPlantError;
        /* 0x12F8 */ public float RecoverHealthTime;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x12FC */ public byte[] Padding12FC;
        /* 0x1300 */ public GcCameraShakeData PainShake;
        /* 0x13C0 */ public float PatrolSwitchMinTime;
        /* 0x13C4 */ public float ExtraFollowStrength;
        /* 0x13C8 */ public float ExtraFollowFreq1;
        /* 0x13CC */ public float ExtraFollowFreq2;
        /* 0x13D0 */ public float SandWormChangeDirectionTime;
        /* 0x13D4 */ public float SandWormSteerAdjustTime;
        /* 0x13D8 */ public float SandWormMaxSteer;
        /* 0x13DC */ public float SandWormMaxHeightAdjust;
        /* 0x13E0 */ public float SandWormJumpHeight;
        /* 0x13E4 */ public float SandWormJumpTime;
        /* 0x13E8 */ public float SandWormSubmergeDepth;
        /* 0x13EC */ public float SandWormSubmergeTime;
        /* 0x13F0 */ public float SandWormSurfaceTime;
        /* 0x13F4 */ public int SandWormMaxJumps;
        /* 0x13F8 */ public float SandWormDespawnDist;
        /* 0x13FC */ public float SandWormSpawnTimer;
        /* 0x1400 */ public float SandWormSpawnChanceMin;
        /* 0x1404 */ public float SandWormSpawnChanceMax;
        /* 0x1408 */ public float ShieldFadeTime;
        /* 0x140C */ public float SharkAlongPathSpeed;
        /* 0x1410 */ public float SwarmBrakingForce;
        /* 0x1414 */ public float SharkToPathYDamp;
        /* 0x1418 */ public float SharkAttackSpeed;
        /* 0x141C */ public float SharkAttackAccel;
        /* 0x1420 */ public float SharkPatrolSpeed;
        /* 0x1424 */ public float SharkPatrolRadius;
        /* 0x1428 */ public float SharkPatrolEnd;
        /* 0x142C */ public float SharkGetToPathSpeed;
        /* 0x1430 */ public float SharkAlignSpeed;
        /* 0x1434 */ public float FishBobFrequency;
        /* 0x1438 */ public float FishBobAmplitude;
        /* 0x143C */ public float FreighterJellyBobFrequency;
        /* 0x1440 */ public float FreighterJellyBobAmplitude;
        /* 0x1444 */ public float InfluenceRadius;
        /* 0x1448 */ public float InfluenceForce;
        /* 0x144C */ public float InfluenceThreshold;
        /* 0x1450 */ public float InfluenceDeflect;
        /* 0x1454 */ public float TargetSearchTimeout;
        /* 0x1458 */ public float AttractMinDistance;
        /* 0x145C */ public float SwarmMoveYFactor;
        /* 0x1460 */ public float DroneExplodeRadius;
        /* 0x1464 */ public float WeaponRepelRange;
        /* 0x1468 */ public float WeaponRepelAmount;
        /* 0x146C */ public float VelocityAlignStrength;
        /* 0x1470 */ public float VelocityAlignSpeed;
        /* 0x1474 */ public float HeightLookAhead;
        /* 0x1478 */ public float MaxHeightTime;
        /* 0x147C */ public float PlayerBirdDistance;
        /* 0x1480 */ public float FishSpeedMin;
        /* 0x1484 */ public float FishSpeedMax;
        /* 0x1488 */ public float FishSwimMaxAcceleration;
        /* 0x148C */ public float AlertDistance;
        /* 0x1490 */ public float RepelRange;
        /* 0x1494 */ public float RepelAmount;
        /* 0x1498 */ public float FishTurn;
        /* 0x149C */ public float TargetReachedDistance;
        /* 0x14A0 */ public float MaxSpeed;
        /* 0x14A4 */ public float MaxForce;
        /* 0x14A8 */ public float MaxTorque;
        /* 0x14AC */ public float MinWaterSpawnDepth;
        /* 0x14B0 */ public float WaterSpawnOffset;
        /* 0x14B4 */ public float SpawnDistanceModifierForUnderwater;
        /* 0x14B8 */ public float FootDustGroundTintStrength;
        /* 0x14BC */ public float StickToGroundSpeed;
        /* 0x14C0 */ public float StickToGroundCastBegin;
        /* 0x14C4 */ public float StickToGroundCastEnd;
        /* 0x14C8 */ public GcFlyingSnakeData FlyingSnakeData;
        [NMS(Size = 0x4)]
        /* 0x1508 */ public GcCreatureAlertData[] AlertTable;
        /* 0x1568 */ public bool ShowScale;
                                        
                                               
        /* 0x156C */ public float CreatureMedMinSize;
        /* 0x1570 */ public float CreatureLargeMinSize;
        /* 0x1574 */ public float CreatureHugeMinSize;
        /* 0x1578 */ public float CreatureRidingMedMinSize;
        /* 0x157C */ public float CreatureRidingLargeMinSize;
        /* 0x1580 */ public float CreatureRidingHugeMinSize;
        /* 0x1584 */ public float CreatureBlobRidingMedMinSize;
        /* 0x1588 */ public float CreatureBlobRidingLargeMinSize;
        /* 0x158C */ public float CreatureBlobRidingHugeMinSize;
        /* 0x1590 */ public int CreatureSmallHealth;
        /* 0x1594 */ public int CreatureMedHealth;
        /* 0x1598 */ public int CreatureLargeHealth;
        /* 0x159C */ public int CreatureHugeHealth;
        [NMS(Size = 0x10)]
        /* 0x15A0 */ public string CreatureLargeWalkShake;
        /* 0x15B0 */ public float CreatureLargeWalkMaxShakeDist;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x15B4 */ public byte[] Padding15B4;
        [NMS(Size = 0x10)]
        /* 0x15B8 */ public string CreatureLargeRunShake;
        /* 0x15C8 */ public float CreatureLargeRunMaxShakeDist;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x15CC */ public byte[] Padding15CC;
        [NMS(Size = 0x10)]
        /* 0x15D0 */ public string CreatureHugeWalkShake;
        /* 0x15E0 */ public float CreatureHugeWalkMaxShakeDist;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x15E4 */ public byte[] Padding15E4;
        [NMS(Size = 0x10)]
        /* 0x15E8 */ public string CreatureHugeRunShake;
        /* 0x15F8 */ public float CreatureHugeRunMaxShakeDist;
        /* 0x15FC */ public float SmallCreaturePerceptionDistance;
        /* 0x1600 */ public float largeCreaturePerceptionDistance;
        /* 0x1604 */ public float SmallCreatureFleePlayerDistance;
        /* 0x1608 */ public float LargeCreatureFleePlayerDistance;
        /* 0x160C */ public float SmallCreatureAvoidPlayerDistance;
        /* 0x1610 */ public float LargeCreatureAvoidPlayerDistance;
        /* 0x1614 */ public float PredatorPerceptionDistance;
        /* 0x1618 */ public float PredatorFishPerceptionDistance;
        /* 0x161C */ public float PassiveFleePlayerDistance;
        /* 0x1620 */ public float AdultBabyKilledNoticeDistance;
        /* 0x1624 */ public float PercentagePlayerPredators;
        /* 0x1628 */ public int PredatorSmallHealth;
        /* 0x162C */ public int PredatorMedHealth;
        /* 0x1630 */ public int PredatorLargeHealth;
        /* 0x1634 */ public int PredatorHugeHealth;
        /* 0x1638 */ public float PlayerPredatorHealthModifier;
        /* 0x163C */ public float PredatorApproachTime;
        /* 0x1640 */ public float PredatorNoticePauseTime;
        /* 0x1644 */ public float PredatorStealthDist;
        /* 0x1648 */ public float PredatorChargeDist;
        /* 0x164C */ public float PredatorChargeDistScale;
        /* 0x1650 */ public float FishPredatorChargeDist;
        /* 0x1654 */ public float FishPredatorChargeDistScale;
        /* 0x1658 */ public float PredatorBoredomDistance;
        /* 0x165C */ public float PlayerPredatorBoredomDistance;
        /* 0x1660 */ public float PredatorRegainInterestTime;
        /* 0x1664 */ public float PlayerPredatorRegainInterestTime;
        /* 0x1668 */ public float PredatorRunAwayDist;
        /* 0x166C */ public float PredatorRoarProbAfterHit;
        /* 0x1670 */ public float PredatorRoarProbAfterMiss;
        /* 0x1674 */ public float PredatorRunAwayHealthPercent;
        /* 0x1678 */ public float PredatorEnergyRecoverRate;
        /* 0x167C */ public float PredatorEnergyUseChasing;
        /* 0x1680 */ public bool AggressiveSharks;
                                        
                                               
        /* 0x1684 */ public float DelayAfterRespawnBeforeAttackable;
        /* 0x1688 */ public float IndoorTurnTime;
        /* 0x168C */ public float IndoorObstacleAvoidStrength;
        /* 0x1690 */ public float IndoorSteeringRayLength;
        /* 0x1694 */ public float IndoorSteeringRaySphereSize;
        /* 0x1698 */ public float IndoorSteeringRaySpread;
        /* 0x169C */ public float FreighterSpawnDist;
        /* 0x16A0 */ public float FreighterDespawnDist;
        /* 0x16A4 */ public bool ScuttlersCanAttack;
                                        
                                               
        /* 0x16A8 */ public int ScuttlerHealth;
        /* 0x16AC */ public float ScuttlerInitialNoAttackTime;
        /* 0x16B0 */ public float ScuttlerMoveTimeMin;
        /* 0x16B4 */ public float ScuttlerMoveTimeMax;
        /* 0x16B8 */ public float ScuttlerIdleTimeMin;
        /* 0x16BC */ public float ScuttlerIdleTimeMax;
        /* 0x16C0 */ public float ScuttlerZigZagTimeMin;
        /* 0x16C4 */ public float ScuttlerZigZagTimeMax;
        /* 0x16C8 */ public float ScuttlerZigZagStrength;
        /* 0x16CC */ public float ScuttlerSpitDelay;
        /* 0x16D0 */ public float ScuttlerSpitChargeTime;
        /* 0x16D4 */ public float MiniDroneEnergyRecoverRate;
        /* 0x16D8 */ public float MiniDroneEnergyUsePerShot;
        /* 0x16DC */ public float MiniDroneShotDelay;
        /* 0x16E0 */ public float MiniDroneShotMaxAngle;
        /* 0x16E4 */ public bool FiendsCanAttack;
        /* 0x16E5 */ public bool FiendOnscreenMarkers;
                                        
                                               
        /* 0x16E8 */ public int FiendHealth;
        /* 0x16EC */ public float FiendPerceptionDistance;
        /* 0x16F0 */ public float FiendSpawnDistance;
        /* 0x16F4 */ public float FiendDespawnDistance;
        /* 0x16F8 */ public float FiendReplicateStartDistance;
        /* 0x16FC */ public float FiendReplicateEndDistance;
        /* 0x1700 */ public float FiendAggroTime;
        /* 0x1704 */ public int FiendMaxEngaged;
        /* 0x1708 */ public int FiendMaxAttackers;
        /* 0x170C */ public float DelayBetweenPounceAttacks;
        /* 0x1710 */ public float DelayBetweenSpitAttacks;
        /* 0x1714 */ public float FiendMaxVerticalForPounce;
        /* 0x1718 */ public float FiendZigZagSpeed;
        /* 0x171C */ public float FiendZigZagStrength;
        /* 0x1720 */ public int FiendEggsToUnlockSpit;
        /* 0x1724 */ public int MaxFiendsToSpawn;
        /* 0x1728 */ public float FiendMinSpawnTime;
        /* 0x172C */ public float FiendMaxSpawnTime;
        /* 0x1730 */ public float FiendAggroIncreaseDamageEgg;
        /* 0x1734 */ public float FiendAggroIncreaseDestroyEgg;
        /* 0x1738 */ public float FiendAggroDecreasePerSpawn;
        /* 0x173C */ public float FiendCritAreaSize;
        /* 0x1740 */ public float FiendDistToConsiderTargetSwtich;
        /* 0x1744 */ public float FiendDistReduceForBeingShot;
        /* 0x1748 */ public float FiendBeingShotMemoryTime;
        /* 0x174C */ public int MaxFishFiends;
        /* 0x1750 */ public int FishFiendSmallHealth;
        /* 0x1754 */ public int FishFiendBigHealth;
        /* 0x1758 */ public float FishFiendSmallBoostStrength;
        /* 0x175C */ public float FishFiendSmallBoostTime;
        /* 0x1760 */ public float FishFiendSmallScale;
        /* 0x1764 */ public float FishFiendBigBoostStrength;
        /* 0x1768 */ public float FishFiendBigBoostTime;
        /* 0x176C */ public float FishFiendBigScale;
        /* 0x1770 */ public float RoutineSpeed;
        /* 0x1774 */ public float RoutineOffset;
        /* 0x1778 */ public float RagdollTau;
        /* 0x177C */ public float RagdollDamping;
        /* 0x1780 */ public float RagdollConeLimit;
        /* 0x1784 */ public float RagdollTwistLimit;
        /* 0x1788 */ public float RagdollMotorFadeStart;
        /* 0x178C */ public float RagdollMotorFadeEnd;
        /* 0x1790 */ public int MaxRagdollsBeforeDespawnOffscreen;
        /* 0x1794 */ public int MaxRagdollsBeforeDespawnOnscreen;
        /* 0x1798 */ public float RidingTurnRadiusMultiplier;
        /* 0x179C */ public float TurnRadiusMultiplier;
        /* 0x17A0 */ public float PredatorTurnRadiusMultiplier;
        /* 0x17A4 */ public float MaxTurnRadius;
        /* 0x17A8 */ public float TurnSlowAreaCos;
        /* 0x17AC */ public float BadTurnPercent;
        /* 0x17B0 */ public float BadTurnWeight;
        /* 0x17B4 */ public float MinScaleForNavMap;
        /* 0x17B8 */ public float ImpassabilityBrakeTime;
        /* 0x17BC */ public float ImpassabilityUnbrakeTime;
        /* 0x17C0 */ public float ImpassabilityTurnSpeedMultiplier;
        /* 0x17C4 */ public float NavMapLookAhead;
        /* 0x17C8 */ public float VelocityAlignYFactorMin;
        /* 0x17CC */ public float VelocityAlignYFactorMax;
        /* 0x17D0 */ public float BrakingForce;
        /* 0x17D4 */ public float BrakingForceY;
        /* 0x17D8 */ public float FlowFieldWeight;
        /* 0x17DC */ public float FollowWeight;
        /* 0x17E0 */ public float RidingSteerWeight;
        /* 0x17E4 */ public float AvoidCreaturesWeight;
        /* 0x17E8 */ public float AvoidImpassableWeight;
        /* 0x17EC */ public float BaseAndTerrainModImpassableStrength;
        /* 0x17F0 */ public float FollowLeaderAlignWeight;
        /* 0x17F4 */ public float FollowLeaderCohereWeight;
        /* 0x17F8 */ public float SoftenAvoidanceRadiusMod;
        /* 0x17FC */ public float FreighterJellySwimSpeed;
        /* 0x1800 */ public float DefaultSwimSpeed;
        /* 0x1804 */ public float FastSwimSpeed;
        /* 0x1808 */ public float DefaultWalkMoveSpeed;
        /* 0x180C */ public float DefaultTrotMoveSpeed;
        /* 0x1810 */ public float DefaultRunMoveSpeed;
        /* 0x1814 */ public float PredatorWalkMoveSpeed;
        /* 0x1818 */ public float PredatorTrotMoveSpeed;
        /* 0x181C */ public float PredatorRunMoveSpeed;
        /* 0x1820 */ public float HeightDiffPenalty;
        /* 0x1824 */ public float EdgeClosenessPenalty;
        /* 0x1828 */ public float PelvisIkStrength;
        /* 0x182C */ public float SteeringUpdateRate;
        /* 0x1830 */ public float PathOverestimate;
        /* 0x1834 */ public float FishWaterSurfaceAnticipate;
        /* 0x1838 */ public float FishWaterSurfaceAvoidStrength;
        /* 0x183C */ public float FishDesiredDepth;
        /* 0x1840 */ public float FishMinHeightAboveSeaBed;
        /* 0x1844 */ public float FishSeaBedAvoidStrength;
        /* 0x1848 */ public float FishObstacleAvoidStrength;
        /* 0x184C */ public float FishPlayerAttractionFrontDist;
        /* 0x1850 */ public float FishPlayerAttractionAhead;
        /* 0x1854 */ public float FishPlayerAttractionMinDist;
        /* 0x1858 */ public float FishPlayerAttractionMaxDist;
        /* 0x185C */ public float FishPlayerAttractionStrength;
        /* 0x1860 */ public float AttackPlayerDistance;
        /* 0x1864 */ public float SpawnCameraAngleCos;
        /* 0x1868 */ public float SpawnMinDistPercentage;
        /* 0x186C */ public float SpawnOnscreenDist;
        /* 0x1870 */ public float FadeScaleMultiplier;
        /* 0x1874 */ public float FadeScalePower;
        /* 0x1878 */ public float FadeDistance;
        /* 0x187C */ public float SpawnDistAtMinSize;
        /* 0x1880 */ public float SpawnDistAtMaxSize;
        /* 0x1884 */ public float DespawnDistFactor;
        /* 0x1888 */ public float MinFade;
        /* 0x188C */ public float MaxFade;
        /* 0x1890 */ public bool ProcessPendingSpawnRequests;
                                        
                                               
        /* 0x1894 */ public float SpawnsAvoidBaseMultiplier;
        /* 0x1898 */ public int PerceptionUpdateRate;
        /* 0x189C */ public bool AllowSleeping;
        /* 0x189D */ public bool DebugDrawTrails;
                                        
                                               
        /* 0x18A0 */ public float TrailHalfLife;
        /* 0x18A4 */ public bool EnableTrailIk;
                                        
                                               
        /* 0x18A8 */ public float DetailAnimBlendInTime;
        /* 0x18AC */ public float DetailAnimBlendOutTime;
        /* 0x18B0 */ public float DetailAnimMinPauseTime;
        /* 0x18B4 */ public float DetailAnimMaxPauseTime;
        /* 0x18B8 */ public bool DetailAnimPlayWhileWalking;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x18B9 */ public byte[] Padding18B9;
        [NMS(Size = 0x10)]
        /* 0x18C0 */ public string CreatureDeathEffectSmall;
        [NMS(Size = 0x10)]
        /* 0x18D0 */ public string CreatureDeathEffectMedium;
        [NMS(Size = 0x10)]
        /* 0x18E0 */ public string CreatureDeathEffectBig;
        [NMS(Size = 0x10)]
        /* 0x18F0 */ public string FishDeathEffect;
        /* 0x1900 */ public float FootParticleTime;
        /* 0x1904 */ public bool PiedPiper;
                                        
                                               
        /* 0x1908 */ public float FollowPlayerDistance;
        /* 0x190C */ public float FollowRunPlayerDistance;
        /* 0x1910 */ public float FollowRange;
        /* 0x1914 */ public float SearchItemDistance;
        /* 0x1918 */ public float SearchItemFrequency;
        /* 0x191C */ public float SearchItemGiveUpDistance;
        /* 0x1920 */ public float SearchItemGiveUpTime;
        /* 0x1924 */ public float SearchItemNotifyTime;
        /* 0x1928 */ public float SearchSpawnRandomItemProbability;
        /* 0x192C */ public float MiningRandomProbability;
        /* 0x1930 */ public bool DebugSearch;
                                        
                                               
        /* 0x1934 */ public int FriendlyCreatureLimit;
        /* 0x1938 */ public int FeedingTaskAmount;
        /* 0x193C */ public float FeedingFollowTime;
        /* 0x1940 */ public float FeedingNoticeTime;
        /* 0x1944 */ public float FeedingNoticeDistance;
        /* 0x1948 */ public float AttractedMinAvoidCreaturesStrength;
        /* 0x194C */ public float AttractedMinAvoidCreaturesDist;
        /* 0x1950 */ public float AttractedMaxAvoidCreaturesStrength;
        /* 0x1954 */ public float AttractedMaxAvoidCreaturesDist;
        /* 0x1958 */ public float AnimChangeCoolDown;
        /* 0x195C */ public float GroupRunProbability;
        /* 0x1960 */ public float GroupBabyRunProbability;
        /* 0x1964 */ public float GroupRunStormProbability;
        /* 0x1968 */ public float GroupLookAtProbability;
        /* 0x196C */ public float GroupLookAtDurationMin;
        /* 0x1970 */ public float GroupLookAtDurationMax;
        /* 0x1974 */ public float GroupRunDurationMin;
        /* 0x1978 */ public float GroupRunDurationMax;
        /* 0x197C */ public float GroupFemaleProportion;
        /* 0x1980 */ public float GroupBabyProportion;
        /* 0x1984 */ public float GroupBabyScale;
        /* 0x1988 */ public float GroupBabyHealthMultiplier;
        /* 0x198C */ public float MaxBirdsProportion;
        /* 0x1990 */ public float HerdGroupSizeMultiplier;
        /* 0x1994 */ public bool DrawRoutineFollowDebug;
        /* 0x1995 */ public bool DrawRoutineInfo;
                                        
                                               
        /* 0x1998 */ public float AdultCorrelationValue;
        /* 0x199C */ public float GrassPushRadius;
        /* 0x19A0 */ public float GrassPushStrength;
        /* 0x19A4 */ public float GrassPushMaxSize;
        /* 0x19A8 */ public bool DrawGrassPushRadius;
                                        
                                               
        /* 0x19AC */ public float CreatureIndoorSpeedMultiplier;
        /* 0x19B0 */ public float CreatureSpeedMultiplier;
        /* 0x19B4 */ public float PredatorSpeedMultiplier;
        [NMS(Size = 0x10)]
        /* 0x19B8 */ public string DefaultKillingSubstance;
        [NMS(Size = 0x10)]
        /* 0x19C8 */ public string AlienShipQuestKillingSubstance;
        [NMS(Size = 0x10)]
        /* 0x19D8 */ public string AlienShipQuestCreatureWeapon;
        [NMS(Size = 0x3)]
        /* 0x19E8 */ public NMSString0x10[] KillingSubstances;
        /* 0x1A18 */ public int CreatureKillRewardAmountSmall;
        /* 0x1A1C */ public int CreatureKillRewardAmountMed;
        /* 0x1A20 */ public int CreatureKillRewardAmountLarge;
        /* 0x1A24 */ public int CreatureKillRewardAmountHuge;
        // This enum is the GcCreatureTypes.CreatureTypeEnum with a few entries removed.
        // Wbertro: not sure it is relevant here?
        public enum CreatureTypesEnum  { Fish, Antelope, Bird, Butterfly, FlyingSnake, FlyingLizard, Diplo, Triceratops, Rodent, Cow, Cat, Strider,
            Trex, Shark, TwoLegAntelope, SixLegCat, SixLegCow, Grunt, Blob, Spider, FloatSpider, SwimCow, SwimRodent, Jellyfish, Crab, RockCreature };
        [NMS(Size = 0x25)]
        /* 0x1A28 */ public GcCreatureSubstanceList[] KillingProducts;
        [NMS(Size = 0x1D)]
        /* 0x1EC8 */ public GcCreatureHarvestSubstanceList[] HarvestingProducts;
        /* 0x31D0 */ public int CreatureHarvestAmountSmall;
        /* 0x31D4 */ public int CreatureHarvestAmountMed;
        /* 0x31D8 */ public int CreatureHarvestAmountLarge;
        /* 0x31DC */ public int CreatureHarvestAmountHuge;
        /* 0x31E0 */ public float HarvestCooldownMin;
        /* 0x31E4 */ public float HarvestCooldownMax;
        [NMS(Size = 0x10)]
        /* 0x31E8 */ public string BasicFeedingProduct;
        [NMS(Size = 0x10)]
        /* 0x31F8 */ public string RobotFeedingProduct;
        [NMS(Size = 0x4)]
        /* 0x3208 */ public GcCreatureFoodList[] HerbivoreFeedingProducts;
        [NMS(Size = 0x4)]
        /* 0x3488 */ public GcCreatureFoodList[] CarnivoreFeedingProducts;
        /* 0x3708 */ public GcWeirdCreatureRewardList WeirdKillingRewards;
        [NMS(Size = 0x3)]
        /* 0x38B8 */ public NMSString0x10[] LootItems;
        /* 0x38E8 */ public float RockTransformGlobalChance;
        [NMS(Size = 0x4)]
        /* 0x38EC */ public float[] RockTransformChanceModifiers;
        /* 0x38FC */ public float AngryRockProportionNormal;
        /* 0x3900 */ public float AngryRockProportionSurvival;
        /* 0x3904 */ public int PauseBetweenCreatureSpawnRequests;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x3908 */ public byte[] EndPadding;
    }
}
