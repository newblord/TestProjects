using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LoanIncome
    {
        public int LoanIncomeKey { get; set; }
        public int LoanKey { get; set; }
        public int CustomerIncomeKey { get; set; }

        public virtual CustomerIncome CustomerIncomeKeyNavigation { get; set; }
        public virtual Loan LoanKeyNavigation { get; set; }
    }
}
