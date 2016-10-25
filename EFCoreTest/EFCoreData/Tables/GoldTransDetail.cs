using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class GoldTransDetail
    {
        public GoldTransDetail()
        {
            GoldTransStoneDetail = new HashSet<GoldTransStoneDetail>();
        }

        public int GoldTransDetailKey { get; set; }
        public int GoldTransKey { get; set; }
        public short GoldItemKey { get; set; }
        public byte MetalTypeCode { get; set; }
        public string Markings { get; set; }
        public string ItemSize { get; set; }
        public byte NumGemstones { get; set; }
        public string GemDescription { get; set; }
        public byte NumDiamonds { get; set; }
        public bool Reversed { get; set; }
        public int ReversedTransDetailKey { get; set; }
        public decimal ReversedWeight { get; set; }
        public bool RequireItemSize { get; set; }

        public virtual ICollection<GoldTransStoneDetail> GoldTransStoneDetail { get; set; }
        public virtual GoldItem GoldItemKeyNavigation { get; set; }
        public virtual GoldTrans GoldTransKeyNavigation { get; set; }
    }
}
