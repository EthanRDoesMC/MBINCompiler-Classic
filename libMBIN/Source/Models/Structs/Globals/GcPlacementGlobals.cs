namespace libMBIN.Models.Structs
{
    // doesn't seem like the game uses any of the values here? | i agree, this hasn't changed in a while -ethanr
    public class GcPlacementGlobals : NMSTemplate
    {
        public float MinFrequency;
        public float MinDensity;
        public float MinPatchSize;
        public int MinPatchVariance;

        public float MaxFrequency;
        public float MaxDensity;
        public float MaxPatchSize;
        public int MaxPatchVariance;

        public float InterpValueVariance; // short for interpolate
        public float HighInterpValue;
        public float MidInterpValue;
        public float LowInterpValue;
    }
}
