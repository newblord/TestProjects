using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class GoldDailyBagDetail
    {
        public int GoldDailyBagDetailKey { get; set; }
        public int GoldDailyBagKey { get; set; }
        public int GoldTransKey { get; set; }

        public virtual GoldDailyBag GoldDailyBagKeyNavigation { get; set; }
    }
}
