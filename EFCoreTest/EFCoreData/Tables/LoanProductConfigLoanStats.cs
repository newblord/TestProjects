using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LoanProductConfigLoanStats
    {
        public int LoanProductConfigLoanStatsKey { get; set; }
        public int LoanProductConfigKey { get; set; }
        public short Location { get; set; }
        public int LoansCount { get; set; }
        public int OpenLoansCount { get; set; }
        public DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }

        public virtual LoanProductConfig LoanProductConfigKeyNavigation { get; set; }
        public virtual Company LocationNavigation { get; set; }
    }
}
