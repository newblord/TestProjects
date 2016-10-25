using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class GoldDailyBag
    {
        public GoldDailyBag()
        {
            GoldDailyBagDetail = new HashSet<GoldDailyBagDetail>();
            GoldTransferDetail = new HashSet<GoldTransferDetail>();
        }

        public int GoldDailyBagKey { get; set; }
        public short Location { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }
        public int GbGlAcct { get; set; }
        public int GbBagNum { get; set; }
        public short GbBagCount { get; set; }
        public decimal GbBagTotal { get; set; }
        public int TransDetailKey { get; set; }
        public bool Reversed { get; set; }
        public int? ReversedTransDetailKey { get; set; }

        public virtual ICollection<GoldDailyBagDetail> GoldDailyBagDetail { get; set; }
        public virtual ICollection<GoldTransferDetail> GoldTransferDetail { get; set; }
        public virtual Glacct GbGlAcctNavigation { get; set; }
    }
}
