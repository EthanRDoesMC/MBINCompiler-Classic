namespace libMBIN.Models.Structs
{
    public class GcSimulationGlobals : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string StartingSceneFile;
        [NMS(Size = 0x80)]
        public string MultitoolFile;

        public ulong ProceduralBuildingsGenerationSeed; // PlanetSimulationSeed perhaps? used in a function containing string "PlanetRoot", which is called by cGcSimulation::Construct()

        [NMS(Size = 0x80)]
        public string SpaceStationFile;
        [NMS(Size = 1)]
        public NMSString0x80[] BlackHoleAnomalies; //wtf
        [NMS(Size = 0xC)]
        public NMSString0x80[] AtlasStationAnomalies;
        [NMS(Size = 0x80)]
        public string SpaceAnomalyFile;
        [NMS(Size = 0x80)]
        public string None; // not set
        [NMS(Size = 0x80)]
        public string PlacementDroneFile;
        [NMS(Size = 0x80)]
        public string HeavyAirCave;
        [NMS(Size = 0x80)]
        public string HeavyAirUnderwater;
        [NMS(Size = 3)]
        public NMSString0x80[] PrefetchScenegraphResources_aka_LaserScenes; //LaserScenes; i'm not leaving people guessing with a name like that
        [NMS(Size = 2)]
        public NMSString0x80[] PrefetchMaterialResources_aka_WaterMaterials; //WaterMaterials;
        [NMS(Size = 0x80)]
        public string PlanetAtmosphereFile;
        [NMS(Size = 0x80)]
        public string PlanetAtmosphereMaterialFile;
        [NMS(Size = 0x80)]
        public string PlanetMaterialFile;
        [NMS(Size = 0x80)]
        public string PlanetWaterMaterialFile;
        [NMS(Size = 6)]
        public NMSString0x80[] PlanetTerrainMaterials_aka_TerrainLODMaterials; //TerrainLODMaterials;
        [NMS(Size = 0x10)]
        public NMSString0x80[] PrefetchTextureResources_aka_BiomeTilemapTextures; //BiomeTilemapTextures;
        [NMS(Size = 0x80)]
        public string WarpTunnelFile;
        [NMS(Size = 0x80)]
        public string BlackHoleTunnelFile;
        [NMS(Size = 3, EnumValue = new[] { "TeleportTunnelFile", "PortalTunnelFile", "PortalStoryTunnelFile" })]
        public NMSString0x80[] WarpPortalScenes;
    }
}
