using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LoanPaymentOpenEnd
    {
        public int LoanPaymentOpenEndKey { get; set; }
        public int LoanPaymentKey { get; set; }
        public decimal PastDueTransFeeAmt { get; set; }
        public decimal PastDueLienFeeAmt { get; set; }
        public decimal PastDueActivityFeeAmt { get; set; }
        public decimal PastDueCollFeeAmt { get; set; }
        public decimal PastDueInterestAmt { get; set; }
        public decimal PastDuePrincAmt { get; set; }
        public decimal CurrDueTransFeeAmt { get; set; }
        public decimal CurrDueLienFeeAmt { get; set; }
        public decimal CurrDueActivityFeeAmt { get; set; }
        public decimal CurrDueInterestAmt { get; set; }
        public decimal CurrDuePrincAmt { get; set; }
        public decimal NextDueTransFeeAmt { get; set; }
        public decimal NextDueLienFeeAmt { get; set; }
        public decimal NextDueActivityFeeAmt { get; set; }
        public decimal NextDueInterestAmt { get; set; }
        public decimal NextDuePrincAmt { get; set; }
        public decimal NotDueTransFeeAmt { get; set; }
        public decimal NotDueLienFeeAmt { get; set; }
        public decimal NotDueActivityFeeAmt { get; set; }
        public decimal NotDueInterestAmt { get; set; }
        public decimal NotDuePrincAmt { get; set; }
        public bool AddToColl { get; set; }
        public bool RemFromColl { get; set; }
        public decimal? TotTransFeeAmt { get; set; }
        public decimal? TotLienFeeAmt { get; set; }
        public decimal? TotActivityFeeAmt { get; set; }
        public decimal? TotInterestFeeAmt { get; set; }
        public decimal? TotPrincFeeAmt { get; set; }
        public decimal FundingAmt { get; set; }
        public string FundingStatusCode { get; set; }
        public int? FundingAchHistoryKey { get; set; }
        public int? FundingLoanPaymentKey { get; set; }
        public decimal PendingSchedAchAmt { get; set; }
        public bool IsInterestReductionPayment { get; set; }
        public bool IsPrincipleOnlyPayment { get; set; }
        public decimal PastDueCsoLenderCollFeeAmt { get; set; }
        public decimal PastDueCsoLenderInterestAmt { get; set; }
        public decimal CurrDueCsoLenderInterestAmt { get; set; }
        public decimal NextDueCsoLenderInterestAmt { get; set; }
        public decimal NotDueCsoLenderInterestAmt { get; set; }
        public decimal? TotPastDueAmt { get; set; }
        public decimal? TotCurrDueAmt { get; set; }
        public decimal? TotNextDueAmt { get; set; }
        public decimal? TotNotDueAmt { get; set; }
        public decimal? TotCsoLenderInterestFeeAmt { get; set; }
        public short FundingMethod { get; set; }
        public int? AchProcessingQueueKey { get; set; }

        public virtual LoanPayment LoanPaymentKeyNavigation { get; set; }
    }
}
