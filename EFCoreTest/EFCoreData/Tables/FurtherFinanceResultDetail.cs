using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class FurtherFinanceResultDetail
    {
        public int FurtherFinanceResultDetailKey { get; set; }
        public int FurtherFinanceResultKey { get; set; }
        public int FurtherFinanceOutcomeKey { get; set; }
        public int FurtherFinanceQueryKey { get; set; }
        public int? LoanProductConfigKey { get; set; }
        public int? LoanProductKey { get; set; }
        public decimal? LoanLimit { get; set; }
        public decimal? WageLimit { get; set; }
        public decimal? DisposableLimit { get; set; }
        public decimal? FurtherFinanceAmt { get; set; }
        public string FurtherFinanceAmtMessage { get; set; }

        public virtual FurtherFinanceOutcome FurtherFinanceOutcomeKeyNavigation { get; set; }
        public virtual FurtherFinanceQuery FurtherFinanceQueryKeyNavigation { get; set; }
        public virtual FurtherFinanceResult FurtherFinanceResultKeyNavigation { get; set; }
        public virtual LoanProductConfig LoanProductConfigKeyNavigation { get; set; }
        public virtual LoanProduct LoanProductKeyNavigation { get; set; }
    }
}
