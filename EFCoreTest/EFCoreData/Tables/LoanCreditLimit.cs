using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LoanCreditLimit
    {
        public int LoanCreditLimitKey { get; set; }
        public int LoanKey { get; set; }
        public int CustomerKey { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }
        public decimal OldLimit { get; set; }
        public decimal NewLimit { get; set; }
    }
}
