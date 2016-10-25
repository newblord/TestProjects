using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class RiBalanceHistory
    {
        public int RiBalanceHistoryKey { get; set; }
        public int RisreptKey { get; set; }
        public DateTime DateEntered { get; set; }
        public decimal RiBalance { get; set; }

        public virtual Risrept RisreptKeyNavigation { get; set; }
    }
}
