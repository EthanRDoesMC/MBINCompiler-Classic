﻿using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    public class TkLanguagesAllowedData : NMSTemplate
    {
        public List<TkLanguages> Allowed;
        public TkLanguages Language;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding14;
    }
}
