﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x20, GUID = 0xB545659CC02F4296, NameHash = 0x390E6B7795024BAB)]
    public class GcSubstanceTable : NMSTemplate
    {
        public List<GcRealitySubstanceData> Table;
        public List<GcRealityCraftingRecipeData> Crafting;
    }
}