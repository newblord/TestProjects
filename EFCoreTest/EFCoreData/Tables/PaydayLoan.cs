using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class PaydayLoan
    {
        public int PaydayLoanKey { get; set; }
        public int LoanKey { get; set; }
        public string CheckNo { get; set; }
        public bool? StartupCheck { get; set; }
        public decimal? Split2ndRatePct { get; set; }
        public decimal? SplitAmount { get; set; }
        public decimal? SplitPrvOpenBal { get; set; }
        public decimal? Split1stFee { get; set; }
        public decimal? Split2ndFee { get; set; }
        public string DisplayCheckNo { get; set; }
        public string DepositMethod { get; set; }
        public bool IsPrepay { get; set; }
        public int AgreementNumber { get; set; }
        public int? DuedateChangeKey { get; set; }
        public bool IsExpress { get; set; }

        public virtual Loan LoanKeyNavigation { get; set; }
    }
}
