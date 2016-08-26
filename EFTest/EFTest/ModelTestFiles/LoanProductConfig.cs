namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoanProductConfig")]
    public partial class LoanProductConfig
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoanProductConfig()
        {
            FurtherFinanceExecutionLogDetails = new HashSet<FurtherFinanceExecutionLogDetail>();
            FurtherFinanceResultDetails = new HashSet<FurtherFinanceResultDetail>();
            LoanApplicationProducts = new HashSet<LoanApplicationProduct>();
            LoanProductBlockeds = new HashSet<LoanProductBlocked>();
            LoanProductConfigApprovalRates = new HashSet<LoanProductConfigApprovalRate>();
            LoanProductConfigEdits = new HashSet<LoanProductConfigEdit>();
            LoanProductConfigInsuranceRates = new HashSet<LoanProductConfigInsuranceRate>();
            LoanProductConfigInterestRates = new HashSet<LoanProductConfigInterestRate>();
            LoanProductConfigLoanFeeRates = new HashSet<LoanProductConfigLoanFeeRate>();
            LoanProductConfigLoanStats = new HashSet<LoanProductConfigLoanStat>();
            LoanProductConfigMaxLoanAmtRates = new HashSet<LoanProductConfigMaxLoanAmtRate>();
            LoanProductConfigOpenEnds = new HashSet<LoanProductConfigOpenEnd>();
            LoanProductConfigRIRates = new HashSet<LoanProductConfigRIRate>();
            LoanProductConfigTitles = new HashSet<LoanProductConfigTitle>();
            LoanProductEnableNewLoans = new HashSet<LoanProductEnableNewLoan>();
            LoanProductRollovers = new HashSet<LoanProductRollover>();
            TempLoanProductSplits = new HashSet<TempLoanProductSplit>();
            TempLoanProductSplits1 = new HashSet<TempLoanProductSplit>();
        }

        [Key]
        public int LOAN_PRODUCT_CONFIG_KEY { get; set; }

        public int LOAN_PRODUCT_KEY { get; set; }

        public short APP_SUBMIT_WAIT_DAYS { get; set; }

        public short APP_CLOSED_AFTER_DAYS_PENDING { get; set; }

        public short APP_CLOSED_AFTER_DAYS_VALIDATED { get; set; }

        public bool AUTO_ROLL_ENABLED { get; set; }

        public byte AUTO_ROLL_MIN_DAYS_NO_NEW_LOAN { get; set; }

        public bool BUYDOWN_ZERO_REC_INSTEAD_LAST_ENABLED { get; set; }

        public bool BUYDOWN_REQUIRED_ENABLED { get; set; }

        public byte BUYDOWN_REQUIRED_AT_ROLLOVER_COUNT { get; set; }

        public byte BUYDOWN_REQUIRED_TYPE { get; set; }

        public byte BUYDOWN_REQUIRED_PCT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal BUYDOWN_MAX_AMT { get; set; }

        public bool BUYDOWN_3RD_ROLLOVER_10PCT_ENABLED { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal BUYUP_MAX_AMT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CAB_LENDER_ANNUAL_INTEREST_PCT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CAB_LENDER_RI_FEE_PER_DEFAULT { get; set; }

        public byte CAB_LENDER_RI_FEES_PER_LOAN { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CAB_LENDER_RI_FEE_MIN { get; set; }

        public byte CAB_LENDER_FI_FEE_PCT { get; set; }

        public short CHECK_DEPOSIT_DAYS { get; set; }

        public byte COOLING_OFF_DAYS { get; set; }

        public byte COOLING_OFF_REQ_TILL_PAYOFF_DAY { get; set; }

        public bool COOLING_OFF_ENABLED { get; set; }

        public bool COOLING_OFF_KANSAS_ENABLED { get; set; }

        public short COOLING_OFF_KANSAS_HOURS { get; set; }

        public bool COOLING_OFF_OKLAHOMA_ENABLED { get; set; }

        public short COOLING_OFF_OKLAHOMA_DAYS_AFTER { get; set; }

        public short COOLING_OFF_OKLAHOMA_PTP_DAYS_AFTER { get; set; }

        public byte COOLING_OFF_OREGON_DAYS_AFTER { get; set; }

        public byte COOLING_OFF_OREGON_DAYS_BEFORE { get; set; }

        public byte CUSTOMER_MIN_AGE { get; set; }

        public bool CUT_RATE_IS_ENABLED { get; set; }

        public byte CUT_RATE_MIN_NUM_DAYS_BETWEEN_LOANS { get; set; }

        public byte CUT_RATE_NUM_SPAY_LOANS { get; set; }

        public short CUT_RATE_ON_LOANS_WITHIN_DAYS { get; set; }

        public short CUT_RATE_WITHIN_DAYS { get; set; }

        public byte DAYS_CASH_ONLY_PAYOFF { get; set; }

        public bool DEPOSIT_METHOD_AUTO_PAY_ENABLED { get; set; }

        public byte DEPOSIT_METHOD_AUTO_PAY_ORDER { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal DEPOSIT_METHOD_AUTO_PAYOFF_THRESHOLD_AMT { get; set; }

        public bool DEPOSIT_METHOD_CHECKS_ENABLED { get; set; }

        public byte DEPOSIT_METHOD_CHECKS_ORDER { get; set; }

        public bool DEPOSIT_METHOD_DEBIT_CARD_WITH_CHECKS_ENABLED { get; set; }

        public bool DEPOSIT_METHOD_EXCLUDE_DCARD_FROM_MIDDAY_ENABLED { get; set; }

        public bool DEPOSIT_METHOD_ACH_DAY_AFTER_DUE_DATE_ENABLED { get; set; }

        public bool DISCOUNTS_ENABLED { get; set; }

        public bool DISCOUNTS_AFFECT_CASH_ENABLED { get; set; }

        public bool DUE_DATE_CHANGE_ENABLED { get; set; }

        public byte DUE_DATE_MAX_EXT_DAYS { get; set; }

        public byte DUE_DATE_MAX_EXT_BEYOND_DAYS { get; set; }

        public bool DUE_DATE_CALC_PRIOR_TO_PAYDATE { get; set; }

        public byte DUE_DATE_ADJUST_FOR_HOLIDAYS_AND_WEEKENDS_METHOD { get; set; }

        public byte DUE_DATE_MIN_DAYS_BEFORE_CHANGE { get; set; }

        public byte EASYPAY_ITEMS_PER_LOAN { get; set; }

        public bool ENABLE_BC_PPLAN { get; set; }

        public bool ENABLE_COLORADO_MAINT_FEES { get; set; }

        public bool ENABLE_DECLINED_AUTO_PAY_CHG_CHK_ACCT { get; set; }

        public bool ENABLE_DECLINED_AUTO_PAY_NEW_LOAN { get; set; }

        public bool ENABLE_DEFAULT_DATE { get; set; }

        public bool ENABLE_JOINT_LOANS { get; set; }

        public bool ENABLE_MAX_LOAN_AMT_OVERRIDE_ON_BUYUP { get; set; }

        public bool ENABLE_MIDDAY_EXCLUDE_TODAY { get; set; }

        public bool ENABLE_NEW_LOAN_DUAL_AUTH_WITHOUT_BANKACCT { get; set; }

        public bool ENABLE_NEW_LOAN_DUAL_AUTH_WITHOUT_CCARD { get; set; }

        public bool ENABLE_PARTIAL_PAYMENT { get; set; }

        public bool ENABLE_PAY_IN_FULL { get; set; }

        public bool ENABLE_PPLAN { get; set; }

        public bool ENABLE_PROMPT_FOR_CHECK_AMT { get; set; }

        public bool ENABLE_SPANISH_DOCS { get; set; }

        public bool ENABLE_STATE_LOAN_TERM { get; set; }

        public bool ENABLE_STORE_FUND_ACCOUNT_VALIDATION_PROMPT { get; set; }

        public bool ENABLE_STORE_FUND_LOAN { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal FASTER_PAYMENTS_FEE_AMT { get; set; }

        public bool FEES_AND_INTEREST_CAP_AFFORDABILITY_ENABLED { get; set; }

        public short FEES_AND_INTEREST_CAP_AFFORDABILITY_DISPOSABLE_INCOME_PCT_MULTIPLIER { get; set; }

        public bool FEES_AND_INTEREST_CAP_ENABLED { get; set; }

        public bool FEES_AND_INTEREST_CAP_INCLUDE_FEES { get; set; }

        public bool FEES_AND_INTEREST_CAP_INCLUDE_INTEREST { get; set; }

        public short FEES_AND_INTEREST_CAP_PCT { get; set; }

        public bool FUND_USING_FED_SCHEDULE_ENABLED { get; set; }

        public bool GOVT_ID_REQUIRED_ENABLED { get; set; }

        public short INDEBTEDNESS_MAX_DAYS { get; set; }

        public bool INTEREST_ANNUAL_RATE_USE_TABLE_ENABLED { get; set; }

        [Column(TypeName = "numeric")]
        public decimal INTEREST_ANNUAL_RATE_PCT { get; set; }

        public bool INTEREST_RATE_CALC_INCLUDES_FEE_ENABLED { get; set; }

        public decimal INTEREST_ANNUAL_RATE_DEBIT_RATE_PCT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal INTEREST_DECLINED_AUTO_PAY_PCT { get; set; }

        public bool INTEREST_BASED_ON_PAST_DUE_ENABLED { get; set; }

        public bool INTEREST_CHARGED_AFTER_MATURITY_ENABLED { get; set; }

        public bool INTEREST_AMORT_TABLE_CAP_ENABLED { get; set; }

        public bool INTEREST_USE_LOWEST_RATE_FROM_NEW_OR_OPEN_ENABLED { get; set; }

        public bool INTEREST_MIN_ENABLED { get; set; }

        public short INTEREST_MIN_DAYS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal INTEREST_MIN_ANNUAL_RATE_OVERRIDE_PCT { get; set; }

        public bool INTEREST_RATE_NEGOTIATION_ENABLED { get; set; }

        public bool INTEREST_RATE_OVERRIDE_ENABLED { get; set; }

        public byte LIMIT_NEW_LOAN_DAYS_AFTER_PAYOFF { get; set; }

        public byte LIMIT_NEW_LOAN_DAYS_NEXT_LOAN { get; set; }

        public int? LOAN_CONFIG_APPLY_PAYMENT_ORDER_KEY { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal LOAN_AMT_DEFAULT_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal LOAN_AMT_MAX_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal LOAN_AMT_MAX_MULTI_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal LOAN_AMT_MIN_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal LOAN_AMT_MGR_OVERRIDE_AMT { get; set; }

        public int LOAN_AMT_MGR_OVERRIDE_PCT { get; set; }

        public bool LOAN_AMT_MAX_INCLUDES_FEE_ENABLED { get; set; }

        public bool LOAN_AMT_MAX_INCLUDES_OPEN_PRINC_SUBSEQUENT_LOANS { get; set; }

        public bool LOAN_AMT_MAX_ALLOW_OVERRIDE_LOAN_AMT_WITH_FEES { get; set; }

        public bool LOAN_AMT_PRIOR_AMT_CAP_ENABLED { get; set; }

        public bool LOAN_FEE_USE_TABLE_ENABLED { get; set; }

        [Column(TypeName = "numeric")]
        public decimal LOAN_FEE_PCT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal LOAN_FEE_MAX_AMT { get; set; }

        public bool LOAN_FEE_TRUNCATE_ENABLED { get; set; }

        [Column(TypeName = "numeric")]
        public decimal LOAN_FEE_MIN_TO_OVERRIDE_PCT { get; set; }

        public byte LOAN_FEE_WAIVE_ON_BUYUP_WITHIN_DAYS { get; set; }

        public bool LOAN_FEE_BASED_ON_LENGTH_ENABLED { get; set; }

        public short LOAN_LENGTH_MIN_DAYS { get; set; }

        public byte LOAN_LENGTH_MIN_DAYS_CHECKS_MONTHLY { get; set; }

        public byte LOAN_LENGTH_MIN_DAYS_CHECKS_NON_MONTHLY { get; set; }

        public byte LOAN_LENGTH_MIN_DAYS_DEBIT_CARDS_MONTHLY { get; set; }

        public byte LOAN_LENGTH_MIN_DAYS_DEBIT_CARDS_NON_MONTHLY { get; set; }

        public byte LOAN_LENGTH_MIN_MONTHS { get; set; }

        public byte LOAN_LENGTH_MIN_PAYMENTS { get; set; }

        public short LOAN_LENGTH_MAX_DAYS { get; set; }

        public byte LOAN_LENGTH_MAX_DAYS_MONTHLY { get; set; }

        public byte LOAN_LENGTH_MAX_DAYS_NON_MONTHLY { get; set; }

        public byte LOAN_LENGTH_MAX_DAYS_EXT_BEYOND_MAX_SYSTEM { get; set; }

        public byte LOAN_LENGTH_MAX_SERIES_DAYS { get; set; }

        public byte LOAN_LENGTH_MAX_ROLL_DAYS { get; set; }

        [Required]
        [StringLength(1)]
        public string LOAN_LENGTH_MAX_ROLL_DAYS_TYPE { get; set; }

        public byte LOAN_LENGTH_MAX_MONTHS { get; set; }

        public byte LOAN_LENGTH_MAX_PAYMENTS { get; set; }

        public byte LOAN_LENGTH_DEFAULT_DAYS { get; set; }

        public byte LOAN_LENGTH_DEFAULT_MONTHS { get; set; }

        public bool LOAN_LENGTH_DEFAULT_IS_CEILING { get; set; }

        public bool LOAN_LENGTH_DEFAULT_IS_FLOOR { get; set; }

        public byte LOAN_LENGTH_DEFAULT_PAYMENTS { get; set; }

        public short LOAN_LENGTH_EFFECTIVE_DAYS { get; set; }

        public bool LOAN_LENGTH_EFFECTIVE_DATE_ENABLED { get; set; }

        public bool LOAN_LENGTH_CHANGE_ENABLED { get; set; }

        public bool LOAN_QUAL_ENABLED { get; set; }

        public short LOAN_QUAL_VERIFY_DAYS_FROM_LAST_LOAN { get; set; }

        public short LOAN_QUAL_VERIFY_BANK_ACCT_AFTER_DAYS { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal LOAN_QUAL_INCREASE_FOR_DIRECT_DEPOSIT_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal LOAN_QUAL_INCREASE_FOR_SUCCESSFUL_LOANS_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal LOAN_QUAL_INCREASE_FOR_VALID_DEBIT_CARD_AMT { get; set; }

        public byte LOAN_QUAL_INCREASE_SUCCESSFUL_LOANS_COUNT { get; set; }

        public byte MAX_LOANS_PER_YEAR { get; set; }

        public byte MAX_LOANS_PER_DAY { get; set; }

        public bool MAX_LOANS_INCLUDE_ROLLOVER_ENABLED { get; set; }

        public byte MAX_OPEN_LOANS_COUNT { get; set; }

        public bool MAX_LOANS_COUNT_SPOUSE_OPEN_LOANS_ENABLED { get; set; }

        public short MAX_COLLECTION_DAYS_TO_ALLOW_ROLLOVER { get; set; }

        public bool MAX_MULTI_AMT_EXCLUDE_FEE_ON_NEW_LOAN_ENABLED { get; set; }

        [Required]
        [StringLength(1)]
        public string MAX_PAYMENT_GROSS_OR_NET { get; set; }

        [Required]
        [StringLength(1)]
        public string MAX_PAYMENT_GROSS_OR_NET_ALL_OPEN_LOANS { get; set; }

        public bool MAX_PAYMENT_PCT_OF_INCOME_ENABLED { get; set; }

        public decimal MAX_PAYMENT_PCT_OF_INCOME { get; set; }

        public bool MAX_PAYMENT_PCT_OF_INCOME_ALL_OPEN_LOANS_ENABLED { get; set; }

        public decimal MAX_PAYMENT_PCT_OF_INCOME_ALL_OPEN_LOANS { get; set; }

        public bool MAX_PAYMENT_INCLUDE_OPEN_LOANS_ENABLED { get; set; }

        public bool MAX_PAYMENT_SUM_PAYMENTS_PER_MONTH_ENABLED { get; set; }

        public bool MAX_PAYMENT_DEDUCT_MORTGAGE_FROM_INCOME_ENABLED { get; set; }

        public bool MONTHLY_CUST_USE_NONMONTHY_MAX_DAYS_ENABLED { get; set; }

        public byte NEXT_NEW_LOAN_ORIGINATION_FEE_GRACE_PERIOD_DAYS { get; set; }

        public bool NO_OVERRIDE_OPEN_LOAN_ENABLED { get; set; }

        public decimal OVERRIDE_PCT_AMT_OF_INCOME { get; set; }

        [Required]
        [StringLength(1)]
        public string OVERRIDE_PCT_INCOME_GROSS_OR_NET { get; set; }

        public byte PAYMENT_SCHED_WEEKS { get; set; }

        public bool PAYMENT_SCHED_DUE_DATE_MATCH_ENABLED { get; set; }

        public byte PAYMENT_SCHED_DUE_CYCLE_CHANGES_PER_LOAN_SERIES { get; set; }

        public bool PAYMENT_SCHED_SELECT_PAY_CYCLE_ENABLED { get; set; }

        public byte PAYMENT_SCHED_USE_NEXT_PAYDATE_WITHIN_DAYS_BIWEEKLY { get; set; }

        public byte PAYMENT_SCHED_USE_NEXT_PAYDATE_WITHIN_DAYS_MONTHLY { get; set; }

        public short PAYMENT_BLACKOUT_HOURS { get; set; }

        public byte REBATE_LIMIT_PCT { get; set; }

        public byte REBATE_GRACE_PERIOD_DAYS { get; set; }

        public bool REBATE_COLORADO_EARLY_PAYOFF_ENABLED { get; set; }

        public bool REBATE_ANNUAL_INTEREST_ENABLED { get; set; }

        public bool REBATE_GRACE_PERIOD_ORIG_FEE_ENABLED { get; set; }

        public bool REBATE_ON_ROLLOVER_ENABLED { get; set; }

        public bool REBATE_ORIG_FEE_ENABLED { get; set; }

        public byte REBATE_MAX_DAYS_TO_PAY_AFTER_WITHDRAW { get; set; }

        public bool REDUCE_APPROVAL_ENABLED { get; set; }

        public short REDUCE_APPROVAL_WHEN_LESS_THAN_AMT { get; set; }

        public byte REDUCE_APPROVAL_WHEN_LESS_THAN_PCT { get; set; }

        [Required]
        [StringLength(1)]
        public string REDUCE_APPROVAL_GROSS_OR_NET_INCOME { get; set; }

        public byte REDUCE_APPROVAL_INCOME_PERCENT_MULTIPLIER { get; set; }

        public bool REQUIRE_DEBIT_CARD { get; set; }

        public bool REQUIRE_NOTIFY_SPOUSE_BY_MAIL { get; set; }

        public bool REQUIRE_VERBAL_REVIEW { get; set; }

        public byte RI_CYCLES_PAST_DUE_CALC_TYPE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal RI_FEE_PER_DEFAULT_AMT { get; set; }

        public byte RI_FEE_PER_DEFAULT_PCT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal RI_FEE_MIN_AMT { get; set; }

        public byte RI_FEE_MAX_PER_LOAN_COUNT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal RI_FEE_MAX_PER_LOAN_AMT { get; set; }

        public short RI_FEE_MAX_PER_LOAN_SERIES_AMT { get; set; }

        public bool RI_FEE_NO_FEE_3RD_ROLL_ENABLED { get; set; }

        public bool RI_FEE_NO_FEE_OPEN_RI_ENABLED { get; set; }

        public bool RI_FEE_NO_FEE_STOP_PAY_ENABLED { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal RI_FEE_CHARGE_FOR_DEBIT_CARD_AMT { get; set; }

        public byte RI_FEE_ASSESS_ON_DAY { get; set; }

        public bool RI_FEE_REQUIRES_BANK_ACCOUNT { get; set; }

        public byte RI_FEE_WAIVE_PCT { get; set; }

        public bool RI_INTEREST_ENABLED { get; set; }

        [Column(TypeName = "numeric")]
        public decimal RI_INTEREST_ANNUAL_RATE_PCT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal RI_INTEREST_MAX_LIMIT_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal RI_INTEREST_MIN_LIMIT_AMT { get; set; }

        public bool RI_INTEREST_USE_RATE_TABLE { get; set; }

        public short RI_INTEREST_DAYS { get; set; }

        public byte ROLLOVER_MAX_COUNT { get; set; }

        public byte ROLLOVER_MAX_SCHEDULED_COUNT { get; set; }

        public bool ROLLOVER_OUT_COLL_ENABLED { get; set; }

        public bool ROLLOVER_OUT_COLL_RESETS_NUM { get; set; }

        public bool SAME_DAY_PAYOFF_AND_NEW_IS_ROLL_ENABLED { get; set; }

        public byte SET_INACTIVE_ON_DAY { get; set; }

        public byte SET_INACTIVE_ON_DAY_AFTER_MISSED_PAYMENT_COUNT { get; set; }

        public byte SET_INACTIVE_ON_DAY_AFTER_NOTICE { get; set; }

        public byte SET_INACTIVE_ON_MISSED_PAYMENT_COUNT { get; set; }

        public bool SCORING_ENABLED { get; set; }

        public bool SCORING_EVERY_CUSTOMER_LOAN_ENABLED { get; set; }

        public bool SCORING_SNAPSHOTS_ENABLED { get; set; }

        public bool SCORING_DATA_PULL_ENABLED { get; set; }

        [Column(TypeName = "date")]
        public DateTime? SCORING_START_DATE { get; set; }

        public decimal SCORING_APPROVAL_POINTS { get; set; }

        public short SCORING_INCREASE_MIN_SCORE { get; set; }

        public short SCORING_INCREASE_MAX_SCORE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal SCORING_INCREASE_AMT { get; set; }

        public byte SCORING_INCREASE_MAX_PCT { get; set; }

        [Required]
        [StringLength(1)]
        public string SCORING_BUMP_UPS_BASED_ON_INCOME_TYPE { get; set; }

        public bool SCORING_DENIAL_OVERRIDE_ENABLED { get; set; }

        public bool SCORING_OVERRIDE_ENABLED { get; set; }

        public decimal SCORING_OVERRIDE_AMT { get; set; }

        public short SCORING_OVERRIDE_PCT { get; set; }

        public byte SCORING_OVERRIDE_TYPE { get; set; }

        public bool SCORING_INCREASE_RI_RESTART { get; set; }

        public bool SCORING_MGR_OVERRIDE_LOAN_AMT_ENABLED { get; set; }

        public byte SCORING_INCREASE_MIN_DAYS { get; set; }

        public byte SCORING_INCREASE_NUM_SUCCESSFUL_PAYMENTS { get; set; }

        public bool SCORING_TALKOFF_ENABLED { get; set; }

        public bool SPLIT_FEE_ENABLED { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal SPLIT_FEE_AT_AMOUNT { get; set; }

        public decimal SPLIT_FEE_ABOVE_PCT { get; set; }

        public bool SSN_REQUIRED_FOR_LOAN_ENABLED { get; set; }

        public short STATE_REQ_WAIT_DAYS { get; set; }

        public bool WITHDRAW_ENABLED { get; set; }

        public byte WITHDRAW_MAX_DAYS { get; set; }

        public byte WITHDRAW_MAX_DAYS_TO_PAY_AFTER { get; set; }

        [Required]
        [StringLength(1)]
        public string WITHDRAW_DATE_METHOD { get; set; }

        public byte PAYMENT_SCHED_AMORT_METHOD { get; set; }

        public bool PENDING_PAYMENTS_AS_UNPAID_FOR_NEW_LOAN { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal LOAN_FEE_MIN_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal LOAN_FEE_AMT_1 { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal LOAN_FEE_AMT_2 { get; set; }

        [Required]
        [StringLength(1)]
        public string LOAN_FEE_METHOD { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal LOAN_FEE_FOR_ROLLOVER_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal LOAN_FEE_INCL_DOC_PREP_FEE_AMT { get; set; }

        public bool LOAN_AMT_MAX_PREVIOUS_AMT_ANY_PRODUCT { get; set; }

        public bool MAX_APPROVAL_PCT_OF_INCOME_ENABLED { get; set; }

        [Required]
        [StringLength(1)]
        public string MAX_APPROVAL_PCT_OF_INCOME_GROSS_OR_NET { get; set; }

        public decimal MAX_APPROVAL_PCT_OF_INCOME { get; set; }

        public bool MAX_APPROVAL_PCT_OF_INCOME_INCLUDE_OPEN_LOANS_ENABLED { get; set; }

        public decimal MAX_OPEN_LOANS_PCT_OF_INCOME { get; set; }

        [Required]
        [StringLength(1)]
        public string MAX_OPEN_LOANS_PCT_OF_INCOME_GROSS_OR_NET { get; set; }

        public bool DEPOSIT_METHOD_AUTO_PAY_CALC_ORDER_ENABLED { get; set; }

        public int? DEPOSIT_METHOD_AUTO_PAY_CALC_ORDER_RULE_DEF_SET_KEY { get; set; }

        public byte RI_GRACE_PERIOD_DAYS_PROTECTED_AUDIT_CAT { get; set; }

        public byte RI_GRACE_PERIOD_DAYS_NON_PROTECTED_AUDIT_CAT { get; set; }

        public bool RI_FEE_EXCLUDE_PROTECTED_AUDIT_CAT_ENABLED { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal LOAN_AMT_MGR_OVERRIDE_MIN_AMT { get; set; }

        public bool PAYMENT_SCHED_USE_CUSTOMER_PAY_CYCLE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal INCOME_NET_AMT_MIN { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DEPOSIT_METHOD_AUTO_PAY_CALC_START_DATE { get; set; }

        public short REVISION_NUM { get; set; }

        [Required]
        [StringLength(2000)]
        public string NOTE { get; set; }

        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        public DateTime? DATE_UPDATED { get; set; }

        [StringLength(3)]
        public string UPDATED_BY { get; set; }

        public bool ROLLOVER_AMORT_ENABLED { get; set; }

        [Required]
        [StringLength(1)]
        public string SCORING_BUMP_UPS_LIMITED_TIER_BASED_ON_INCOME_TYPE { get; set; }

        public bool ENABLE_RBC_EFUND { get; set; }

        public bool PRINC_AMT_MATCH_MAX_LOAN_AMT_RATE_TABLE { get; set; }

        public bool PRINC_AMT_MATCH_LOAN_FEE_RATE_TABLE { get; set; }

        public bool MAX_LOAN_AMT_RATE_TABLE_ENABLED { get; set; }

        public bool INSURANCE_RATE_TABLE_ENABLED { get; set; }

        public decimal INSURANCE_COGS_PCT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal APR_OVERRIDE_PCT { get; set; }

        public short INSURANCE_CANCEL_REQUEST_DAYS { get; set; }

        public short INSURANCE_CANCEL_GRACE_PERIOD_DAYS { get; set; }

        public bool MAX_TOTAL_COLLECTIONS_ACH_ATTEMPTS_PER_DAY_ENABLED { get; set; }

        public int MAX_TOTAL_COLLECTIONS_ACH_ATTEMPTS_PER_DAY { get; set; }

        public bool MAX_CONSECUTIVE_FAILED_ATTEMPTS_ENABLED { get; set; }

        public int MAX_CONSECUTIVE_FAILED_ATTEMPTS { get; set; }

        public int MAX_CONSECUTIVE_FAILED_ATTEMPTS_METHOD { get; set; }

        public bool USE_SCORED_APPROVAL_AMT { get; set; }

        public bool DUE_DATE_PAYMENT_QUEUE_ENABLED { get; set; }

        public int RBC_FUNDING_TIMEOUT_DAYS { get; set; }

        public decimal INSURANCE_TAX_PCT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FurtherFinanceExecutionLogDetail> FurtherFinanceExecutionLogDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FurtherFinanceResultDetail> FurtherFinanceResultDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanApplicationProduct> LoanApplicationProducts { get; set; }

        public virtual LoanConfigApplyPaymentOrder LoanConfigApplyPaymentOrder { get; set; }

        public virtual LoanProduct LoanProduct { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanProductBlocked> LoanProductBlockeds { get; set; }

        public virtual RuleDefSet RuleDefSet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanProductConfigApprovalRate> LoanProductConfigApprovalRates { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanProductConfigEdit> LoanProductConfigEdits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanProductConfigInsuranceRate> LoanProductConfigInsuranceRates { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanProductConfigInterestRate> LoanProductConfigInterestRates { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanProductConfigLoanFeeRate> LoanProductConfigLoanFeeRates { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanProductConfigLoanStat> LoanProductConfigLoanStats { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanProductConfigMaxLoanAmtRate> LoanProductConfigMaxLoanAmtRates { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanProductConfigOpenEnd> LoanProductConfigOpenEnds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanProductConfigRIRate> LoanProductConfigRIRates { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanProductConfigTitle> LoanProductConfigTitles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanProductEnableNewLoan> LoanProductEnableNewLoans { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanProductRollover> LoanProductRollovers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TempLoanProductSplit> TempLoanProductSplits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TempLoanProductSplit> TempLoanProductSplits1 { get; set; }
    }
}
