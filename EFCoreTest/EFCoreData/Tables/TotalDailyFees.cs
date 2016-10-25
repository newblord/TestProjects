using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class TotalDailyFees
    {
        public int TotalDailyFeesKey { get; set; }
        public short Location { get; set; }
        public decimal StoreFeesPayday { get; set; }
        public decimal StoreFeesTitle { get; set; }
        public decimal StoreFeesSig { get; set; }
        public decimal StoreFeesCashChk { get; set; }
        public decimal StoreFeesOther { get; set; }
        public decimal InternetFees { get; set; }
        public decimal StoreFeesTotal { get; set; }
        public short StoreFeesRank { get; set; }
        public decimal AllFeesTotal { get; set; }
        public short AllFeesRank { get; set; }
    }
}
