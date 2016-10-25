using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LoanFundingMethodHistory
    {
        public int LoanFundingMethodHistoryKey { get; set; }
        public int LoanKey { get; set; }
        public byte FundingMethod { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }

        public virtual Loan LoanKeyNavigation { get; set; }
    }
}
