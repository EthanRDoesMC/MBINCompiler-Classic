﻿namespace libMBIN.Models.Structs
{
    public class GcGraphicsGlobals : NMSTemplate
    {
        /* 0x000 */ public float GameBrightness;
        public float Unknown4;
        public float Unknown8;
        public float UnknownC;
        public float Unknown10;
        public float Unknown14;
        public float Unknown18;
        public float Unknown1C;
        /* 0x020 */ public float FogSaturationStrength;
        public float Unknown24;
        public float Unknown28;
        public float Unknown2C;
        public float Unknown30;
        public float Unknown34;
        public float Unknown38;
        public float Unknown3C;
        public float Unknown40;
        public float Unknown44;
        public float Unknown48;
        public float Unknown4C;
        public float Unknown50;
        public float Unknown54;
        public float Unknown58;
        public float Unknown5C;
        public float Unknown60;
        public float Unknown64;
        public float Unknown68;
        public float Unknown6C;
        public float Unknown70;
        public float Unknown74;
        public float Unknown78;
        public float Unknown7C;
        public float Unknown80;
        public float Unknown84;
        public float Unknown88;
        public float Unknown8C;
        public float Unknown90;
        public float Unknown94;
        public float Unknown98;
        public float Unknown9C;
        public float UnknownA0;
        public float UnknownA4;
        public float UnknownA8;
        public float UnknownAC;
        public float UnknownB0;
        public float UnknownB4;
        public float UnknownB8;
        public float UnknownBC;
        public float UnknownC0;
        public float UnknownC4;
        public float UnknownC8;
        public float UnknownCC;
        public float UnknownD0;
        public float UnknownD4;
        public float UnknownD8;
        public float UnknownDC;
        public bool UnknownE0;
        public bool UnknownE1;

        [NMS(Size = 0xE, Ignore = true)]
        public byte[] PaddingC2;

        /* 0xF0 */ public TkImGuiSettings ImGuiSettings;

        public float Unknown280;
        public float Unknown284;
        public float Unknown288;
        public float Unknown28C;
        public float Unknown290;
        public float Unknown294;
        public float Unknown298;
        public float Unknown29C;
        public float Unknown2A0;
        public float Unknown2A4;
        public float Unknown2A8;
        public float Unknown2AC;
        public float Unknown2B0;
        public float Unknown2B4;
        public float Unknown2B8;
        public float MinViewDistance;
        public float MaxViewDistance;
        public float Unknown2C4;
        public float Unknown2C8;
        public float Unknown2CC;
        public float Unknown2D0;
        public int UnknownInt2D4;
        public float Unknown2D8;
        public float Unknown2DC;
        public float Unknown2E0;
        public float Unknown2E4;
        public float Unknown2E8;
        public float Unknown2EC;
        public float Unknown2F0;
        public float Unknown2F4;
        public float Unknown2F8;
        public float Unknown2FC;
        public float Unknown300;
        public float Unknown304;
        public float Unknown308;
        public float Unknown30C;
        public float Unknown310;
        public float Unknown314;
        public float Unknown318;
        public float Unknown31C;
        public float Unknown320;
        public float Unknown324;
        public float Unknown328;
        public float Unknown32C;
        public float Unknown330;
        public float Unknown334;
        public float Unknown338;
        public float Unknown33C;
        public float Unknown340;
        public float Unknown344;
        public float Unknown348;
        public float Unknown34C;
        public float Unknown350;
        public float Unknown354;
        public float Unknown358;
        public float Unknown35C;
        public bool Unknown360;
        public float Unknown364;
        public float Unknown368;
        public float Unknown36C;
        public float Unknown370;
        public float Unknown374;
        public float Unknown378;
        public float Unknown37C;
        public float Unknown380;
        public float Unknown384;
        public float Unknown388;
        public float Unknown38C;
        public float Unknown390;
        public float Unknown394;
        public float Unknown398;
        public float Unknown39C;
        public float Unknown3A0;
        public float Unknown3A4;
        public float Unknown3A8;
        public float Unknown3AC;
        public float Unknown3B0;
        public float Unknown3B4;
        public float Unknown3B8;
        public float Unknown3BC;
        public float Unknown3C0;
        public float Unknown3C4;
        public float Unknown3C8;
        public float Unknown3CC;
        public float Unknown3D0;
        public float Unknown3D4;
        public float Unknown3D8;
        public float Unknown3DC;
        public float Unknown3E0;
        public float Unknown3E4;
        public float Unknown3E8;
        public float Unknown3EC;
        public float Unknown3F0;
        public float Unknown3F4;
        public float Unknown3F8;
        public float Unknown3FC;
        public float Unknown400;        // something here??
        public float Unknown404;
        public float Unknown408;
        public float Unknown40C;
        public float Unknown410;
        public float Unknown414;
        public float Unknown418;
        public float Unknown41C;
        public float Unknown420;        // 'til maybe about here??
        public bool Unknown424;
        public bool Unknown428;
        public float Unknown42C;
        public float Unknown430;
        public float Unknown434;
        public float Unknown438;
        public float Unknown43C;
        public float Unknown440;
        public float Unknown444;
        public float Unknown448;
        public float Unknown44C;
        public float Unknown450;
        public float Unknown454;
        public float Unknown458;
        public float Unknown45C;
        public float Unknown460;
        public float Unknown464;
        public float Unknown468;
        public float Unknown46C;
        public float Unknown470;
        public float Unknown474;
        public float Unknown478;
        public float Unknown47C;
        public float Unknown480;
        public float Unknown484;
        public float Unknown488;
        public float Unknown48C;
        public float Unknown490;
        public float Unknown494;
        public float Unknown498;
        public float Unknown49C;
        public float Unknown4A0;
        public float Unknown4A4;
        public float Unknown4A8;
        public float Unknown4AC;
        public float Unknown4B0;
        public float Unknown4B4;
        public float Unknown4B8;
        public float Unknown4BC;
        public float Unknown4C0;
        public float Unknown4C4;
        public float Unknown4C8;
        public float Unknown4CC;
        public float Unknown4D0;
        public float Unknown4D4;
        public float Unknown4D8;
        public float Unknown4DC;
        public float Unknown4E0;
        public float Unknown4E4;
        public float Unknown4E8;
        public float Unknown4EC;
        public float Unknown4F0;
        public float Unknown4F4;
        public float Unknown4F8;
        public float Unknown4FC;
        public float Unknown500;
        public float Unknown504;
        public float Unknown508;
        public float Unknown50C;
        public float Unknown510;
        public float Unknown514;
        public float Unknown518;
        public float Unknown51C;
        public float Unknown520;
        public float Unknown524;
        public float Unknown528;
        public float Unknown52C;
        public float Unknown530;
        public float Unknown534;
        public float Unknown538;
        public float Unknown53C;
        public float Unknown540;
        public float Unknown544;
        public float Unknown548;
        public float Unknown54C;

        public GcPlanetWaterData PlanetWaterData;       // All values here are the ones that all planets have except the colours
        public GcPlanetWaterData UnusedPlanetWaterData;

        public float Unknown8B0;
        public float Unknown8B4;
        public float Unknown8B8;
        public float Unknown8BC;
        public float Unknown8C0;
        public float Unknown8C4;
        public float Unknown8C8;
        public bool Unknown8CC;
        public bool Unknown8CD;
        public bool Unknown8CE;
        public bool Unknown8CF;
        public float Unknown8D0;
        public bool Unknown8D4;
        public bool Unknown8D5;
        public bool Unknown8D6;
        public bool Unknown8D7;
        [NMS(Size = 0x8, Ignore = true)]
        public byte[] Padding8D8;
        public float Unknown8E0;
        public float Unknown8E4;
        public float Unknown8E8;
        public float Unknown8EC;
        public float Unknown8F0;
        public float Unknown8F4;
        public float Unknown8F8;
        public bool Unknown8FC;
        public int UnknownInt900;
        public int UnknownInt904;
        public int UnknownInt908;
        public int UnknownInt90C;
        public int UnknownInt910;
        public bool Unknown914;
        public bool Unknown915;
        public bool Unknown916;
        public bool Unknown917;
        public int UnknownInt918;

        public float Unknown91C;
        public float Unknown920;
        public float Unknown924;
        public float Unknown928;
        public float Unknown92C;
        public float Unknown930;
        public float Unknown934;
        [NMS(Size = 0x8, Ignore = true)]
        public byte[] EndPadding;
    }
}
