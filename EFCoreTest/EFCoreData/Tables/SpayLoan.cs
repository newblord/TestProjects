using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class SpayLoan
    {
        public int SpayLoanKey { get; set; }
        public int LoanKey { get; set; }
        public decimal AnnualRatePct { get; set; }
        public decimal InterestAmt { get; set; }
        public decimal InterestPaid { get; set; }
        public bool IsAutoRoll { get; set; }
        public decimal CollAnnualRatePct { get; set; }
        public decimal TotInterest { get; set; }
        public bool IsInterestSuspended { get; set; }
        public decimal CollFeeDueBalance { get; set; }
        public decimal LegalFeeDueBalance { get; set; }
        public decimal LoanFeeDueBalance { get; set; }
        public decimal InterestDueBalance { get; set; }
        public decimal CabInterestDueBalance { get; set; }
        public decimal PrincDueBalance { get; set; }
        public decimal DailyRatePct { get; set; }
        public decimal CollDailyRatePct { get; set; }
        public decimal CabAnnualRatePct { get; set; }
        public decimal CabDailyRatePct { get; set; }
        public decimal TotCabInterest { get; set; }
        public decimal CabLenderCollFeePastDueBalance { get; set; }
        public decimal TotCabLenderCollFee { get; set; }
        public bool ChargeInterestOnLoanFees { get; set; }
        public decimal NsfFeeDueBalance { get; set; }
        public decimal MinInterestAmt { get; set; }
        public short MinInterestDays { get; set; }
        public bool RiFeeRequiresBankAccount { get; set; }
        public decimal? DailyInterestAmt { get; set; }
        public decimal TransFeeDueBalance { get; set; }
        public decimal RolloverAmortPaymentAmt { get; set; }

        public virtual Loan LoanKeyNavigation { get; set; }
    }
}
