﻿namespace libMBIN.Models.Structs
{
    public class GcCreatureVocalSoundData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Id;

        public int VocalEmote;
        public string[] VocalEmoteValues()
        {
            return new[] { "EmoteIdle", "EmoteFlee", "EmoteAggression", "EmoteRoar", "EmotePain", "EmoteAttack", "EmoteDie", "EmoteMiniRoarNeutral", "EmoteMiniRoarHappy", "EmoteMiniRoarAngry" };
        }

        public float PlayFrequency;
        public float MinCooldown;
        public float MaxCooldown;
        public bool PlayImmediately;
        public bool PlayOnlyOnce;

        [NMS(Size = 6, Ignore = true)]
        public byte[] Padding22;
    }
}
