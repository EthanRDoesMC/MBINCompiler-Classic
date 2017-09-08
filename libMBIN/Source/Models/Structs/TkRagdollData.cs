﻿using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    public class TkRagdollData : NMSTemplate
    {
        public float Density;
        public float Gravity;
        public List<NMSString0x20> ChainEnds;
        public List<NMSString0x20> ExcludeJoints;
    }
}
