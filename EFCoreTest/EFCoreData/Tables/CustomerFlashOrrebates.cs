using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CustomerFlashOrrebates
    {
        public int CustomerKey { get; set; }
        public decimal? RebateAmt { get; set; }
        public string Teller { get; set; }
        public DateTime? DateRebated { get; set; }
    }
}
