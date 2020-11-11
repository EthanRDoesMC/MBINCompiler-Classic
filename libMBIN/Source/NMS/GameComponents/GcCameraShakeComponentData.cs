using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x18, GUID = 0x8FC4FB96433D6E8D, NameHash = 0x77B3408A8150441E)]
    public class GcCameraShakeComponentData : NMSTemplate
    {
        /* 0x0 */ public float DangerRadius;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x4 */ public byte[] Padding4;
        /* 0x8 */ public List<GcCameraShakeTriggerData> AnimTriggers;
    }
}
