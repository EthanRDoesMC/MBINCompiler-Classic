namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x644B852D83365033, NameHash = 0x943946549DEC2216)]
    public class TkEngineSettingTypes : NMSTemplate
    {
        // size: 0x32
        public enum EngineSettingEnum : uint {
            FullScreen,
            Borderless,
            ResolutionWidth,
            ResolutionHeight,
            ResolutionScale,
            Monitor,
            FoVOnFoot,
            FoVInShip,
            VSync,
            TextureQuality,
            AnimationQuality,
            ShadowQuality,
            ReflectionsMultiplier,
            ReflectionProbesMultiplier,
            ReflectionProbes,
            ScreenSpaceReflections,
            ReflectionsQuality,
            PostProcessingEffects,
            VolumetricsQuality,
            TerrainTessellation,
            PlanetQuality,
            BaseQuality,
            UIQuality,
            DLSSQuality,
            FFXSRQuality,
            FFXSR2Quality,
            XESSQuality,
            DynamicResScaling,
            EnableTessellation,
            AntiAliasing,
            AnisotropyLevel,
            Brightness,
            VignetteAndScanlines,
            AvailableMonitors,
            MaxFrameRate,
            NumLowThreads,
            NumHighThreads,
            NumGraphicsThreads,
            TextureStreaming,
            TexturePageSizeKb,
            MotionBlurStrength,
            ShowRequirementsWarnings,
            AmbientOcclusion,
            MaxTextureMemoryMb,
            FixedTextureMemory,
            UseArbSparseTexture,
            UseTerrainTextureCache,
            AdapterIndex,
            UseHDR,
            MinGPUMode,
        }
        /* 0x0 */ public EngineSettingEnum EngineSetting;
    }
}
