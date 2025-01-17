﻿using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    public class TkGraphicsSettings : NMSTemplate
    {
        /* 0x00 */ public int Version;
		/* 0x04 */ public bool FullScreen;
        /* 0x05 */ public bool Borderless;
        /* 0x08 */ public int Monitor;
        [NMS(Size = 0x10, Ignore = true)]
        /* 0x10 */ public byte[] Padding10;
        /* 0x10  public TkMonitorNames; */      // unknown type... whatever it is, it is a list...
		/* 0x20 */ public bool UseScreenResolution;
        /* 0x24 */ public int ResolutionWidth;
        /* 0x28 */ public int ResolutionHeight;
        /* 0x2C */ public int VSyncEx;
		public string[] VsyncExValues()
		{
			return new string[] { "Off", "On", "Adaptive" };
		}
        /* 0x30 */ public bool GSync;
        /* 0x34 */ public int ShadowDetail;
        public string[] ShadowDetailValues()
        {
            return new string[] { "Low", "Normal", "High", "Ultra" };
        }
        /* 0x38 */ public int TextureDetail;
        public string[] TextureDetailValues()
        {
            return new string[] { "Low", "Normal", "High" };
        }
        /* 0x3C */ public int GenerationDetail;
        public string[] GenerationDetailValues()
        {
            return new string[] { "Low", "Normal", "High" };
        }
        /* 0x40 */ public int ReflectionsQuality;
        public string[] ReflectionsQualityValues()
        {
            return new string[] { "Low", "Normal", "High" };
        }
        /* 0x44 */ public int AntiAliasingEx2;
        public string[] AntiAliasingEX2Values()
        {
            return new string[] { "Auto", "None", "FXAA", "TAA_LOW", "TAA", "TAA_FXAA", "SSAA4" };
        }
		/* 0x48 */ public int MotionBlurQuality;
		public string[] MotionBlueQualityValues()
		{
			return new string[] { "Auto", "Off", "Normal", "High", "Ultra" };
		}
		/* 0x4C */ public float MotionBlurStrength;
        /* 0x50 */ public int AnisotropyLevel;
        /* 0x54 */ public float FoVOnFoot;
        /* 0x58 */ public float FoVInShip;
        /* 0x5C */ public int Brightness;
        /* 0x60 */ public int MaxframeRate;
		/* 0x64 */ public int NumHighThreads;
		/* 0x68 */ public int NumLowThreads;
		/* 0x6C */ public int TextureStreamingEx;
		public string[] TextureStreamingExValues()
		{
			return new string[] { "Off", "On", "Auto" };
		}
		/* 0x70 */ public int TexturePageSizeKb;
		/* 0x74 */ public bool ShowRequirementsWarnings;
		/* 0x75 */ public bool RemoveBaseBuildingRestrictions;
		[NMS(Size = 3, Ignore = true)]
		/* 0x76 */ public byte[] Padding76;
		/* 0x78 */ public int BaseBuildingLimit;
        /* 0x7C */ public float MouseClickSpeedMultiplier;
        /* 0x80 */ public int AmbientOcclusion;
        public string[] AmbientOcclusionValues()
        {
            return new string[] { "SSAO", "HBAO", "Off" };
        }
        /* 0x84 */ public bool UseHDR;
        /* 0x85 */ public bool UseLightShafts;
    }
}
