using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x10, GUID = 0x0000000000000000, NameHash = 0xF128895FDB533FA8)]
    public class GcUnlockableTwitchRewards : NMSTemplate
    {
        public List<GcUnlockableTwitchReward> Table;
    }
}
