using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class GoldConfigItem
    {
        public short GoldItemKey { get; set; }
        public short GoldConfigKey { get; set; }

        public virtual GoldConfig GoldConfigKeyNavigation { get; set; }
        public virtual GoldItem GoldItemKeyNavigation { get; set; }
    }
}
