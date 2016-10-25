﻿using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class OpenEndLoan
    {
        public int OpenEndLoanKey { get; set; }
        public int LoanKey { get; set; }
        public byte TransFeePct { get; set; }
        public byte CycleDays { get; set; }
        public short StatementDays { get; set; }
        public short PaymentDays { get; set; }
        public decimal LastPaymentAmt { get; set; }
        public DateTime? LastPaymentDate { get; set; }
        public decimal LastCashAdvAmt { get; set; }
        public DateTime? LastCashAdvDate { get; set; }
        public byte LastStatementNum { get; set; }
        public DateTime? LastStatementDate { get; set; }
        public DateTime NextStatementDate { get; set; }
        public DateTime NextDueDate { get; set; }
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
        public decimal CreditLimit { get; set; }
        public decimal CreditAvail { get; set; }
        public DateTime? ClosedDate { get; set; }
        public bool SuspendInterest { get; set; }
        public bool EmailStatements { get; set; }
        public decimal? TransFeeAmt { get; set; }
        public decimal? LienFeeAmt { get; set; }
        public decimal? ActivityFeeAmt { get; set; }
        public decimal? InterestFeeAmt { get; set; }
        public decimal? PrincFeeAmt { get; set; }
        public bool IsBusinessLoan { get; set; }
        public bool IsUsePayCycle { get; set; }
        public bool IsGiftCardLoan { get; set; }
        public decimal PendingSchedAchAmt { get; set; }
        public byte SelectedCycleWeeks { get; set; }
        public decimal PastDueCsoLenderCollFeeAmt { get; set; }
        public decimal PastDueCsoLenderInterestAmt { get; set; }
        public decimal CurrDueCsoLenderInterestAmt { get; set; }
        public decimal NextDueCsoLenderInterestAmt { get; set; }
        public decimal NotDueCsoLenderInterestAmt { get; set; }
        public decimal CsoLenderAnnualRatePct { get; set; }
        public decimal CsoLenderMonthlyRatePct { get; set; }
        public decimal CsoLenderDailyRatePct { get; set; }
        public byte TermLimitDays { get; set; }
        public DateTime? TermLimitFinalStatementDate { get; set; }
        public DateTime? TermLimitFinalDueDate { get; set; }
        public byte SetInactiveOnMissedPaymentCount { get; set; }
        public byte SetInactiveOnDayAfterMissedPaymentCount { get; set; }
        public decimal? CurrDueAmt { get; set; }
        public decimal? NextDueAmt { get; set; }
        public decimal? NotDueAmt { get; set; }
        public decimal PrintTotCsoInterestAmt { get; set; }
        public decimal PrintPayment1PrincAmt { get; set; }
        public decimal PrintPayment2PrincAmt { get; set; }
        public decimal PrintPayment1InterestAmt { get; set; }
        public decimal PrintPayment2InterestAmt { get; set; }
        public decimal PrintTotInterestAmt { get; set; }
        public decimal PrintTotPaymentsAmt { get; set; }
        public decimal? CollectionsAmt { get; set; }
        public bool DeclinedAutoPay { get; set; }
        public decimal PrintPayment1TransFeeAmt { get; set; }
        public decimal PrintPayment2TransFeeAmt { get; set; }
        public decimal PrintPayment1TotalDueAmt { get; set; }
        public decimal PrintPayment2TotalDueAmt { get; set; }
        public DateTime? PrintPayment1Duedate { get; set; }
        public DateTime? PrintPayment2Duedate { get; set; }
        public decimal MinPrincDueTwoWeeksPct { get; set; }
        public decimal MinPrincDueFourWeeksPct { get; set; }
        public decimal MinPrincDueTwoWeeksAmt { get; set; }
        public decimal MinPrincDueFourWeeksAmt { get; set; }
        public byte PrintPayment1StatementDays { get; set; }
        public byte PrintPayment2StatementDays { get; set; }
        public decimal PrintCashAdvPayment1TotalDueAmt { get; set; }
        public decimal PrintCashAdvPayment2TotalDueAmt { get; set; }
        public decimal PrintCashAdvPayment1PrincAmt { get; set; }
        public decimal PrintCashAdvPayment2PrincAmt { get; set; }
        public decimal PrintCashAdvPayment1InterestAmt { get; set; }
        public decimal PrintCashAdvPayment2InterestAmt { get; set; }
        public decimal PrintCashAdvTotInterestAmt { get; set; }
        public decimal PrintCashAdvTotCsoInterestAmt { get; set; }
        public decimal PrintCashAdvTotPaymentsAmt { get; set; }
        public decimal PrintCashAdvFinalPaymentAmt { get; set; }
        public byte PrintCashAdvPaymentCount { get; set; }
        public byte PrintCashAdvFeeOnlyPaymentCount { get; set; }
        public decimal? CsoLenderInterestFeeAmt { get; set; }
        public decimal ActivityFeeTwoWeekPct { get; set; }
        public decimal ActivityFeeFourWeekPct { get; set; }
        public bool EnableFlatFeeRules { get; set; }
        public decimal PrintCashAdvFinanceCharge { get; set; }
        public bool ChargeInterestOnLoanFees { get; set; }
        public DateTime? ResumeInterestDate { get; set; }
        public bool ResumeInterestOnPayment { get; set; }
        public decimal CreditAvailableForBuyup { get; set; }
        public decimal CreditLimitNonOrdinance { get; set; }
        public decimal CreditAvailableForBuyupNonOrdinance { get; set; }
        public decimal? LastCabFeeAmt { get; set; }
        public DateTime? LastCabFeeDate { get; set; }
        public DateTime? InactiveDate { get; set; }
        public byte SetInactiveOnDay { get; set; }
        public DateTime? OrigFinalStatementDate { get; set; }
        public DateTime? OrigFinalDueDate { get; set; }
        public DateTime? PendingDueDateChangeOrigDueDate { get; set; }
        public DateTime? PendingDueDateChangeAdjustedDueDate { get; set; }
        public byte CabFeeDayOffset { get; set; }
        public bool FinanceLienFee { get; set; }
        public decimal? PastDueAmt { get; set; }
        public byte MaxRiFeesPerLoanSeries { get; set; }
        public bool RiFeeRequiresBankAccount { get; set; }
    }
}
