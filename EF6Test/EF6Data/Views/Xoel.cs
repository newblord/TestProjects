namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Xoel")]
    public partial class Xoel
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int oelkey { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int lkey { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short LOCATION { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(2)]
        public string BUSINESS_STATE { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(1)]
        public string LOAN_STATUS { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "smallmoney")]
        public decimal LOAN_BALANCE { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(1)]
        public string x { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OPEN_END_LOAN_KEY { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LOAN_KEY { get; set; }

        [Key]
        [Column(Order = 9)]
        public byte TRANS_FEE_PCT { get; set; }

        [Key]
        [Column(Order = 10)]
        public byte CYCLE_DAYS { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short STATEMENT_DAYS { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short PAYMENT_DAYS { get; set; }

        [Key]
        [Column(Order = 13, TypeName = "smallmoney")]
        public decimal LAST_PAYMENT_AMT { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LAST_PAYMENT_DATE { get; set; }

        [Key]
        [Column(Order = 14, TypeName = "smallmoney")]
        public decimal LAST_CASH_ADV_AMT { get; set; }

        public DateTime? LAST_CASH_ADV_DATE { get; set; }

        [Key]
        [Column(Order = 15)]
        public byte LAST_STATEMENT_NUM { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LAST_STATEMENT_DATE { get; set; }

        [Key]
        [Column(Order = 16, TypeName = "date")]
        public DateTime NEXT_STATEMENT_DATE { get; set; }

        [Key]
        [Column(Order = 17, TypeName = "date")]
        public DateTime NEXT_DUE_DATE { get; set; }

        [Key]
        [Column(Order = 18, TypeName = "smallmoney")]
        public decimal PAST_DUE_TRANS_FEE_AMT { get; set; }

        [Key]
        [Column(Order = 19, TypeName = "smallmoney")]
        public decimal PAST_DUE_LIEN_FEE_AMT { get; set; }

        [Key]
        [Column(Order = 20, TypeName = "smallmoney")]
        public decimal PAST_DUE_ACTIVITY_FEE_AMT { get; set; }

        [Key]
        [Column(Order = 21, TypeName = "smallmoney")]
        public decimal PAST_DUE_COLL_FEE_AMT { get; set; }

        [Key]
        [Column(Order = 22, TypeName = "smallmoney")]
        public decimal PAST_DUE_INTEREST_AMT { get; set; }

        [Key]
        [Column(Order = 23, TypeName = "smallmoney")]
        public decimal PAST_DUE_PRINC_AMT { get; set; }

        [Key]
        [Column(Order = 24, TypeName = "smallmoney")]
        public decimal CURR_DUE_TRANS_FEE_AMT { get; set; }

        [Key]
        [Column(Order = 25, TypeName = "smallmoney")]
        public decimal CURR_DUE_LIEN_FEE_AMT { get; set; }

        [Key]
        [Column(Order = 26, TypeName = "smallmoney")]
        public decimal CURR_DUE_ACTIVITY_FEE_AMT { get; set; }

        [Key]
        [Column(Order = 27, TypeName = "smallmoney")]
        public decimal CURR_DUE_INTEREST_AMT { get; set; }

        [Key]
        [Column(Order = 28, TypeName = "smallmoney")]
        public decimal CURR_DUE_PRINC_AMT { get; set; }

        [Key]
        [Column(Order = 29, TypeName = "smallmoney")]
        public decimal NEXT_DUE_TRANS_FEE_AMT { get; set; }

        [Key]
        [Column(Order = 30, TypeName = "smallmoney")]
        public decimal NEXT_DUE_LIEN_FEE_AMT { get; set; }

        [Key]
        [Column(Order = 31, TypeName = "smallmoney")]
        public decimal NEXT_DUE_ACTIVITY_FEE_AMT { get; set; }

        [Key]
        [Column(Order = 32, TypeName = "smallmoney")]
        public decimal NEXT_DUE_INTEREST_AMT { get; set; }

        [Key]
        [Column(Order = 33, TypeName = "smallmoney")]
        public decimal NEXT_DUE_PRINC_AMT { get; set; }

        [Key]
        [Column(Order = 34, TypeName = "smallmoney")]
        public decimal NOT_DUE_TRANS_FEE_AMT { get; set; }

        [Key]
        [Column(Order = 35, TypeName = "smallmoney")]
        public decimal NOT_DUE_LIEN_FEE_AMT { get; set; }

        [Key]
        [Column(Order = 36, TypeName = "smallmoney")]
        public decimal NOT_DUE_ACTIVITY_FEE_AMT { get; set; }

        [Key]
        [Column(Order = 37, TypeName = "smallmoney")]
        public decimal NOT_DUE_INTEREST_AMT { get; set; }

        [Key]
        [Column(Order = 38, TypeName = "smallmoney")]
        public decimal NOT_DUE_PRINC_AMT { get; set; }

        [Key]
        [Column(Order = 39, TypeName = "smallmoney")]
        public decimal CREDIT_LIMIT { get; set; }

        [Key]
        [Column(Order = 40, TypeName = "smallmoney")]
        public decimal CREDIT_AVAIL { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CLOSED_DATE { get; set; }

        [Key]
        [Column(Order = 41)]
        public bool SUSPEND_INTEREST { get; set; }

        [Key]
        [Column(Order = 42)]
        public bool EMAIL_STATEMENTS { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? TRANS_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? LIEN_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? ACTIVITY_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? INTEREST_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? PRINC_FEE_AMT { get; set; }

        [Key]
        [Column(Order = 43)]
        public bool IS_BUSINESS_LOAN { get; set; }

        [Key]
        [Column(Order = 44)]
        public bool IS_USE_PAY_CYCLE { get; set; }

        [Key]
        [Column(Order = 45)]
        public bool IS_GIFT_CARD_LOAN { get; set; }

        [Key]
        [Column(Order = 46, TypeName = "smallmoney")]
        public decimal PENDING_SCHED_ACH_AMT { get; set; }

        [Key]
        [Column(Order = 47)]
        public byte SELECTED_CYCLE_WEEKS { get; set; }

        [Key]
        [Column(Order = 48, TypeName = "smallmoney")]
        public decimal PAST_DUE_CSO_LENDER_COLL_FEE_AMT { get; set; }

        [Key]
        [Column(Order = 49, TypeName = "smallmoney")]
        public decimal PAST_DUE_CSO_LENDER_INTEREST_AMT { get; set; }

        [Key]
        [Column(Order = 50, TypeName = "smallmoney")]
        public decimal CURR_DUE_CSO_LENDER_INTEREST_AMT { get; set; }

        [Key]
        [Column(Order = 51, TypeName = "smallmoney")]
        public decimal NEXT_DUE_CSO_LENDER_INTEREST_AMT { get; set; }

        [Key]
        [Column(Order = 52, TypeName = "smallmoney")]
        public decimal NOT_DUE_CSO_LENDER_INTEREST_AMT { get; set; }

        [Key]
        [Column(Order = 53, TypeName = "numeric")]
        public decimal CSO_LENDER_ANNUAL_RATE_PCT { get; set; }

        [Key]
        [Column(Order = 54, TypeName = "numeric")]
        public decimal CSO_LENDER_MONTHLY_RATE_PCT { get; set; }

        [Key]
        [Column(Order = 55, TypeName = "numeric")]
        public decimal CSO_LENDER_DAILY_RATE_PCT { get; set; }

        [Key]
        [Column(Order = 56)]
        public byte TERM_LIMIT_DAYS { get; set; }

        [Column(TypeName = "date")]
        public DateTime? TERM_LIMIT_FINAL_STATEMENT_DATE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? TERM_LIMIT_FINAL_DUE_DATE { get; set; }

        [Key]
        [Column(Order = 57)]
        public byte SET_INACTIVE_ON_MISSED_PAYMENT_COUNT { get; set; }

        [Key]
        [Column(Order = 58)]
        public byte SET_INACTIVE_ON_DAY_AFTER_MISSED_PAYMENT_COUNT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? CURR_DUE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? NEXT_DUE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? NOT_DUE_AMT { get; set; }

        [Key]
        [Column(Order = 59, TypeName = "smallmoney")]
        public decimal PRINT_TOT_CSO_INTEREST_AMT { get; set; }

        [Key]
        [Column(Order = 60, TypeName = "smallmoney")]
        public decimal PRINT_PAYMENT1_PRINC_AMT { get; set; }

        [Key]
        [Column(Order = 61, TypeName = "smallmoney")]
        public decimal PRINT_PAYMENT2_PRINC_AMT { get; set; }

        [Key]
        [Column(Order = 62, TypeName = "smallmoney")]
        public decimal PRINT_PAYMENT1_INTEREST_AMT { get; set; }

        [Key]
        [Column(Order = 63, TypeName = "smallmoney")]
        public decimal PRINT_PAYMENT2_INTEREST_AMT { get; set; }

        [Key]
        [Column(Order = 64, TypeName = "smallmoney")]
        public decimal PRINT_TOT_INTEREST_AMT { get; set; }

        [Key]
        [Column(Order = 65, TypeName = "smallmoney")]
        public decimal PRINT_TOT_PAYMENTS_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? COLLECTIONS_AMT { get; set; }

        [Key]
        [Column(Order = 66)]
        public bool DECLINED_AUTO_PAY { get; set; }

        [Key]
        [Column(Order = 67, TypeName = "smallmoney")]
        public decimal PRINT_PAYMENT1_TRANS_FEE_AMT { get; set; }

        [Key]
        [Column(Order = 68, TypeName = "smallmoney")]
        public decimal PRINT_PAYMENT2_TRANS_FEE_AMT { get; set; }

        [Key]
        [Column(Order = 69, TypeName = "smallmoney")]
        public decimal PRINT_PAYMENT1_TOTAL_DUE_AMT { get; set; }

        [Key]
        [Column(Order = 70, TypeName = "smallmoney")]
        public decimal PRINT_PAYMENT2_TOTAL_DUE_AMT { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PRINT_PAYMENT1_DUEDATE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PRINT_PAYMENT2_DUEDATE { get; set; }

        [Key]
        [Column(Order = 71, TypeName = "numeric")]
        public decimal MIN_PRINC_DUE_TWO_WEEKS_PCT { get; set; }

        [Key]
        [Column(Order = 72, TypeName = "numeric")]
        public decimal MIN_PRINC_DUE_FOUR_WEEKS_PCT { get; set; }

        [Key]
        [Column(Order = 73, TypeName = "smallmoney")]
        public decimal MIN_PRINC_DUE_TWO_WEEKS_AMT { get; set; }

        [Key]
        [Column(Order = 74, TypeName = "smallmoney")]
        public decimal MIN_PRINC_DUE_FOUR_WEEKS_AMT { get; set; }

        [Key]
        [Column(Order = 75)]
        public byte PRINT_PAYMENT1_STATEMENT_DAYS { get; set; }

        [Key]
        [Column(Order = 76)]
        public byte PRINT_PAYMENT2_STATEMENT_DAYS { get; set; }

        [Key]
        [Column(Order = 77, TypeName = "smallmoney")]
        public decimal PRINT_CASH_ADV_PAYMENT1_TOTAL_DUE_AMT { get; set; }

        [Key]
        [Column(Order = 78, TypeName = "smallmoney")]
        public decimal PRINT_CASH_ADV_PAYMENT2_TOTAL_DUE_AMT { get; set; }

        [Key]
        [Column(Order = 79, TypeName = "smallmoney")]
        public decimal PRINT_CASH_ADV_PAYMENT1_PRINC_AMT { get; set; }

        [Key]
        [Column(Order = 80, TypeName = "smallmoney")]
        public decimal PRINT_CASH_ADV_PAYMENT2_PRINC_AMT { get; set; }

        [Key]
        [Column(Order = 81, TypeName = "smallmoney")]
        public decimal PRINT_CASH_ADV_PAYMENT1_INTEREST_AMT { get; set; }

        [Key]
        [Column(Order = 82, TypeName = "smallmoney")]
        public decimal PRINT_CASH_ADV_PAYMENT2_INTEREST_AMT { get; set; }

        [Key]
        [Column(Order = 83, TypeName = "smallmoney")]
        public decimal PRINT_CASH_ADV_TOT_INTEREST_AMT { get; set; }

        [Key]
        [Column(Order = 84, TypeName = "smallmoney")]
        public decimal PRINT_CASH_ADV_TOT_CSO_INTEREST_AMT { get; set; }

        [Key]
        [Column(Order = 85, TypeName = "smallmoney")]
        public decimal PRINT_CASH_ADV_TOT_PAYMENTS_AMT { get; set; }

        [Key]
        [Column(Order = 86, TypeName = "smallmoney")]
        public decimal PRINT_CASH_ADV_FINAL_PAYMENT_AMT { get; set; }

        [Key]
        [Column(Order = 87)]
        public byte PRINT_CASH_ADV_PAYMENT_COUNT { get; set; }

        [Key]
        [Column(Order = 88)]
        public byte PRINT_CASH_ADV_FEE_ONLY_PAYMENT_COUNT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? CSO_LENDER_INTEREST_FEE_AMT { get; set; }

        [Key]
        [Column(Order = 89, TypeName = "numeric")]
        public decimal ACTIVITY_FEE_TWO_WEEK_PCT { get; set; }

        [Key]
        [Column(Order = 90, TypeName = "numeric")]
        public decimal ACTIVITY_FEE_FOUR_WEEK_PCT { get; set; }

        [Key]
        [Column(Order = 91)]
        public bool ENABLE_FLAT_FEE_RULES { get; set; }

        [Key]
        [Column(Order = 92, TypeName = "smallmoney")]
        public decimal PRINT_CASH_ADV_FINANCE_CHARGE { get; set; }

        [Key]
        [Column(Order = 93)]
        public bool CHARGE_INTEREST_ON_LOAN_FEES { get; set; }

        [Column(TypeName = "date")]
        public DateTime? RESUME_INTEREST_DATE { get; set; }

        [Key]
        [Column(Order = 94)]
        public bool RESUME_INTEREST_ON_PAYMENT { get; set; }

        [Key]
        [Column(Order = 95, TypeName = "smallmoney")]
        public decimal CREDIT_AVAILABLE_FOR_BUYUP { get; set; }

        [Key]
        [Column(Order = 96, TypeName = "smallmoney")]
        public decimal CREDIT_LIMIT_NON_ORDINANCE { get; set; }

        [Key]
        [Column(Order = 97, TypeName = "smallmoney")]
        public decimal CREDIT_AVAILABLE_FOR_BUYUP_NON_ORDINANCE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? LAST_CAB_FEE_AMT { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LAST_CAB_FEE_DATE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? INACTIVE_DATE { get; set; }

        [Key]
        [Column(Order = 98)]
        public byte SET_INACTIVE_ON_DAY { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ORIG_FINAL_STATEMENT_DATE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ORIG_FINAL_DUE_DATE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PENDING_DUE_DATE_CHANGE_ORIG_DUE_DATE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PENDING_DUE_DATE_CHANGE_ADJUSTED_DUE_DATE { get; set; }

        [Key]
        [Column(Order = 99)]
        public byte CAB_FEE_DAY_OFFSET { get; set; }

        [Key]
        [Column(Order = 100)]
        public bool FINANCE_LIEN_FEE { get; set; }

        public decimal? PAST_DUE_AMT { get; set; }

        [Key]
        [Column(Order = 101)]
        public byte MAX_RI_FEES_PER_LOAN_SERIES { get; set; }

        [Key]
        [Column(Order = 102)]
        public bool RI_FEE_REQUIRES_BANK_ACCOUNT { get; set; }
    }
}
