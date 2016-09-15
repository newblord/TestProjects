namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OpenEndLoan")]
    public partial class OpenEndLoan
    {
        [Key]
        public int OPEN_END_LOAN_KEY { get; set; }

        public int LOAN_KEY { get; set; }

        public byte TRANS_FEE_PCT { get; set; }

        public byte CYCLE_DAYS { get; set; }

        public short STATEMENT_DAYS { get; set; }

        public short PAYMENT_DAYS { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal LAST_PAYMENT_AMT { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LAST_PAYMENT_DATE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal LAST_CASH_ADV_AMT { get; set; }

        public DateTime? LAST_CASH_ADV_DATE { get; set; }

        public byte LAST_STATEMENT_NUM { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LAST_STATEMENT_DATE { get; set; }

        [Column(TypeName = "date")]
        public DateTime NEXT_STATEMENT_DATE { get; set; }

        [Column(TypeName = "date")]
        public DateTime NEXT_DUE_DATE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PAST_DUE_TRANS_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PAST_DUE_LIEN_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PAST_DUE_ACTIVITY_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PAST_DUE_COLL_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PAST_DUE_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PAST_DUE_PRINC_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CURR_DUE_TRANS_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CURR_DUE_LIEN_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CURR_DUE_ACTIVITY_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CURR_DUE_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CURR_DUE_PRINC_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NEXT_DUE_TRANS_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NEXT_DUE_LIEN_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NEXT_DUE_ACTIVITY_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NEXT_DUE_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NEXT_DUE_PRINC_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NOT_DUE_TRANS_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NOT_DUE_LIEN_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NOT_DUE_ACTIVITY_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NOT_DUE_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NOT_DUE_PRINC_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CREDIT_LIMIT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CREDIT_AVAIL { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CLOSED_DATE { get; set; }

        public bool SUSPEND_INTEREST { get; set; }

        public bool EMAIL_STATEMENTS { get; set; }

        [Column(TypeName = "smallmoney")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? TRANS_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? LIEN_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? ACTIVITY_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? INTEREST_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? PRINC_FEE_AMT { get; set; }

        public bool IS_BUSINESS_LOAN { get; set; }

        public bool IS_USE_PAY_CYCLE { get; set; }

        public bool IS_GIFT_CARD_LOAN { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PENDING_SCHED_ACH_AMT { get; set; }

        public byte SELECTED_CYCLE_WEEKS { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PAST_DUE_CSO_LENDER_COLL_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PAST_DUE_CSO_LENDER_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CURR_DUE_CSO_LENDER_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NEXT_DUE_CSO_LENDER_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NOT_DUE_CSO_LENDER_INTEREST_AMT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CSO_LENDER_ANNUAL_RATE_PCT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CSO_LENDER_MONTHLY_RATE_PCT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CSO_LENDER_DAILY_RATE_PCT { get; set; }

        public byte TERM_LIMIT_DAYS { get; set; }

        [Column(TypeName = "date")]
        public DateTime? TERM_LIMIT_FINAL_STATEMENT_DATE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? TERM_LIMIT_FINAL_DUE_DATE { get; set; }

        public byte SET_INACTIVE_ON_MISSED_PAYMENT_COUNT { get; set; }

        public byte SET_INACTIVE_ON_DAY_AFTER_MISSED_PAYMENT_COUNT { get; set; }

        [Column(TypeName = "smallmoney")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? CURR_DUE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? NEXT_DUE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? NOT_DUE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PRINT_TOT_CSO_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PRINT_PAYMENT1_PRINC_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PRINT_PAYMENT2_PRINC_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PRINT_PAYMENT1_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PRINT_PAYMENT2_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PRINT_TOT_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PRINT_TOT_PAYMENTS_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? COLLECTIONS_AMT { get; set; }

        public bool DECLINED_AUTO_PAY { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PRINT_PAYMENT1_TRANS_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PRINT_PAYMENT2_TRANS_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PRINT_PAYMENT1_TOTAL_DUE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PRINT_PAYMENT2_TOTAL_DUE_AMT { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PRINT_PAYMENT1_DUEDATE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PRINT_PAYMENT2_DUEDATE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal MIN_PRINC_DUE_TWO_WEEKS_PCT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal MIN_PRINC_DUE_FOUR_WEEKS_PCT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal MIN_PRINC_DUE_TWO_WEEKS_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal MIN_PRINC_DUE_FOUR_WEEKS_AMT { get; set; }

        public byte PRINT_PAYMENT1_STATEMENT_DAYS { get; set; }

        public byte PRINT_PAYMENT2_STATEMENT_DAYS { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PRINT_CASH_ADV_PAYMENT1_TOTAL_DUE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PRINT_CASH_ADV_PAYMENT2_TOTAL_DUE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PRINT_CASH_ADV_PAYMENT1_PRINC_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PRINT_CASH_ADV_PAYMENT2_PRINC_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PRINT_CASH_ADV_PAYMENT1_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PRINT_CASH_ADV_PAYMENT2_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PRINT_CASH_ADV_TOT_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PRINT_CASH_ADV_TOT_CSO_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PRINT_CASH_ADV_TOT_PAYMENTS_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PRINT_CASH_ADV_FINAL_PAYMENT_AMT { get; set; }

        public byte PRINT_CASH_ADV_PAYMENT_COUNT { get; set; }

        public byte PRINT_CASH_ADV_FEE_ONLY_PAYMENT_COUNT { get; set; }

        [Column(TypeName = "smallmoney")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? CSO_LENDER_INTEREST_FEE_AMT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ACTIVITY_FEE_TWO_WEEK_PCT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ACTIVITY_FEE_FOUR_WEEK_PCT { get; set; }

        public bool ENABLE_FLAT_FEE_RULES { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PRINT_CASH_ADV_FINANCE_CHARGE { get; set; }

        public bool CHARGE_INTEREST_ON_LOAN_FEES { get; set; }

        [Column(TypeName = "date")]
        public DateTime? RESUME_INTEREST_DATE { get; set; }

        public bool RESUME_INTEREST_ON_PAYMENT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CREDIT_AVAILABLE_FOR_BUYUP { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CREDIT_LIMIT_NON_ORDINANCE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CREDIT_AVAILABLE_FOR_BUYUP_NON_ORDINANCE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? LAST_CAB_FEE_AMT { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LAST_CAB_FEE_DATE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? INACTIVE_DATE { get; set; }

        public byte SET_INACTIVE_ON_DAY { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ORIG_FINAL_STATEMENT_DATE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ORIG_FINAL_DUE_DATE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PENDING_DUE_DATE_CHANGE_ORIG_DUE_DATE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PENDING_DUE_DATE_CHANGE_ADJUSTED_DUE_DATE { get; set; }

        public byte CAB_FEE_DAY_OFFSET { get; set; }

        public bool FINANCE_LIEN_FEE { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? PAST_DUE_AMT { get; set; }

        public byte MAX_RI_FEES_PER_LOAN_SERIES { get; set; }

        public bool RI_FEE_REQUIRES_BANK_ACCOUNT { get; set; }
    }
}
