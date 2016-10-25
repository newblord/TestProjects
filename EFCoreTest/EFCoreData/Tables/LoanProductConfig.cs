using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LoanProductConfig
    {
        public LoanProductConfig()
        {
            FurtherFinanceExecutionLogDetail = new HashSet<FurtherFinanceExecutionLogDetail>();
            FurtherFinanceResultDetail = new HashSet<FurtherFinanceResultDetail>();
            LoanApplicationProduct = new HashSet<LoanApplicationProduct>();
            LoanProductBlocked = new HashSet<LoanProductBlocked>();
            LoanProductConfigApprovalRate = new HashSet<LoanProductConfigApprovalRate>();
            LoanProductConfigEdit = new HashSet<LoanProductConfigEdit>();
            LoanProductConfigInsuranceRate = new HashSet<LoanProductConfigInsuranceRate>();
            LoanProductConfigInterestRate = new HashSet<LoanProductConfigInterestRate>();
            LoanProductConfigLoanFeeRate = new HashSet<LoanProductConfigLoanFeeRate>();
            LoanProductConfigLoanStats = new HashSet<LoanProductConfigLoanStats>();
            LoanProductConfigMaxLoanAmtRate = new HashSet<LoanProductConfigMaxLoanAmtRate>();
            LoanProductConfigRirate = new HashSet<LoanProductConfigRirate>();
            LoanProductEnableNewLoan = new HashSet<LoanProductEnableNewLoan>();
            LoanProductRollover = new HashSet<LoanProductRollover>();
            TempLoanProductSplitNewLoanProductConfigKeyNavigation = new HashSet<TempLoanProductSplit>();
            TempLoanProductSplitOrigLoanProductConfigKeyNavigation = new HashSet<TempLoanProductSplit>();
        }

        public int LoanProductConfigKey { get; set; }
        public int LoanProductKey { get; set; }
        public short AppSubmitWaitDays { get; set; }
        public short AppClosedAfterDaysPending { get; set; }
        public short AppClosedAfterDaysValidated { get; set; }
        public bool AutoRollEnabled { get; set; }
        public byte AutoRollMinDaysNoNewLoan { get; set; }
        public bool BuydownZeroRecInsteadLastEnabled { get; set; }
        public bool BuydownRequiredEnabled { get; set; }
        public byte BuydownRequiredAtRolloverCount { get; set; }
        public byte BuydownRequiredType { get; set; }
        public byte BuydownRequiredPct { get; set; }
        public decimal BuydownMaxAmt { get; set; }
        public bool Buydown3rdRollover10pctEnabled { get; set; }
        public decimal BuyupMaxAmt { get; set; }
        public decimal CabLenderAnnualInterestPct { get; set; }
        public decimal CabLenderRiFeePerDefault { get; set; }
        public byte CabLenderRiFeesPerLoan { get; set; }
        public decimal CabLenderRiFeeMin { get; set; }
        public byte CabLenderFiFeePct { get; set; }
        public short CheckDepositDays { get; set; }
        public byte CoolingOffDays { get; set; }
        public byte CoolingOffReqTillPayoffDay { get; set; }
        public bool CoolingOffEnabled { get; set; }
        public bool CoolingOffKansasEnabled { get; set; }
        public short CoolingOffKansasHours { get; set; }
        public bool CoolingOffOklahomaEnabled { get; set; }
        public short CoolingOffOklahomaDaysAfter { get; set; }
        public short CoolingOffOklahomaPtpDaysAfter { get; set; }
        public byte CoolingOffOregonDaysAfter { get; set; }
        public byte CoolingOffOregonDaysBefore { get; set; }
        public byte CustomerMinAge { get; set; }
        public bool CutRateIsEnabled { get; set; }
        public byte CutRateMinNumDaysBetweenLoans { get; set; }
        public byte CutRateNumSpayLoans { get; set; }
        public short CutRateOnLoansWithinDays { get; set; }
        public short CutRateWithinDays { get; set; }
        public byte DaysCashOnlyPayoff { get; set; }
        public bool DepositMethodAutoPayEnabled { get; set; }
        public byte DepositMethodAutoPayOrder { get; set; }
        public decimal DepositMethodAutoPayoffThresholdAmt { get; set; }
        public bool DepositMethodChecksEnabled { get; set; }
        public byte DepositMethodChecksOrder { get; set; }
        public bool DepositMethodDebitCardWithChecksEnabled { get; set; }
        public bool DepositMethodExcludeDcardFromMiddayEnabled { get; set; }
        public bool DepositMethodAchDayAfterDueDateEnabled { get; set; }
        public bool DiscountsEnabled { get; set; }
        public bool DiscountsAffectCashEnabled { get; set; }
        public bool DueDateChangeEnabled { get; set; }
        public byte DueDateMaxExtDays { get; set; }
        public byte DueDateMaxExtBeyondDays { get; set; }
        public bool DueDateCalcPriorToPaydate { get; set; }
        public byte DueDateAdjustForHolidaysAndWeekendsMethod { get; set; }
        public byte DueDateMinDaysBeforeChange { get; set; }
        public byte EasypayItemsPerLoan { get; set; }
        public bool EnableBcPplan { get; set; }
        public bool EnableColoradoMaintFees { get; set; }
        public bool EnableDeclinedAutoPayChgChkAcct { get; set; }
        public bool EnableDeclinedAutoPayNewLoan { get; set; }
        public bool EnableDefaultDate { get; set; }
        public bool EnableJointLoans { get; set; }
        public bool EnableMaxLoanAmtOverrideOnBuyup { get; set; }
        public bool EnableMiddayExcludeToday { get; set; }
        public bool EnableNewLoanDualAuthWithoutBankacct { get; set; }
        public bool EnableNewLoanDualAuthWithoutCcard { get; set; }
        public bool EnablePartialPayment { get; set; }
        public bool EnablePayInFull { get; set; }
        public bool EnablePplan { get; set; }
        public bool EnablePromptForCheckAmt { get; set; }
        public bool EnableSpanishDocs { get; set; }
        public bool EnableStateLoanTerm { get; set; }
        public bool EnableStoreFundAccountValidationPrompt { get; set; }
        public bool EnableStoreFundLoan { get; set; }
        public decimal FasterPaymentsFeeAmt { get; set; }
        public bool FeesAndInterestCapAffordabilityEnabled { get; set; }
        public short FeesAndInterestCapAffordabilityDisposableIncomePctMultiplier { get; set; }
        public bool FeesAndInterestCapEnabled { get; set; }
        public bool FeesAndInterestCapIncludeFees { get; set; }
        public bool FeesAndInterestCapIncludeInterest { get; set; }
        public short FeesAndInterestCapPct { get; set; }
        public bool FundUsingFedScheduleEnabled { get; set; }
        public bool GovtIdRequiredEnabled { get; set; }
        public short IndebtednessMaxDays { get; set; }
        public bool InterestAnnualRateUseTableEnabled { get; set; }
        public decimal InterestAnnualRatePct { get; set; }
        public bool InterestRateCalcIncludesFeeEnabled { get; set; }
        public decimal InterestAnnualRateDebitRatePct { get; set; }
        public decimal InterestDeclinedAutoPayPct { get; set; }
        public bool InterestBasedOnPastDueEnabled { get; set; }
        public bool InterestChargedAfterMaturityEnabled { get; set; }
        public bool InterestAmortTableCapEnabled { get; set; }
        public bool InterestUseLowestRateFromNewOrOpenEnabled { get; set; }
        public bool InterestMinEnabled { get; set; }
        public short InterestMinDays { get; set; }
        public decimal InterestMinAnnualRateOverridePct { get; set; }
        public bool InterestRateNegotiationEnabled { get; set; }
        public bool InterestRateOverrideEnabled { get; set; }
        public byte LimitNewLoanDaysAfterPayoff { get; set; }
        public byte LimitNewLoanDaysNextLoan { get; set; }
        public int? LoanConfigApplyPaymentOrderKey { get; set; }
        public decimal LoanAmtDefaultAmt { get; set; }
        public decimal LoanAmtMaxAmt { get; set; }
        public decimal LoanAmtMaxMultiAmt { get; set; }
        public decimal LoanAmtMinAmt { get; set; }
        public decimal LoanAmtMgrOverrideAmt { get; set; }
        public int LoanAmtMgrOverridePct { get; set; }
        public bool LoanAmtMaxIncludesFeeEnabled { get; set; }
        public bool LoanAmtMaxIncludesOpenPrincSubsequentLoans { get; set; }
        public bool LoanAmtMaxAllowOverrideLoanAmtWithFees { get; set; }
        public bool LoanAmtPriorAmtCapEnabled { get; set; }
        public bool LoanFeeUseTableEnabled { get; set; }
        public decimal LoanFeePct { get; set; }
        public decimal LoanFeeMaxAmt { get; set; }
        public bool LoanFeeTruncateEnabled { get; set; }
        public decimal LoanFeeMinToOverridePct { get; set; }
        public byte LoanFeeWaiveOnBuyupWithinDays { get; set; }
        public bool LoanFeeBasedOnLengthEnabled { get; set; }
        public short LoanLengthMinDays { get; set; }
        public byte LoanLengthMinDaysChecksMonthly { get; set; }
        public byte LoanLengthMinDaysChecksNonMonthly { get; set; }
        public byte LoanLengthMinDaysDebitCardsMonthly { get; set; }
        public byte LoanLengthMinDaysDebitCardsNonMonthly { get; set; }
        public byte LoanLengthMinMonths { get; set; }
        public byte LoanLengthMinPayments { get; set; }
        public short LoanLengthMaxDays { get; set; }
        public byte LoanLengthMaxDaysMonthly { get; set; }
        public byte LoanLengthMaxDaysNonMonthly { get; set; }
        public byte LoanLengthMaxDaysExtBeyondMaxSystem { get; set; }
        public byte LoanLengthMaxSeriesDays { get; set; }
        public byte LoanLengthMaxRollDays { get; set; }
        public string LoanLengthMaxRollDaysType { get; set; }
        public byte LoanLengthMaxMonths { get; set; }
        public byte LoanLengthMaxPayments { get; set; }
        public byte LoanLengthDefaultDays { get; set; }
        public byte LoanLengthDefaultMonths { get; set; }
        public bool LoanLengthDefaultIsCeiling { get; set; }
        public bool LoanLengthDefaultIsFloor { get; set; }
        public byte LoanLengthDefaultPayments { get; set; }
        public short LoanLengthEffectiveDays { get; set; }
        public bool LoanLengthEffectiveDateEnabled { get; set; }
        public bool LoanLengthChangeEnabled { get; set; }
        public bool LoanQualEnabled { get; set; }
        public short LoanQualVerifyDaysFromLastLoan { get; set; }
        public short LoanQualVerifyBankAcctAfterDays { get; set; }
        public decimal LoanQualIncreaseForDirectDepositAmt { get; set; }
        public decimal LoanQualIncreaseForSuccessfulLoansAmt { get; set; }
        public decimal LoanQualIncreaseForValidDebitCardAmt { get; set; }
        public byte LoanQualIncreaseSuccessfulLoansCount { get; set; }
        public byte MaxLoansPerYear { get; set; }
        public byte MaxLoansPerDay { get; set; }
        public bool MaxLoansIncludeRolloverEnabled { get; set; }
        public byte MaxOpenLoansCount { get; set; }
        public bool MaxLoansCountSpouseOpenLoansEnabled { get; set; }
        public short MaxCollectionDaysToAllowRollover { get; set; }
        public bool MaxMultiAmtExcludeFeeOnNewLoanEnabled { get; set; }
        public string MaxPaymentGrossOrNet { get; set; }
        public string MaxPaymentGrossOrNetAllOpenLoans { get; set; }
        public bool MaxPaymentPctOfIncomeEnabled { get; set; }
        public decimal MaxPaymentPctOfIncome { get; set; }
        public bool MaxPaymentPctOfIncomeAllOpenLoansEnabled { get; set; }
        public decimal MaxPaymentPctOfIncomeAllOpenLoans { get; set; }
        public bool MaxPaymentIncludeOpenLoansEnabled { get; set; }
        public bool MaxPaymentSumPaymentsPerMonthEnabled { get; set; }
        public bool MaxPaymentDeductMortgageFromIncomeEnabled { get; set; }
        public bool MonthlyCustUseNonmonthyMaxDaysEnabled { get; set; }
        public byte NextNewLoanOriginationFeeGracePeriodDays { get; set; }
        public bool NoOverrideOpenLoanEnabled { get; set; }
        public decimal OverridePctAmtOfIncome { get; set; }
        public string OverridePctIncomeGrossOrNet { get; set; }
        public byte PaymentSchedWeeks { get; set; }
        public bool PaymentSchedDueDateMatchEnabled { get; set; }
        public byte PaymentSchedDueCycleChangesPerLoanSeries { get; set; }
        public bool PaymentSchedSelectPayCycleEnabled { get; set; }
        public byte PaymentSchedUseNextPaydateWithinDaysBiweekly { get; set; }
        public byte PaymentSchedUseNextPaydateWithinDaysMonthly { get; set; }
        public short PaymentBlackoutHours { get; set; }
        public byte RebateLimitPct { get; set; }
        public byte RebateGracePeriodDays { get; set; }
        public bool RebateColoradoEarlyPayoffEnabled { get; set; }
        public bool RebateAnnualInterestEnabled { get; set; }
        public bool RebateGracePeriodOrigFeeEnabled { get; set; }
        public bool RebateOnRolloverEnabled { get; set; }
        public bool RebateOrigFeeEnabled { get; set; }
        public byte RebateMaxDaysToPayAfterWithdraw { get; set; }
        public bool ReduceApprovalEnabled { get; set; }
        public short ReduceApprovalWhenLessThanAmt { get; set; }
        public byte ReduceApprovalWhenLessThanPct { get; set; }
        public string ReduceApprovalGrossOrNetIncome { get; set; }
        public byte ReduceApprovalIncomePercentMultiplier { get; set; }
        public bool RequireDebitCard { get; set; }
        public bool RequireNotifySpouseByMail { get; set; }
        public bool RequireVerbalReview { get; set; }
        public byte RiCyclesPastDueCalcType { get; set; }
        public decimal RiFeePerDefaultAmt { get; set; }
        public byte RiFeePerDefaultPct { get; set; }
        public decimal RiFeeMinAmt { get; set; }
        public byte RiFeeMaxPerLoanCount { get; set; }
        public decimal RiFeeMaxPerLoanAmt { get; set; }
        public short RiFeeMaxPerLoanSeriesAmt { get; set; }
        public bool RiFeeNoFee3rdRollEnabled { get; set; }
        public bool RiFeeNoFeeOpenRiEnabled { get; set; }
        public bool RiFeeNoFeeStopPayEnabled { get; set; }
        public decimal RiFeeChargeForDebitCardAmt { get; set; }
        public byte RiFeeAssessOnDay { get; set; }
        public bool RiFeeRequiresBankAccount { get; set; }
        public byte RiFeeWaivePct { get; set; }
        public bool RiInterestEnabled { get; set; }
        public decimal RiInterestAnnualRatePct { get; set; }
        public decimal RiInterestMaxLimitAmt { get; set; }
        public decimal RiInterestMinLimitAmt { get; set; }
        public bool RiInterestUseRateTable { get; set; }
        public short RiInterestDays { get; set; }
        public byte RolloverMaxCount { get; set; }
        public byte RolloverMaxScheduledCount { get; set; }
        public bool RolloverOutCollEnabled { get; set; }
        public bool RolloverOutCollResetsNum { get; set; }
        public bool SameDayPayoffAndNewIsRollEnabled { get; set; }
        public byte SetInactiveOnDay { get; set; }
        public byte SetInactiveOnDayAfterMissedPaymentCount { get; set; }
        public byte SetInactiveOnDayAfterNotice { get; set; }
        public byte SetInactiveOnMissedPaymentCount { get; set; }
        public bool ScoringEnabled { get; set; }
        public bool ScoringEveryCustomerLoanEnabled { get; set; }
        public bool ScoringSnapshotsEnabled { get; set; }
        public bool ScoringDataPullEnabled { get; set; }
        public DateTime? ScoringStartDate { get; set; }
        public decimal ScoringApprovalPoints { get; set; }
        public short ScoringIncreaseMinScore { get; set; }
        public short ScoringIncreaseMaxScore { get; set; }
        public decimal ScoringIncreaseAmt { get; set; }
        public byte ScoringIncreaseMaxPct { get; set; }
        public string ScoringBumpUpsBasedOnIncomeType { get; set; }
        public bool ScoringDenialOverrideEnabled { get; set; }
        public bool ScoringOverrideEnabled { get; set; }
        public decimal ScoringOverrideAmt { get; set; }
        public short ScoringOverridePct { get; set; }
        public byte ScoringOverrideType { get; set; }
        public bool ScoringIncreaseRiRestart { get; set; }
        public bool ScoringMgrOverrideLoanAmtEnabled { get; set; }
        public byte ScoringIncreaseMinDays { get; set; }
        public byte ScoringIncreaseNumSuccessfulPayments { get; set; }
        public bool ScoringTalkoffEnabled { get; set; }
        public bool SplitFeeEnabled { get; set; }
        public decimal SplitFeeAtAmount { get; set; }
        public decimal SplitFeeAbovePct { get; set; }
        public bool SsnRequiredForLoanEnabled { get; set; }
        public short StateReqWaitDays { get; set; }
        public bool WithdrawEnabled { get; set; }
        public byte WithdrawMaxDays { get; set; }
        public byte WithdrawMaxDaysToPayAfter { get; set; }
        public string WithdrawDateMethod { get; set; }
        public byte PaymentSchedAmortMethod { get; set; }
        public bool PendingPaymentsAsUnpaidForNewLoan { get; set; }
        public decimal LoanFeeMinAmt { get; set; }
        public decimal LoanFeeAmt1 { get; set; }
        public decimal LoanFeeAmt2 { get; set; }
        public string LoanFeeMethod { get; set; }
        public decimal LoanFeeForRolloverAmt { get; set; }
        public decimal LoanFeeInclDocPrepFeeAmt { get; set; }
        public bool LoanAmtMaxPreviousAmtAnyProduct { get; set; }
        public bool MaxApprovalPctOfIncomeEnabled { get; set; }
        public string MaxApprovalPctOfIncomeGrossOrNet { get; set; }
        public decimal MaxApprovalPctOfIncome { get; set; }
        public bool MaxApprovalPctOfIncomeIncludeOpenLoansEnabled { get; set; }
        public decimal MaxOpenLoansPctOfIncome { get; set; }
        public string MaxOpenLoansPctOfIncomeGrossOrNet { get; set; }
        public bool DepositMethodAutoPayCalcOrderEnabled { get; set; }
        public int? DepositMethodAutoPayCalcOrderRuleDefSetKey { get; set; }
        public byte RiGracePeriodDaysProtectedAuditCat { get; set; }
        public byte RiGracePeriodDaysNonProtectedAuditCat { get; set; }
        public bool RiFeeExcludeProtectedAuditCatEnabled { get; set; }
        public decimal LoanAmtMgrOverrideMinAmt { get; set; }
        public bool PaymentSchedUseCustomerPayCycle { get; set; }
        public decimal IncomeNetAmtMin { get; set; }
        public DateTime? DepositMethodAutoPayCalcStartDate { get; set; }
        public short RevisionNum { get; set; }
        public string Note { get; set; }
        public DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string UpdatedBy { get; set; }
        public bool RolloverAmortEnabled { get; set; }
        public string ScoringBumpUpsLimitedTierBasedOnIncomeType { get; set; }
        public bool EnableRbcEfund { get; set; }
        public bool PrincAmtMatchMaxLoanAmtRateTable { get; set; }
        public bool PrincAmtMatchLoanFeeRateTable { get; set; }
        public bool MaxLoanAmtRateTableEnabled { get; set; }
        public bool InsuranceRateTableEnabled { get; set; }
        public decimal InsuranceCogsPct { get; set; }
        public decimal AprOverridePct { get; set; }
        public short InsuranceCancelRequestDays { get; set; }
        public short InsuranceCancelGracePeriodDays { get; set; }
        public bool MaxTotalCollectionsAchAttemptsPerDayEnabled { get; set; }
        public int MaxTotalCollectionsAchAttemptsPerDay { get; set; }
        public bool MaxConsecutiveFailedAttemptsEnabled { get; set; }
        public int MaxConsecutiveFailedAttempts { get; set; }
        public int MaxConsecutiveFailedAttemptsMethod { get; set; }
        public bool UseScoredApprovalAmt { get; set; }
        public bool DueDatePaymentQueueEnabled { get; set; }
        public int RbcFundingTimeoutDays { get; set; }
        public decimal InsuranceTaxPct { get; set; }
        public bool OutOfWalletEnabled { get; set; }

        public virtual ICollection<FurtherFinanceExecutionLogDetail> FurtherFinanceExecutionLogDetail { get; set; }
        public virtual ICollection<FurtherFinanceResultDetail> FurtherFinanceResultDetail { get; set; }
        public virtual ICollection<LoanApplicationProduct> LoanApplicationProduct { get; set; }
        public virtual ICollection<LoanProductBlocked> LoanProductBlocked { get; set; }
        public virtual ICollection<LoanProductConfigApprovalRate> LoanProductConfigApprovalRate { get; set; }
        public virtual ICollection<LoanProductConfigEdit> LoanProductConfigEdit { get; set; }
        public virtual ICollection<LoanProductConfigInsuranceRate> LoanProductConfigInsuranceRate { get; set; }
        public virtual ICollection<LoanProductConfigInterestRate> LoanProductConfigInterestRate { get; set; }
        public virtual ICollection<LoanProductConfigLoanFeeRate> LoanProductConfigLoanFeeRate { get; set; }
        public virtual ICollection<LoanProductConfigLoanStats> LoanProductConfigLoanStats { get; set; }
        public virtual ICollection<LoanProductConfigMaxLoanAmtRate> LoanProductConfigMaxLoanAmtRate { get; set; }
        public virtual LoanProductConfigOpenEnd LoanProductConfigOpenEnd { get; set; }
        public virtual ICollection<LoanProductConfigRirate> LoanProductConfigRirate { get; set; }
        public virtual LoanProductConfigTitle LoanProductConfigTitle { get; set; }
        public virtual ICollection<LoanProductEnableNewLoan> LoanProductEnableNewLoan { get; set; }
        public virtual ICollection<LoanProductRollover> LoanProductRollover { get; set; }
        public virtual ICollection<TempLoanProductSplit> TempLoanProductSplitNewLoanProductConfigKeyNavigation { get; set; }
        public virtual ICollection<TempLoanProductSplit> TempLoanProductSplitOrigLoanProductConfigKeyNavigation { get; set; }
        public virtual RuleDefSet DepositMethodAutoPayCalcOrderRuleDefSetKeyNavigation { get; set; }
        public virtual LoanConfigApplyPaymentOrder LoanConfigApplyPaymentOrderKeyNavigation { get; set; }
        public virtual LoanProduct LoanProductKeyNavigation { get; set; }
    }
}
