using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class EndOfDayInventoryDetail
    {
        public int EodrKey { get; set; }
        public int LoanKey { get; set; }
        public decimal OnhandAmt { get; set; }
        public bool Defaulted { get; set; }
        public decimal RiBalance { get; set; }
        public decimal? CabFeeReceivableAmt { get; set; }
    }
}
