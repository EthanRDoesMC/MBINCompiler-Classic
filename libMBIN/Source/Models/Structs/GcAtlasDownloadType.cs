﻿namespace libMBIN.Models.Structs
{
    public class GcAtlasDownloadType : NMSTemplate
    {
        public int DownloadType;
        public string[] DownloadTypeValues()
        {
            return new[]
            {
                "Unknown", "Discovery", "Base", "Message"
            };
        }
    }
}
