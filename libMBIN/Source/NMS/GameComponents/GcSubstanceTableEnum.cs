﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x4, GUID = 0xFC82337D51C3AB87, NameHash = 0x2A7FC25DED2C3BE5)]
    public class GcSubstanceTableEnum : NMSTemplate
    {
        // 0x4C Entries
        public enum SubstanceEnum {
            None, FUEL1, FUEL2, OXYGEN, LAUNCHSUB, LAUNCHSUB2, ROCKETSUB, LAND1, LAND2, LAND3,
            SAND1, CATALYST1, CATALYST2, CAVE1, CAVE2, WATER1, WATER2, WATERPLANT, YELLOW2, RED2,
            GREEN2, BLUE2, STELLAR2, TECHFRAG, LUSH1, DUSTY1, TOXIC1, RADIO1, COLD1, HOT1,
            LAVA1, CREATURE1, ROBOT1, ASTEROID1, ASTEROID2, ASTEROID3, GAS1, GAS2, GAS3, EX_YELLOW,
            EX_RED, EX_GREEN, EX_BLUE, PLANT_TOXIC, PLANT_SNOW, PLANT_RADIO, PLANT_DUST, PLANT_HOT, PLANT_LUSH, PLANT_CAVE,
            PLANT_WATER, PLANT_POOP, SPACEGUNK1, SPACEGUNK2, SPACEGUNK3, SPACEGUNK4, SPACEGUNK5, AF_METAL, SPECIAL_POOP, TECHFRAG_R,
            QUICKSILVER, UNITS, TRA_STANDING_UP, TRA_STANDING_DN, EXP_STANDING_UP, EXP_STANDING_DN, WAR_STANDING_UP, WAR_STANDING_DN, TGUILD_STAND_UP, TGUILD_STAND_DN,
            EGUILD_STAND_UP, EGUILD_STAND_DN, WGUILD_STAND_UP, WGUILD_STAND_DN, SUNGOLD, SOULFRAG
        }
        public SubstanceEnum Substance;
    }
}