using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LoanApplicationIncome
    {
        public int LoanApplicationIncomeKey { get; set; }
        public int LoanApplicationKey { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }
        public string AmountType { get; set; }
        public string AmountCycle { get; set; }
        public decimal IncomeAmount { get; set; }
        public int LoanApplicationEmployerKey { get; set; }
        public int? IncomeVerifyMethodKey { get; set; }
        public DateTime? DateVerified { get; set; }

        public virtual LoanApplicationEmployer LoanApplicationEmployerKeyNavigation { get; set; }
        public virtual LoanApplication LoanApplicationKeyNavigation { get; set; }
    }
}
