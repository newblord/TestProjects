using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class MpayLoan
    {
        public int MpayLoanKey { get; set; }
        public int LoanKey { get; set; }
        public decimal AnnualRatePct { get; set; }
        public decimal MonthlyRatePct { get; set; }
        public decimal DailyRatePct { get; set; }
        public decimal ActuarialApr { get; set; }
        public byte OddDaysInterestCnt { get; set; }
        public decimal OddDaysInterestAmt { get; set; }
        public byte TransFeePct { get; set; }
        public byte CycleDays { get; set; }
        public byte CollectionDays { get; set; }
        public byte AmortPaymentCnt { get; set; }
        public decimal SchedLastPaymentAmt { get; set; }
        public DateTime? SchedLastPaymentDate { get; set; }
        public decimal LastPaymentAmt { get; set; }
        public DateTime? LastPaymentDate { get; set; }
        public decimal NextDueAmt { get; set; }
        public DateTime? NextDueDate { get; set; }
        public decimal EstFinanceCharge { get; set; }
        public decimal CreditLimit { get; set; }
        public DateTime? ClosedDate { get; set; }
        public bool SuspendInterest { get; set; }
        public decimal PendingSchedAchAmt { get; set; }
        public decimal TransFeeAmt { get; set; }
        public int? CreditcardKey { get; set; }
        public decimal PaymentPlanFee { get; set; }
        public int PaymentPlanLoanKey { get; set; }
        public bool IsBusinessLoan { get; set; }
        public string TransFeeMethod { get; set; }
        public decimal TransFeeColoradoPostponeAmt { get; set; }
        public bool DeclinedAutoPay { get; set; }
        public byte SetInactiveOnDay { get; set; }
        public byte SetInactiveOnMissedPaymentCount { get; set; }
        public byte SetInactiveOnDayAfterMissedPaymentCount { get; set; }
        public byte SelectedCycleWeeks { get; set; }
        public decimal CollFeePastDueBal { get; set; }
        public decimal LegalFeePastDueBal { get; set; }
        public decimal LoanFeeDueBal { get; set; }
        public decimal TransFeeDueBal { get; set; }
        public decimal InterestDueBal { get; set; }
        public decimal PrincDueBal { get; set; }
        public decimal PaymentDueBal { get; set; }
        public decimal PaymentPastDueBal { get; set; }
        public decimal? CollectionsBal { get; set; }
        public decimal CabAnnualRatePct { get; set; }
        public decimal CabMonthlyRatePct { get; set; }
        public decimal CabDailyRatePct { get; set; }
        public decimal CabCollFeePastDueBal { get; set; }
        public decimal CabInterestDueBal { get; set; }
        public DateTime? ResumeInterestDate { get; set; }
        public bool ResumeInterestOnPayment { get; set; }
        public string ApplyDiscountTo { get; set; }
        public DateTime? InactiveDate { get; set; }
        public decimal RiFeePerDefault { get; set; }
        public byte RiFeesPerLoan { get; set; }
        public decimal NsfFeePastDueBal { get; set; }
        public bool MatchSpayRate { get; set; }
        public bool CycleDaysFixed { get; set; }
        public bool CycleDueDateMatch { get; set; }
        public bool IsDayAfterDue { get; set; }
        public byte MaxRiFeesPerLoanSeries { get; set; }
        public bool RiFeeRequiresBankAccount { get; set; }
        public DateTime? OrigMaturityDate { get; set; }
        public DateTime AdjustedMaturityDate { get; set; }
        public int CyclesPastDue { get; set; }
        public decimal? DailyInterestAmt { get; set; }
        public decimal InsuranceDueBal { get; set; }
        public int? InsuranceStatusKey { get; set; }
        public DateTime? RoCancelInsuranceRequestDate { get; set; }
        public string RoCancelInsuranceRequestBy { get; set; }
        public decimal DueDatePaymentQueueBal { get; set; }
        public decimal InventoryBal { get; set; }

        public virtual CreditCards CreditcardKeyNavigation { get; set; }
        public virtual Loan LoanKeyNavigation { get; set; }
    }
}
