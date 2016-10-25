namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Xlpc")]
    public partial class Xlpc
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int lpckey { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int lpkey { get; set; }

        public int? lpcoekey { get; set; }

        public int? lpctkey { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(4)]
        public string XLP { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(75)]
        public string PRODUCT_NAME { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(1)]
        public string PRODUCT_TYPE { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(1)]
        public string LOAN_TYPE { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "date")]
        public DateTime DATE_ENTERED { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        [Key]
        [Column(Order = 8)]
        public bool IS_EXPRESS { get; set; }

        [Key]
        [Column(Order = 9)]
        public bool IS_BUSINESS { get; set; }

        [Key]
        [Column(Order = 10)]
        public bool IS_EASYPAY { get; set; }

        [Key]
        [Column("XLPC", Order = 11)]
        [StringLength(5)]
        public string XLPC1 { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LOAN_PRODUCT_CONFIG_KEY { get; set; }

        [Key]
        [Column(Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LOAN_PRODUCT_KEY { get; set; }

        [Key]
        [Column(Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short APP_SUBMIT_WAIT_DAYS { get; set; }

        [Key]
        [Column(Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short APP_CLOSED_AFTER_DAYS_PENDING { get; set; }

        [Key]
        [Column(Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short APP_CLOSED_AFTER_DAYS_VALIDATED { get; set; }

        [Key]
        [Column(Order = 17)]
        public bool AUTO_ROLL_ENABLED { get; set; }

        [Key]
        [Column(Order = 18)]
        public byte AUTO_ROLL_MIN_DAYS_NO_NEW_LOAN { get; set; }

        [Key]
        [Column(Order = 19)]
        public bool BUYDOWN_ZERO_REC_INSTEAD_LAST_ENABLED { get; set; }

        [Key]
        [Column(Order = 20)]
        public bool BUYDOWN_REQUIRED_ENABLED { get; set; }

        [Key]
        [Column(Order = 21)]
        public byte BUYDOWN_REQUIRED_AT_ROLLOVER_COUNT { get; set; }

        [Key]
        [Column(Order = 22)]
        public byte BUYDOWN_REQUIRED_TYPE { get; set; }

        [Key]
        [Column(Order = 23)]
        public byte BUYDOWN_REQUIRED_PCT { get; set; }

        [Key]
        [Column(Order = 24, TypeName = "smallmoney")]
        public decimal BUYDOWN_MAX_AMT { get; set; }

        [Key]
        [Column(Order = 25)]
        public bool BUYDOWN_3RD_ROLLOVER_10PCT_ENABLED { get; set; }

        [Key]
        [Column(Order = 26, TypeName = "smallmoney")]
        public decimal BUYUP_MAX_AMT { get; set; }

        [Key]
        [Column(Order = 27, TypeName = "numeric")]
        public decimal CAB_LENDER_ANNUAL_INTEREST_PCT { get; set; }

        [Key]
        [Column(Order = 28, TypeName = "smallmoney")]
        public decimal CAB_LENDER_RI_FEE_PER_DEFAULT { get; set; }

        [Key]
        [Column(Order = 29)]
        public byte CAB_LENDER_RI_FEES_PER_LOAN { get; set; }

        [Key]
        [Column(Order = 30, TypeName = "smallmoney")]
        public decimal CAB_LENDER_RI_FEE_MIN { get; set; }

        [Key]
        [Column(Order = 31)]
        public byte CAB_LENDER_FI_FEE_PCT { get; set; }

        [Key]
        [Column(Order = 32)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short CHECK_DEPOSIT_DAYS { get; set; }

        [Key]
        [Column(Order = 33)]
        public byte COOLING_OFF_DAYS { get; set; }

        [Key]
        [Column(Order = 34)]
        public byte COOLING_OFF_REQ_TILL_PAYOFF_DAY { get; set; }

        [Key]
        [Column(Order = 35)]
        public bool COOLING_OFF_ENABLED { get; set; }

        [Key]
        [Column(Order = 36)]
        public bool COOLING_OFF_KANSAS_ENABLED { get; set; }

        [Key]
        [Column(Order = 37)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short COOLING_OFF_KANSAS_HOURS { get; set; }

        [Key]
        [Column(Order = 38)]
        public bool COOLING_OFF_OKLAHOMA_ENABLED { get; set; }

        [Key]
        [Column(Order = 39)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short COOLING_OFF_OKLAHOMA_DAYS_AFTER { get; set; }

        [Key]
        [Column(Order = 40)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short COOLING_OFF_OKLAHOMA_PTP_DAYS_AFTER { get; set; }

        [Key]
        [Column(Order = 41)]
        public byte COOLING_OFF_OREGON_DAYS_AFTER { get; set; }

        [Key]
        [Column(Order = 42)]
        public byte COOLING_OFF_OREGON_DAYS_BEFORE { get; set; }

        [Key]
        [Column(Order = 43)]
        public byte CUSTOMER_MIN_AGE { get; set; }

        [Key]
        [Column(Order = 44)]
        public bool CUT_RATE_IS_ENABLED { get; set; }

        [Key]
        [Column(Order = 45)]
        public byte CUT_RATE_MIN_NUM_DAYS_BETWEEN_LOANS { get; set; }

        [Key]
        [Column(Order = 46)]
        public byte CUT_RATE_NUM_SPAY_LOANS { get; set; }

        [Key]
        [Column(Order = 47)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short CUT_RATE_ON_LOANS_WITHIN_DAYS { get; set; }

        [Key]
        [Column(Order = 48)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short CUT_RATE_WITHIN_DAYS { get; set; }

        [Key]
        [Column(Order = 49)]
        public byte DAYS_CASH_ONLY_PAYOFF { get; set; }

        [Key]
        [Column(Order = 50)]
        public bool DEPOSIT_METHOD_AUTO_PAY_ENABLED { get; set; }

        [Key]
        [Column(Order = 51)]
        public byte DEPOSIT_METHOD_AUTO_PAY_ORDER { get; set; }

        [Key]
        [Column(Order = 52, TypeName = "smallmoney")]
        public decimal DEPOSIT_METHOD_AUTO_PAYOFF_THRESHOLD_AMT { get; set; }

        [Key]
        [Column(Order = 53)]
        public bool DEPOSIT_METHOD_CHECKS_ENABLED { get; set; }

        [Key]
        [Column(Order = 54)]
        public byte DEPOSIT_METHOD_CHECKS_ORDER { get; set; }

        [Key]
        [Column(Order = 55)]
        public bool DEPOSIT_METHOD_DEBIT_CARD_WITH_CHECKS_ENABLED { get; set; }

        [Key]
        [Column(Order = 56)]
        public bool DEPOSIT_METHOD_EXCLUDE_DCARD_FROM_MIDDAY_ENABLED { get; set; }

        [Key]
        [Column(Order = 57)]
        public bool DEPOSIT_METHOD_ACH_DAY_AFTER_DUE_DATE_ENABLED { get; set; }

        [Key]
        [Column(Order = 58)]
        public bool DISCOUNTS_ENABLED { get; set; }

        [Key]
        [Column(Order = 59)]
        public bool DISCOUNTS_AFFECT_CASH_ENABLED { get; set; }

        [Key]
        [Column(Order = 60)]
        public bool DUE_DATE_CHANGE_ENABLED { get; set; }

        [Key]
        [Column(Order = 61)]
        public byte DUE_DATE_MAX_EXT_DAYS { get; set; }

        [Key]
        [Column(Order = 62)]
        public byte DUE_DATE_MAX_EXT_BEYOND_DAYS { get; set; }

        [Key]
        [Column(Order = 63)]
        public bool DUE_DATE_CALC_PRIOR_TO_PAYDATE { get; set; }

        [Key]
        [Column(Order = 64)]
        public byte DUE_DATE_ADJUST_FOR_HOLIDAYS_AND_WEEKENDS_METHOD { get; set; }

        [Key]
        [Column(Order = 65)]
        public byte DUE_DATE_MIN_DAYS_BEFORE_CHANGE { get; set; }

        [Key]
        [Column(Order = 66)]
        public byte EASYPAY_ITEMS_PER_LOAN { get; set; }

        [Key]
        [Column(Order = 67)]
        public bool ENABLE_BC_PPLAN { get; set; }

        [Key]
        [Column(Order = 68)]
        public bool ENABLE_COLORADO_MAINT_FEES { get; set; }

        [Key]
        [Column(Order = 69)]
        public bool ENABLE_DECLINED_AUTO_PAY_CHG_CHK_ACCT { get; set; }

        [Key]
        [Column(Order = 70)]
        public bool ENABLE_DECLINED_AUTO_PAY_NEW_LOAN { get; set; }

        [Key]
        [Column(Order = 71)]
        public bool ENABLE_DEFAULT_DATE { get; set; }

        [Key]
        [Column(Order = 72)]
        public bool ENABLE_JOINT_LOANS { get; set; }

        [Key]
        [Column(Order = 73)]
        public bool ENABLE_MAX_LOAN_AMT_OVERRIDE_ON_BUYUP { get; set; }

        [Key]
        [Column(Order = 74)]
        public bool ENABLE_MIDDAY_EXCLUDE_TODAY { get; set; }

        [Key]
        [Column(Order = 75)]
        public bool ENABLE_NEW_LOAN_DUAL_AUTH_WITHOUT_BANKACCT { get; set; }

        [Key]
        [Column(Order = 76)]
        public bool ENABLE_NEW_LOAN_DUAL_AUTH_WITHOUT_CCARD { get; set; }

        [Key]
        [Column(Order = 77)]
        public bool ENABLE_PARTIAL_PAYMENT { get; set; }

        [Key]
        [Column(Order = 78)]
        public bool ENABLE_PAY_IN_FULL { get; set; }

        [Key]
        [Column(Order = 79)]
        public bool ENABLE_PPLAN { get; set; }

        [Key]
        [Column(Order = 80)]
        public bool ENABLE_PROMPT_FOR_CHECK_AMT { get; set; }

        [Key]
        [Column(Order = 81)]
        public bool ENABLE_SPANISH_DOCS { get; set; }

        [Key]
        [Column(Order = 82)]
        public bool ENABLE_STATE_LOAN_TERM { get; set; }

        [Key]
        [Column(Order = 83)]
        public bool ENABLE_STORE_FUND_ACCOUNT_VALIDATION_PROMPT { get; set; }

        [Key]
        [Column(Order = 84)]
        public bool ENABLE_STORE_FUND_LOAN { get; set; }

        [Key]
        [Column(Order = 85, TypeName = "smallmoney")]
        public decimal FASTER_PAYMENTS_FEE_AMT { get; set; }

        [Key]
        [Column(Order = 86)]
        public bool FEES_AND_INTEREST_CAP_AFFORDABILITY_ENABLED { get; set; }

        [Key]
        [Column(Order = 87)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short FEES_AND_INTEREST_CAP_AFFORDABILITY_DISPOSABLE_INCOME_PCT_MULTIPLIER { get; set; }

        [Key]
        [Column(Order = 88)]
        public bool FEES_AND_INTEREST_CAP_ENABLED { get; set; }

        [Key]
        [Column(Order = 89)]
        public bool FEES_AND_INTEREST_CAP_INCLUDE_FEES { get; set; }

        [Key]
        [Column(Order = 90)]
        public bool FEES_AND_INTEREST_CAP_INCLUDE_INTEREST { get; set; }

        [Key]
        [Column(Order = 91)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short FEES_AND_INTEREST_CAP_PCT { get; set; }

        [Key]
        [Column(Order = 92)]
        public bool FUND_USING_FED_SCHEDULE_ENABLED { get; set; }

        [Key]
        [Column(Order = 93)]
        public bool GOVT_ID_REQUIRED_ENABLED { get; set; }

        [Key]
        [Column(Order = 94)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short INDEBTEDNESS_MAX_DAYS { get; set; }

        [Key]
        [Column(Order = 95)]
        public bool INTEREST_ANNUAL_RATE_USE_TABLE_ENABLED { get; set; }

        [Key]
        [Column(Order = 96, TypeName = "numeric")]
        public decimal INTEREST_ANNUAL_RATE_PCT { get; set; }

        [Key]
        [Column(Order = 97)]
        public bool INTEREST_RATE_CALC_INCLUDES_FEE_ENABLED { get; set; }

        [Key]
        [Column(Order = 98)]
        public decimal INTEREST_ANNUAL_RATE_DEBIT_RATE_PCT { get; set; }

        [Key]
        [Column(Order = 99, TypeName = "numeric")]
        public decimal INTEREST_DECLINED_AUTO_PAY_PCT { get; set; }

        [Key]
        [Column(Order = 100)]
        public bool INTEREST_BASED_ON_PAST_DUE_ENABLED { get; set; }

        [Key]
        [Column(Order = 101)]
        public bool INTEREST_CHARGED_AFTER_MATURITY_ENABLED { get; set; }

        [Key]
        [Column(Order = 102)]
        public bool INTEREST_AMORT_TABLE_CAP_ENABLED { get; set; }

        [Key]
        [Column(Order = 103)]
        public bool INTEREST_USE_LOWEST_RATE_FROM_NEW_OR_OPEN_ENABLED { get; set; }

        [Key]
        [Column(Order = 104)]
        public bool INTEREST_MIN_ENABLED { get; set; }

        [Key]
        [Column(Order = 105)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short INTEREST_MIN_DAYS { get; set; }

        [Key]
        [Column(Order = 106, TypeName = "numeric")]
        public decimal INTEREST_MIN_ANNUAL_RATE_OVERRIDE_PCT { get; set; }

        [Key]
        [Column(Order = 107)]
        public bool INTEREST_RATE_NEGOTIATION_ENABLED { get; set; }

        [Key]
        [Column(Order = 108)]
        public bool INTEREST_RATE_OVERRIDE_ENABLED { get; set; }

        [Key]
        [Column(Order = 109)]
        public byte LIMIT_NEW_LOAN_DAYS_AFTER_PAYOFF { get; set; }

        [Key]
        [Column(Order = 110)]
        public byte LIMIT_NEW_LOAN_DAYS_NEXT_LOAN { get; set; }

        [Key]
        [Column(Order = 111)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LOAN_CONFIG_APPLY_PAYMENT_ORDER_KEY { get; set; }

        [Key]
        [Column(Order = 112, TypeName = "smallmoney")]
        public decimal LOAN_AMT_DEFAULT_AMT { get; set; }

        [Key]
        [Column(Order = 113, TypeName = "smallmoney")]
        public decimal LOAN_AMT_MAX_AMT { get; set; }

        [Key]
        [Column(Order = 114, TypeName = "smallmoney")]
        public decimal LOAN_AMT_MAX_MULTI_AMT { get; set; }

        [Key]
        [Column(Order = 115, TypeName = "smallmoney")]
        public decimal LOAN_AMT_MIN_AMT { get; set; }

        [Key]
        [Column(Order = 116, TypeName = "smallmoney")]
        public decimal LOAN_AMT_MGR_OVERRIDE_AMT { get; set; }

        [Key]
        [Column(Order = 117)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LOAN_AMT_MGR_OVERRIDE_PCT { get; set; }

        [Key]
        [Column(Order = 118)]
        public bool LOAN_AMT_MAX_INCLUDES_FEE_ENABLED { get; set; }

        [Key]
        [Column(Order = 119)]
        public bool LOAN_AMT_MAX_INCLUDES_OPEN_PRINC_SUBSEQUENT_LOANS { get; set; }

        [Key]
        [Column(Order = 120)]
        public bool LOAN_AMT_MAX_ALLOW_OVERRIDE_LOAN_AMT_WITH_FEES { get; set; }

        [Key]
        [Column(Order = 121)]
        public bool LOAN_AMT_PRIOR_AMT_CAP_ENABLED { get; set; }

        [Key]
        [Column(Order = 122)]
        public bool LOAN_FEE_USE_TABLE_ENABLED { get; set; }

        [Key]
        [Column(Order = 123, TypeName = "numeric")]
        public decimal LOAN_FEE_PCT { get; set; }

        [Key]
        [Column(Order = 124, TypeName = "smallmoney")]
        public decimal LOAN_FEE_MAX_AMT { get; set; }

        [Key]
        [Column(Order = 125)]
        public bool LOAN_FEE_TRUNCATE_ENABLED { get; set; }

        [Key]
        [Column(Order = 126, TypeName = "numeric")]
        public decimal LOAN_FEE_MIN_TO_OVERRIDE_PCT { get; set; }

        [Key]
        [Column(Order = 127)]
        public byte LOAN_FEE_WAIVE_ON_BUYUP_WITHIN_DAYS { get; set; }

        [Key]
        [Column(Order = 128)]
        public bool LOAN_FEE_BASED_ON_LENGTH_ENABLED { get; set; }

        [Key]
        [Column(Order = 129)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short LOAN_LENGTH_MIN_DAYS { get; set; }

        [Key]
        [Column(Order = 130)]
        public byte LOAN_LENGTH_MIN_DAYS_CHECKS_MONTHLY { get; set; }

        [Key]
        [Column(Order = 131)]
        public byte LOAN_LENGTH_MIN_DAYS_CHECKS_NON_MONTHLY { get; set; }

        [Key]
        [Column(Order = 132)]
        public byte LOAN_LENGTH_MIN_DAYS_DEBIT_CARDS_MONTHLY { get; set; }

        [Key]
        [Column(Order = 133)]
        public byte LOAN_LENGTH_MIN_DAYS_DEBIT_CARDS_NON_MONTHLY { get; set; }

        [Key]
        [Column(Order = 134)]
        public byte LOAN_LENGTH_MIN_MONTHS { get; set; }

        [Key]
        [Column(Order = 135)]
        public byte LOAN_LENGTH_MIN_PAYMENTS { get; set; }

        [Key]
        [Column(Order = 136)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short LOAN_LENGTH_MAX_DAYS { get; set; }

        [Key]
        [Column(Order = 137)]
        public byte LOAN_LENGTH_MAX_DAYS_MONTHLY { get; set; }

        [Key]
        [Column(Order = 138)]
        public byte LOAN_LENGTH_MAX_DAYS_NON_MONTHLY { get; set; }

        [Key]
        [Column(Order = 139)]
        public byte LOAN_LENGTH_MAX_DAYS_EXT_BEYOND_MAX_SYSTEM { get; set; }

        [Key]
        [Column(Order = 140)]
        public byte LOAN_LENGTH_MAX_SERIES_DAYS { get; set; }

        [Key]
        [Column(Order = 141)]
        public byte LOAN_LENGTH_MAX_ROLL_DAYS { get; set; }

        [Key]
        [Column(Order = 142)]
        [StringLength(1)]
        public string LOAN_LENGTH_MAX_ROLL_DAYS_TYPE { get; set; }

        [Key]
        [Column(Order = 143)]
        public byte LOAN_LENGTH_MAX_MONTHS { get; set; }

        [Key]
        [Column(Order = 144)]
        public byte LOAN_LENGTH_MAX_PAYMENTS { get; set; }

        [Key]
        [Column(Order = 145)]
        public byte LOAN_LENGTH_DEFAULT_DAYS { get; set; }

        [Key]
        [Column(Order = 146)]
        public byte LOAN_LENGTH_DEFAULT_MONTHS { get; set; }

        [Key]
        [Column(Order = 147)]
        public bool LOAN_LENGTH_DEFAULT_IS_CEILING { get; set; }

        [Key]
        [Column(Order = 148)]
        public bool LOAN_LENGTH_DEFAULT_IS_FLOOR { get; set; }

        [Key]
        [Column(Order = 149)]
        public byte LOAN_LENGTH_DEFAULT_PAYMENTS { get; set; }

        [Key]
        [Column(Order = 150)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short LOAN_LENGTH_EFFECTIVE_DAYS { get; set; }

        [Key]
        [Column(Order = 151)]
        public bool LOAN_LENGTH_EFFECTIVE_DATE_ENABLED { get; set; }

        [Key]
        [Column(Order = 152)]
        public bool LOAN_LENGTH_CHANGE_ENABLED { get; set; }

        [Key]
        [Column(Order = 153)]
        public bool LOAN_QUAL_ENABLED { get; set; }

        [Key]
        [Column(Order = 154)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short LOAN_QUAL_VERIFY_DAYS_FROM_LAST_LOAN { get; set; }

        [Key]
        [Column(Order = 155)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short LOAN_QUAL_VERIFY_BANK_ACCT_AFTER_DAYS { get; set; }

        [Key]
        [Column(Order = 156, TypeName = "smallmoney")]
        public decimal LOAN_QUAL_INCREASE_FOR_DIRECT_DEPOSIT_AMT { get; set; }

        [Key]
        [Column(Order = 157, TypeName = "smallmoney")]
        public decimal LOAN_QUAL_INCREASE_FOR_SUCCESSFUL_LOANS_AMT { get; set; }

        [Key]
        [Column(Order = 158, TypeName = "smallmoney")]
        public decimal LOAN_QUAL_INCREASE_FOR_VALID_DEBIT_CARD_AMT { get; set; }

        [Key]
        [Column(Order = 159)]
        public byte LOAN_QUAL_INCREASE_SUCCESSFUL_LOANS_COUNT { get; set; }

        [Key]
        [Column(Order = 160)]
        public byte MAX_LOANS_PER_YEAR { get; set; }

        [Key]
        [Column(Order = 161)]
        public byte MAX_LOANS_PER_DAY { get; set; }

        [Key]
        [Column(Order = 162)]
        public bool MAX_LOANS_INCLUDE_ROLLOVER_ENABLED { get; set; }

        [Key]
        [Column(Order = 163)]
        public byte MAX_OPEN_LOANS_COUNT { get; set; }

        [Key]
        [Column(Order = 164)]
        public bool MAX_LOANS_COUNT_SPOUSE_OPEN_LOANS_ENABLED { get; set; }

        [Key]
        [Column(Order = 165)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short MAX_COLLECTION_DAYS_TO_ALLOW_ROLLOVER { get; set; }

        [Key]
        [Column(Order = 166)]
        public bool MAX_MULTI_AMT_EXCLUDE_FEE_ON_NEW_LOAN_ENABLED { get; set; }

        [Key]
        [Column(Order = 167)]
        [StringLength(1)]
        public string MAX_PAYMENT_GROSS_OR_NET { get; set; }

        [Key]
        [Column(Order = 168)]
        [StringLength(1)]
        public string MAX_PAYMENT_GROSS_OR_NET_ALL_OPEN_LOANS { get; set; }

        [Key]
        [Column(Order = 169)]
        public bool MAX_PAYMENT_PCT_OF_INCOME_ENABLED { get; set; }

        [Key]
        [Column(Order = 170)]
        public decimal MAX_PAYMENT_PCT_OF_INCOME { get; set; }

        [Key]
        [Column(Order = 171)]
        public bool MAX_PAYMENT_PCT_OF_INCOME_ALL_OPEN_LOANS_ENABLED { get; set; }

        [Key]
        [Column(Order = 172)]
        public decimal MAX_PAYMENT_PCT_OF_INCOME_ALL_OPEN_LOANS { get; set; }

        [Key]
        [Column(Order = 173)]
        public bool MAX_PAYMENT_INCLUDE_OPEN_LOANS_ENABLED { get; set; }

        [Key]
        [Column(Order = 174)]
        public bool MAX_PAYMENT_SUM_PAYMENTS_PER_MONTH_ENABLED { get; set; }

        [Key]
        [Column(Order = 175)]
        public bool MAX_PAYMENT_DEDUCT_MORTGAGE_FROM_INCOME_ENABLED { get; set; }

        [Key]
        [Column(Order = 176)]
        public bool MONTHLY_CUST_USE_NONMONTHY_MAX_DAYS_ENABLED { get; set; }

        [Key]
        [Column(Order = 177)]
        public byte NEXT_NEW_LOAN_ORIGINATION_FEE_GRACE_PERIOD_DAYS { get; set; }

        [Key]
        [Column(Order = 178)]
        public bool NO_OVERRIDE_OPEN_LOAN_ENABLED { get; set; }

        [Key]
        [Column(Order = 179)]
        public decimal OVERRIDE_PCT_AMT_OF_INCOME { get; set; }

        [Key]
        [Column(Order = 180)]
        [StringLength(1)]
        public string OVERRIDE_PCT_INCOME_GROSS_OR_NET { get; set; }

        [Key]
        [Column(Order = 181)]
        public byte PAYMENT_SCHED_WEEKS { get; set; }

        [Key]
        [Column(Order = 182)]
        public bool PAYMENT_SCHED_DUE_DATE_MATCH_ENABLED { get; set; }

        [Key]
        [Column(Order = 183)]
        public byte PAYMENT_SCHED_DUE_CYCLE_CHANGES_PER_LOAN_SERIES { get; set; }

        [Key]
        [Column(Order = 184)]
        public bool PAYMENT_SCHED_SELECT_PAY_CYCLE_ENABLED { get; set; }

        [Key]
        [Column(Order = 185)]
        public byte PAYMENT_SCHED_USE_NEXT_PAYDATE_WITHIN_DAYS_BIWEEKLY { get; set; }

        [Key]
        [Column(Order = 186)]
        public byte PAYMENT_SCHED_USE_NEXT_PAYDATE_WITHIN_DAYS_MONTHLY { get; set; }

        [Key]
        [Column(Order = 187)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short PAYMENT_BLACKOUT_HOURS { get; set; }

        [Key]
        [Column(Order = 188)]
        public bool PRINC_AMT_MATCH_RATE_TABLE { get; set; }

        [Key]
        [Column(Order = 189)]
        public byte REBATE_LIMIT_PCT { get; set; }

        [Key]
        [Column(Order = 190)]
        public byte REBATE_GRACE_PERIOD_DAYS { get; set; }

        [Key]
        [Column(Order = 191)]
        public bool REBATE_COLORADO_EARLY_PAYOFF_ENABLED { get; set; }

        [Key]
        [Column(Order = 192)]
        public bool REBATE_ANNUAL_INTEREST_ENABLED { get; set; }

        [Key]
        [Column(Order = 193)]
        public bool REBATE_GRACE_PERIOD_ORIG_FEE_ENABLED { get; set; }

        [Key]
        [Column(Order = 194)]
        public bool REBATE_ON_ROLLOVER_ENABLED { get; set; }

        [Key]
        [Column(Order = 195)]
        public bool REBATE_ORIG_FEE_ENABLED { get; set; }

        [Key]
        [Column(Order = 196)]
        public byte REBATE_MAX_DAYS_TO_PAY_AFTER_WITHDRAW { get; set; }

        [Key]
        [Column(Order = 197)]
        public bool REDUCE_APPROVAL_ENABLED { get; set; }

        [Key]
        [Column(Order = 198)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short REDUCE_APPROVAL_WHEN_LESS_THAN_AMT { get; set; }

        [Key]
        [Column(Order = 199)]
        public byte REDUCE_APPROVAL_WHEN_LESS_THAN_PCT { get; set; }

        [Key]
        [Column(Order = 200)]
        [StringLength(1)]
        public string REDUCE_APPROVAL_GROSS_OR_NET_INCOME { get; set; }

        [Key]
        [Column(Order = 201)]
        public byte REDUCE_APPROVAL_INCOME_PERCENT_MULTIPLIER { get; set; }

        [Key]
        [Column(Order = 202)]
        public bool REQUIRE_DEBIT_CARD { get; set; }

        [Key]
        [Column(Order = 203)]
        public bool REQUIRE_NOTIFY_SPOUSE_BY_MAIL { get; set; }

        [Key]
        [Column(Order = 204)]
        public bool REQUIRE_VERBAL_REVIEW { get; set; }

        [Key]
        [Column(Order = 205)]
        public byte RI_CYCLES_PAST_DUE_CALC_TYPE { get; set; }

        [Key]
        [Column(Order = 206, TypeName = "smallmoney")]
        public decimal RI_FEE_PER_DEFAULT_AMT { get; set; }

        [Key]
        [Column(Order = 207)]
        public byte RI_FEE_PER_DEFAULT_PCT { get; set; }

        [Key]
        [Column(Order = 208, TypeName = "smallmoney")]
        public decimal RI_FEE_MIN_AMT { get; set; }

        [Key]
        [Column(Order = 209)]
        public byte RI_FEE_MAX_PER_LOAN_COUNT { get; set; }

        [Key]
        [Column(Order = 210, TypeName = "smallmoney")]
        public decimal RI_FEE_MAX_PER_LOAN_AMT { get; set; }

        [Key]
        [Column(Order = 211)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short RI_FEE_MAX_PER_LOAN_SERIES_AMT { get; set; }

        [Key]
        [Column(Order = 212)]
        public bool RI_FEE_NO_FEE_3RD_ROLL_ENABLED { get; set; }

        [Key]
        [Column(Order = 213)]
        public bool RI_FEE_NO_FEE_OPEN_RI_ENABLED { get; set; }

        [Key]
        [Column(Order = 214)]
        public bool RI_FEE_NO_FEE_STOP_PAY_ENABLED { get; set; }

        [Key]
        [Column(Order = 215, TypeName = "smallmoney")]
        public decimal RI_FEE_CHARGE_FOR_DEBIT_CARD_AMT { get; set; }

        [Key]
        [Column(Order = 216)]
        public byte RI_FEE_ASSESS_ON_DAY { get; set; }

        [Key]
        [Column(Order = 217)]
        public bool RI_FEE_REQUIRES_BANK_ACCOUNT { get; set; }

        [Key]
        [Column(Order = 218)]
        public byte RI_FEE_WAIVE_PCT { get; set; }

        [Key]
        [Column(Order = 219)]
        public bool RI_INTEREST_ENABLED { get; set; }

        [Key]
        [Column(Order = 220, TypeName = "numeric")]
        public decimal RI_INTEREST_ANNUAL_RATE_PCT { get; set; }

        [Key]
        [Column(Order = 221, TypeName = "smallmoney")]
        public decimal RI_INTEREST_MAX_LIMIT_AMT { get; set; }

        [Key]
        [Column(Order = 222, TypeName = "smallmoney")]
        public decimal RI_INTEREST_MIN_LIMIT_AMT { get; set; }

        [Key]
        [Column(Order = 223)]
        public bool RI_INTEREST_USE_RATE_TABLE { get; set; }

        [Key]
        [Column(Order = 224)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short RI_INTEREST_DAYS { get; set; }

        [Key]
        [Column(Order = 225)]
        public byte ROLLOVER_MAX_COUNT { get; set; }

        [Key]
        [Column(Order = 226)]
        public byte ROLLOVER_MAX_SCHEDULED_COUNT { get; set; }

        [Key]
        [Column(Order = 227)]
        public bool ROLLOVER_OUT_COLL_ENABLED { get; set; }

        [Key]
        [Column(Order = 228)]
        public bool ROLLOVER_OUT_COLL_RESETS_NUM { get; set; }

        [Key]
        [Column(Order = 229)]
        public bool SAME_DAY_PAYOFF_AND_NEW_IS_ROLL_ENABLED { get; set; }

        [Key]
        [Column(Order = 230)]
        public byte SET_INACTIVE_ON_DAY { get; set; }

        [Key]
        [Column(Order = 231)]
        public byte SET_INACTIVE_ON_DAY_AFTER_MISSED_PAYMENT_COUNT { get; set; }

        [Key]
        [Column(Order = 232)]
        public byte SET_INACTIVE_ON_DAY_AFTER_NOTICE { get; set; }

        [Key]
        [Column(Order = 233)]
        public byte SET_INACTIVE_ON_MISSED_PAYMENT_COUNT { get; set; }

        [Key]
        [Column(Order = 234)]
        public bool SCORING_ENABLED { get; set; }

        [Key]
        [Column(Order = 235)]
        public bool SCORING_EVERY_CUSTOMER_LOAN_ENABLED { get; set; }

        [Key]
        [Column(Order = 236)]
        public bool SCORING_SNAPSHOTS_ENABLED { get; set; }

        [Key]
        [Column(Order = 237)]
        public bool SCORING_DATA_PULL_ENABLED { get; set; }

        [Column(TypeName = "date")]
        public DateTime? SCORING_START_DATE { get; set; }

        [Key]
        [Column(Order = 238)]
        public decimal SCORING_APPROVAL_POINTS { get; set; }

        [Key]
        [Column(Order = 239)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short SCORING_INCREASE_MIN_SCORE { get; set; }

        [Key]
        [Column(Order = 240)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short SCORING_INCREASE_MAX_SCORE { get; set; }

        [Key]
        [Column(Order = 241, TypeName = "smallmoney")]
        public decimal SCORING_INCREASE_AMT { get; set; }

        [Key]
        [Column(Order = 242)]
        public byte SCORING_INCREASE_MAX_PCT { get; set; }

        [Key]
        [Column(Order = 243)]
        [StringLength(1)]
        public string SCORING_BUMP_UPS_BASED_ON_INCOME_TYPE { get; set; }

        [Key]
        [Column(Order = 244)]
        public bool SCORING_DENIAL_OVERRIDE_ENABLED { get; set; }

        [Key]
        [Column(Order = 245)]
        public bool SCORING_OVERRIDE_ENABLED { get; set; }

        [Key]
        [Column(Order = 246)]
        public decimal SCORING_OVERRIDE_AMT { get; set; }

        [Key]
        [Column(Order = 247)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short SCORING_OVERRIDE_PCT { get; set; }

        [Key]
        [Column(Order = 248)]
        public byte SCORING_OVERRIDE_TYPE { get; set; }

        [Key]
        [Column(Order = 249)]
        public bool SCORING_INCREASE_RI_RESTART { get; set; }

        [Key]
        [Column(Order = 250)]
        public bool SCORING_MGR_OVERRIDE_LOAN_AMT_ENABLED { get; set; }

        [Key]
        [Column(Order = 251)]
        public byte SCORING_INCREASE_MIN_DAYS { get; set; }

        [Key]
        [Column(Order = 252)]
        public byte SCORING_INCREASE_NUM_SUCCESSFUL_PAYMENTS { get; set; }

        [Key]
        [Column(Order = 253)]
        public bool SCORING_TALKOFF_ENABLED { get; set; }

        [Key]
        [Column(Order = 254)]
        public bool SPLIT_FEE_ENABLED { get; set; }

        [Key]
        [Column(Order = 255, TypeName = "smallmoney")]
        public decimal SPLIT_FEE_AT_AMOUNT { get; set; }

        [Key]
        [Column(Order = 256)]
        public decimal SPLIT_FEE_ABOVE_PCT { get; set; }

        [Key]
        [Column(Order = 257)]
        public bool SSN_REQUIRED_FOR_LOAN_ENABLED { get; set; }

        [Key]
        [Column(Order = 258)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short STATE_REQ_WAIT_DAYS { get; set; }

        [Key]
        [Column(Order = 259)]
        public bool WITHDRAW_ENABLED { get; set; }

        [Key]
        [Column(Order = 260)]
        public byte WITHDRAW_MAX_DAYS { get; set; }

        [Key]
        [Column(Order = 261)]
        public byte WITHDRAW_MAX_DAYS_TO_PAY_AFTER { get; set; }

        [Key]
        [Column(Order = 262)]
        [StringLength(1)]
        public string WITHDRAW_DATE_METHOD { get; set; }

        [Key]
        [Column(Order = 263)]
        public byte PAYMENT_SCHED_AMORT_METHOD { get; set; }

        [Key]
        [Column(Order = 264)]
        public bool PENDING_PAYMENTS_AS_UNPAID_FOR_NEW_LOAN { get; set; }

        [Key]
        [Column(Order = 265, TypeName = "smallmoney")]
        public decimal LOAN_FEE_MIN_AMT { get; set; }

        [Key]
        [Column(Order = 266, TypeName = "smallmoney")]
        public decimal LOAN_FEE_AMT_1 { get; set; }

        [Key]
        [Column(Order = 267, TypeName = "smallmoney")]
        public decimal LOAN_FEE_AMT_2 { get; set; }

        [Key]
        [Column(Order = 268)]
        [StringLength(1)]
        public string LOAN_FEE_METHOD { get; set; }

        [Key]
        [Column(Order = 269, TypeName = "smallmoney")]
        public decimal LOAN_FEE_FOR_ROLLOVER_AMT { get; set; }

        [Key]
        [Column(Order = 270, TypeName = "smallmoney")]
        public decimal LOAN_FEE_INCL_DOC_PREP_FEE_AMT { get; set; }

        [Key]
        [Column(Order = 271)]
        public bool LOAN_AMT_MAX_PREVIOUS_AMT_ANY_PRODUCT { get; set; }

        [Key]
        [Column(Order = 272)]
        public bool MAX_APPROVAL_PCT_OF_INCOME_ENABLED { get; set; }

        [Key]
        [Column(Order = 273)]
        [StringLength(1)]
        public string MAX_APPROVAL_PCT_OF_INCOME_GROSS_OR_NET { get; set; }

        [Key]
        [Column(Order = 274)]
        public decimal MAX_APPROVAL_PCT_OF_INCOME { get; set; }

        [Key]
        [Column(Order = 275)]
        public bool MAX_APPROVAL_PCT_OF_INCOME_INCLUDE_OPEN_LOANS_ENABLED { get; set; }

        [Key]
        [Column(Order = 276)]
        public decimal MAX_OPEN_LOANS_PCT_OF_INCOME { get; set; }

        [Key]
        [Column(Order = 277)]
        [StringLength(1)]
        public string MAX_OPEN_LOANS_PCT_OF_INCOME_GROSS_OR_NET { get; set; }

        [Key]
        [Column(Order = 278)]
        public bool DEPOSIT_METHOD_AUTO_PAY_CALC_ORDER_ENABLED { get; set; }

        public int? DEPOSIT_METHOD_AUTO_PAY_CALC_ORDER_RULE_DEF_SET_KEY { get; set; }

        [Key]
        [Column(Order = 279)]
        public byte RI_GRACE_PERIOD_DAYS_PROTECTED_AUDIT_CAT { get; set; }

        [Key]
        [Column(Order = 280)]
        public byte RI_GRACE_PERIOD_DAYS_NON_PROTECTED_AUDIT_CAT { get; set; }

        [Key]
        [Column(Order = 281)]
        public bool RI_FEE_EXCLUDE_PROTECTED_AUDIT_CAT_ENABLED { get; set; }

        [Key]
        [Column(Order = 282, TypeName = "smallmoney")]
        public decimal LOAN_AMT_MGR_OVERRIDE_MIN_AMT { get; set; }

        [Key]
        [Column(Order = 283)]
        public bool PAYMENT_SCHED_USE_CUSTOMER_PAY_CYCLE { get; set; }

        [Key]
        [Column(Order = 284)]
        [StringLength(7)]
        public string XLPCOE { get; set; }

        public int? LOAN_PRODUCT_CONFIG_OPEN_END_KEY { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? ACTIVITY_FEE_AMT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ACTIVITY_FEE_PCT { get; set; }

        public byte? CAB_DEFAULT_LOAN_LENGTH { get; set; }

        public byte? CAB_FEE_DAY_OFFSET { get; set; }

        public bool? CASH_ADVANCE_DISABLED { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? CASH_ADVANCE_LIMIT_AMT { get; set; }

        public bool? CASH_ADVANCE_LIMIT_ENABLED { get; set; }

        public short? CLOSE_WHEN_INACTIVE_DAYS { get; set; }

        public bool? CLOSE_WHEN_PAID_OFF { get; set; }

        public byte? COOLING_DAYS_AFTER_FINAL_ROLLOVER { get; set; }

        public byte? COOLING_DAYS_CASH_ADVANCE_AFTER_PAYMENT { get; set; }

        public byte? CYCLE_DAYS { get; set; }

        public bool? FLAT_FEE_BIWEEKLY_RATES_ENABLED { get; set; }

        public bool? FLAT_FEE_RULES_ENABLED { get; set; }

        public bool? GIFT_CARD_PROCEEDS_ENABLED { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ENFORCE_ROLLOVER_RESTRICTIONS_AS_OF_DATE { get; set; }

        public bool? IS_ORDINANCE_LOCATION { get; set; }

        public bool? LIMIT_ZERO_BALANCE_STATEMENTS { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? MIN_PRINC_DUE_FOUR_WEEKS_AMT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MIN_PRINC_DUE_FOUR_WEEKS_PCT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? MIN_PRINC_DUE_TWO_WEEKS_AMT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MIN_PRINC_DUE_TWO_WEEKS_PCT { get; set; }

        public byte? NEW_LOAN_WITHIN_CLOSING_PREVIOUS_LOAN_DAYS { get; set; }

        public bool? NEW_LOAN_WITHIN_CLOSING_PREVIOUS_LOAN_ONLY_ENABLED { get; set; }

        public short? NON_ORDINANCE_LOCATION { get; set; }

        public bool? PAY_PRINC_BEFORE_NEXT_AND_NOT_DUE { get; set; }

        public byte? PAYMENT_DUE_CYCLE_DAYS { get; set; }

        public bool? PRINC_AMT_INCREMENT_ENABLED { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? PRINC_AMT_INCREMENT_AMT { get; set; }

        public bool? STMTS_EMAIL_ENABLED { get; set; }

        public short? STMTS_GEN_CYCLE_DAYS { get; set; }

        [Key]
        [Column(Order = 285)]
        [StringLength(6)]
        public string XLPCT { get; set; }

        public int? LOAN_PRODUCT_CONFIG_TITLE_KEY { get; set; }

        public decimal? APPROVAL_PCT_EMPLOYED_24_PLUS_MONTHS { get; set; }

        public decimal? APPROVAL_PCT_EMPLOYED_6_TO_23_MONTHS { get; set; }

        public decimal? APPROVAL_PCT_EMPLOYED_UP_TO_5_MONTHS { get; set; }

        public decimal? APPROVAL_PCT_WHOLESALE_GREATER_THAN_1500_CHECKING_ACCT { get; set; }

        public decimal? APPROVAL_PCT_WHOLESALE_GREATER_THAN_1500_CHECKING_ACCT_DIRECT_DEPOSIT { get; set; }

        public decimal? APPROVAL_PCT_WHOLESALE_GREATER_THAN_1500_DEBIT_CARD { get; set; }

        public decimal? APPROVAL_PCT_WHOLESALE_UP_TO_1500_CHECKING_ACCT { get; set; }

        public decimal? APPROVAL_PCT_WHOLESALE_UP_TO_1500_CHECKING_ACCT_DIRECT_DEPOSIT { get; set; }

        public decimal? APPROVAL_PCT_WHOLESALE_UP_TO_1500_DEBIT_CARD { get; set; }

        public short? LEGAL_MAX_LOAN_VEHICLE_VALUE_PCT { get; set; }

        [StringLength(1)]
        public string LEGAL_MAX_LOAN_VEHICLE_VALUE_WHOLESALE_OR_RETAIL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? LIEN_FEE_AMT { get; set; }

        public bool? LIEN_FEE_FINANCED_ENABLED { get; set; }

        public int? LOAN_AMT_MGR_OVERRIDE_VEHICLE_VALUE_PCT { get; set; }

        [StringLength(1)]
        public string LOAN_AMT_MGR_OVERRIDE_VEHICLE_WHOLESALE_OR_RETAIL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? LOAN_AMT_NO_INSURANCE_MAX_AMT { get; set; }

        public bool? MAX_LOAN_VEHICLE_VALUE_PCT_ENABLED { get; set; }

        public bool? MULT_LOANS_VIN_ENABLED { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ORIG_FEE_PCT_2ND_LIEN { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? REPO_ASSIGNMENT_MIN_BALANCE { get; set; }

        public bool? REQUIRE_COPLEDGE_DETAILS { get; set; }

        public bool? REQUIRE_COPLEDGE_EYE_COLOR { get; set; }

        public bool? REQUIRE_COPLEDGE_GENDER { get; set; }

        public bool? REQUIRE_COPLEDGE_HAIR_COLOR { get; set; }

        public bool? REQUIRE_COPLEDGE_HEIGHT { get; set; }

        public bool? REQUIRE_COPLEDGE_RACE { get; set; }

        public bool? REQUIRE_COPLEDGE_SSN { get; set; }

        public bool? REQUIRE_DETAILS { get; set; }

        public bool? REQUIRE_EYE_COLOR { get; set; }

        public bool? REQUIRE_GENDER { get; set; }

        public bool? REQUIRE_HAIR_COLOR { get; set; }

        public bool? REQUIRE_HEIGHT { get; set; }

        public bool? REQUIRE_RACE { get; set; }

        public bool? USE_FUEL_TYPE { get; set; }

        public bool? USE_LEGAL_STATUS { get; set; }

        public bool? USE_LIEN_HOLDER { get; set; }

        public bool? USE_ODO_CODE { get; set; }

        public bool? USE_REGISTRATION_DATE { get; set; }

        public bool? USE_REGISTRATION_EXPIRES { get; set; }

        public bool? USE_STATE_NUM { get; set; }

        public bool? USE_STICKER_NUM { get; set; }

        public bool? USE_TITLE_NUM { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? VEH_VALUE_MIN_AMT { get; set; }

        public byte? MAX_LOAN_VEHICLE_VALUE_PCT { get; set; }

        [StringLength(1)]
        public string MAX_LOAN_VEHICLE_VALUE_PCT_WHOLESALE_OR_RETAIL { get; set; }
    }
}
