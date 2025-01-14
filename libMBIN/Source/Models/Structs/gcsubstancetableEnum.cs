﻿namespace libMBIN.Models.Structs
{
    public class GcSubstanceTableEnum : NMSTemplate
    {
        public int Substance;
        public string[] SubstanceValues()
        {
            return new[] {"None", "TECH1", "TECHUNCOMMON1", "TECHRARE1", "COM1", "COMUNCOMMON1", "COMRARE1", "FUEL1", "FUELUNCOMMON1", "FUELRARE1",
                        "TRADEABLE1", "TRADEABLE2", "TRADEABLE3", "TRADEABLE4", "TRADEABLE5", "TRADEABLE6", "TRADEABLE7", "TRADEABLE8",
                        "TRADEABLE9", "TRADEABLE10", "SUBBLUESYS", "SUBREDSYS", "SUBGREENSYS", "SUBTOXIC", "SUBSNOW", "SUBRADIOACTIVE", "SUBBARREN", "SUBSCORCHED",
                         "SUBLUSH", "SUBCAVE", "SUBWATER", "SUBCREATURE", "SUBPOOP", "SUBDRONE", "SUBSHIP", "GAS1", "GAS2", "GAS3", "SPACEGUNK1",
                         "SPACEGUNK2", "SPACEGUNK3", "SPACEGUNK4", "SPACEGUNK5", "TECHFRAG", "VEHICLESUB1", "VEHICLESUB2"};
        }
    }
}
