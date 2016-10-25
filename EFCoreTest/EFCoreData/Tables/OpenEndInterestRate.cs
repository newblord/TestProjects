using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class OpenEndInterestRate
    {
        public int OpenEndInterestRateKey { get; set; }
        public int LoanKey { get; set; }
        public DateTime InterestStartDate { get; set; }
        public decimal AnnualRatePct { get; set; }
        public decimal MonthlyRatePct { get; set; }
        public decimal DailyRatePct { get; set; }

        public virtual Loan LoanKeyNavigation { get; set; }
    }
}
