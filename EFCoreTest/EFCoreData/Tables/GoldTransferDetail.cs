using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class GoldTransferDetail
    {
        public int GoldTransferDetailKey { get; set; }
        public int GoldTransferKey { get; set; }
        public int GoldDailyBagKey { get; set; }
        public int TransDetailKey { get; set; }

        public virtual GoldDailyBag GoldDailyBagKeyNavigation { get; set; }
        public virtual GoldTransfer GoldTransferKeyNavigation { get; set; }
    }
}
