namespace libMBIN.Models.Structs
{
    public class GcSolarGenerationGlobals : NMSTemplate
    {
        /* 0x0 */ public bool MassiveSolarSystems;
        [NMS(Size = 0xF, Ignore = true)]
        /* 0x1 */ public byte[] Padding1;
        /* 0x10 */ public Vector4f SolarSystemSize;
        /* 0x20 */ public float SolarSystemMaximumRadius;               // if not massive
        /* 0x24 */ public float SolarSystemMaximumRadiusMassive;        // used instead of +0x20 if +0x0 is True
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x28 */ public byte[] Padding28;
        /* 0x30 */ public bool UseSingleRacePerSystem;
        /* 0x34 */ public Vector2f PerPlanetGenerationAngleChangeDegreesRange;
        /* 0x3C */ public Vector2f PerPlanetGenerationElevationChangeDegreesRange;
        /* 0x44 */ public Vector2f SpawnPointStationToPlanetInterpRange;
        /* 0x4C */ public float ExtremeWeatherChance;
        /* 0x50 */ public float StationSpawnAvoidRadius;
        /* 0x54 */ public int LocatorScatterMinCount;
        /* 0x58 */ public int LocatorScatterMaxCount;
        /* 0x5C */ public float LocatorScatterMaxDistanceFromPlanet;
        /* 0x60 */ public int LocatorScatterChanceOfCapitalShips;
        /* 0x64 */ public int LocatorScatterChanceOfPirates;
        /* 0x68 */ public float DirectorLocatorBusyDistance;
        /* 0x6C */ public float DirectorLocatorBusyAngle;
        /* 0x70 */ public float PlanetInvalidAsteroidZone; // minimum distance from planet
        /* 0x74 */ public bool AsteroidsEnabled;
        /* 0x75 */ public bool AsteroidsCheckNoise;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0x76 */ public byte[] Padding76;
        /* 0x78 */ public float AsteroidNoiseScale; //AsteroidNoiseDistribution;
        /* 0x7C */ public float AsteroidDetailNoiseScale; //AsteroidSpreadDistribution;
        /* 0x80 */ public int AsteroidNoiseOctaves;
        /* 0x84 */ public float AsteroidNoiseMinCutoff;
        /* 0x88 */ public float AsteroidNoiseMaxCutoff;
        /* 0x8C */ public float AsteroidRotateMin; //AsteroidRotationXSpeed;
        /* 0x90 */ public float AsteroidRotateMax; //AsteroidRotationYSpeed;
        /* 0x94 */ public Vector2f AsteroidScaleVariance;
        /* 0x9C */ public float AsteroidFadeTime;
        /* 0xA0 */ public Vector2f AsteroidNoiseRange;
        /* 0xA8 */ public Vector2f LargeAsteroidNoiseRange;
        /* 0xB0 */ public Vector2f RareAsteroidNoiseRangeSomeRares;
        /* 0xB8 */ public float RareAsteroidNoiseRangeLotsOfRares;
        /* 0xC0 */ public float AsteroidNoRaresNoisePoint;
        /* 0xC4 */ public float AsteroidSomeRaresNoisePoint;
        /* 0xC8 */ public float AsteroidLotsOfRaresNoisePoint;
        /* 0xCC */ public float AsteroidSomeRaresOdds;
        /* 0xD0 */ public float AsteroidLotsOfRaresOdds;
        /* 0xD4 */ public float AsteroidFadeRangeMin; //SmallAsteroidFadeIn;
        /* 0xD8 */ public float AsteroidFadeRangeMax; //SmallAsteroidZoomIn;
        /* 0xDC */ public float AsteroidSpacing;
        /* 0xE0 */ public float RareAsteroidScale;
        /* 0xE4 */ public int RareAsteroidMinResources;
        /* 0xE8 */ public int RareAsteroidMaxResources;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0xEC */ public byte[] PaddingEC;

        [NMS(Size = 0x10)]
        /* 0xF0 */ public string RareAsteroidResource;            // seems to be ignored???

        /* 0x100 */ public int RareAsteroidHealth;                           // only checked on system warp
        /* 0x104 */ public float CommonAsteroidScale;
        /* 0x108 */ public int CommonAsteroidMinResources;
        /* 0x10C */ public int CommonAsteroidMaxResources;

        [NMS(Size = 0x10)]
        /* 0x110 */ public string CommonAsteroidResourceFuel;
        [NMS(Size = 0x10)]
        /* 0x120 */ public string CommonAsteroidResourceMain

        /* 0x130 */ public float CommonAsteroidResourceFuelOdds;
        /* 0x134 */ public int CommonAsteroidHealth;
        /* 0x138 */ public float LargeAsteroidSpacing;
        /* 0x13C */ public float LargeAsteroidFadeTime;
        /* 0x140 */ public float LargeAsteroidFadeRangeMin;
        /* 0x144 */ public float LargeAsteroidFadeRangeMax;
        /* 0x148 */ public float LargeAsteroidMoveFadeTime;
        /* 0x14C */ public int AsteroidMaxNumGenerates;
        /* 0x150 */ public float AsteroidSpaceStationAvoidRadius;
        /* 0x154 */ public float AsteroidAnomalyAvoidRadius;
        /* 0x158 */ public float AsteroidWarpInAreaAvoidRadius;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x15C */ public byte[] Padding15C;
        /* 0x160 */ public float Unknown160; // = 0.1 -- are these probabilities?
        /* 0x164 */ public float Unknown164; // = 0.2 -- next has abandoned/empty system probabilities here
        /* 0x168 */ public float Unknown168; // = 0.3 -- these might just need to be tested manually
        /* 0x16C */ public float Unknown16C; // = 0   -- or they just might be lost to time forever :(
        /* 0x170 */ public float Unknown170; // = 0.1
        /* 0x174 */ public float Unknown174; // = 0.15
        /* 0x178 */ public float Unknown178; // = 0.2
        /* 0x17C */ public int CivilianTraderSpaceshipsCacheCount_aka_ShipVariationsPerSystem;
        /* 0x180 */ public Vector3f SpaceshipSpawnFreqMultipliers;

        [NMS(Size = 0x7)]
        /* 0x18C */ public GcAISpaceshipWeightingData[] SpaceshipWeightings; // this could use an enum
    }
}