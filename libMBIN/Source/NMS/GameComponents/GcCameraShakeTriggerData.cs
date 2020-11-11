using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x38, GUID = 0x2615DE9F43439438, NameHash = 0x09C4DEE4AEE9C44E)]
    public class GcCameraShakeTriggerData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Anim;
        /* 0x10 */ public int FrameStart;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x14 */ public byte[] Padding14;
        [NMS(Size = 0x20)]
        /* 0x18 */ public string Shake;
    }
}
