using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LoanProductConfigOpenEnd
    {
        public int LoanProductConfigOpenEndKey { get; set; }
        public int LoanProductConfigKey { get; set; }
        public int LoanProductKey { get; set; }
        public decimal ActivityFeeAmt { get; set; }
        public decimal ActivityFeePct { get; set; }
        public byte CabDefaultLoanLength { get; set; }
        public byte CabFeeDayOffset { get; set; }
        public bool CashAdvanceDisabled { get; set; }
        public decimal CashAdvanceLimitAmt { get; set; }
        public bool CashAdvanceLimitEnabled { get; set; }
        public short CloseWhenInactiveDays { get; set; }
        public bool CloseWhenPaidOff { get; set; }
        public byte CoolingDaysAfterFinalRollover { get; set; }
        public byte CoolingDaysCashAdvanceAfterPayment { get; set; }
        public byte CycleDays { get; set; }
        public bool FlatFeeBiweeklyRatesEnabled { get; set; }
        public bool FlatFeeRulesEnabled { get; set; }
        public bool GiftCardProceedsEnabled { get; set; }
        public DateTime? EnforceRolloverRestrictionsAsOfDate { get; set; }
        public bool IsOrdinanceLocation { get; set; }
        public bool LimitZeroBalanceStatements { get; set; }
        public decimal MinPrincDueFourWeeksAmt { get; set; }
        public decimal MinPrincDueFourWeeksPct { get; set; }
        public decimal MinPrincDueTwoWeeksAmt { get; set; }
        public decimal MinPrincDueTwoWeeksPct { get; set; }
        public byte NewLoanWithinClosingPreviousLoanDays { get; set; }
        public bool NewLoanWithinClosingPreviousLoanOnlyEnabled { get; set; }
        public short NonOrdinanceLocation { get; set; }
        public bool PayPrincBeforeNextAndNotDue { get; set; }
        public byte PaymentDueCycleDays { get; set; }
        public bool PrincAmtIncrementEnabled { get; set; }
        public decimal PrincAmtIncrementAmt { get; set; }
        public bool StmtsEmailEnabled { get; set; }
        public short StmtsGenCycleDays { get; set; }
        public bool CashAdvanceRescindDuringGracePeriodEnabled { get; set; }

        public virtual LoanProductConfig LoanProductConfigKeyNavigation { get; set; }
        public virtual LoanProduct LoanProductKeyNavigation { get; set; }
    }
}
