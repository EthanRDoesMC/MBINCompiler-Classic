﻿namespace libMBIN.Models.Structs
{
    public class GcAtlasGlobals : NMSTemplate
    {
        public int ChanceOfDisconnect;
        public int ResolveTimeout;
        public int ConnectTimeout;
        public int SendRecvTimeout;
    }
}
// this is a global, why is it here?