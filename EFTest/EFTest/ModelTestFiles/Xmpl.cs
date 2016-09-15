namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Xmpl")]
    public partial class Xmpl
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int mplkey { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int lkey { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ckey { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int tdkey { get; set; }

        public int? ikey { get; set; }

        [Column(TypeName = "date")]
        public DateTime? payoff_date { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(2)]
        public string X1 { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MPAY_LOAN_KEY { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LOAN_KEY { get; set; }

        [Key]
        [Column(Order = 7, TypeName = "numeric")]
        public decimal ANNUAL_RATE_PCT { get; set; }

        [Key]
        [Column(Order = 8, TypeName = "numeric")]
        public decimal MONTHLY_RATE_PCT { get; set; }

        [Key]
        [Column(Order = 9, TypeName = "numeric")]
        public decimal DAILY_RATE_PCT { get; set; }

        [Key]
        [Column(Order = 10, TypeName = "numeric")]
        public decimal ACTUARIAL_APR { get; set; }

        [Key]
        [Column(Order = 11)]
        public byte ODD_DAYS_INTEREST_CNT { get; set; }

        [Key]
        [Column(Order = 12, TypeName = "smallmoney")]
        public decimal ODD_DAYS_INTEREST_AMT { get; set; }

        [Key]
        [Column(Order = 13)]
        public byte TRANS_FEE_PCT { get; set; }

        [Key]
        [Column(Order = 14)]
        public byte CYCLE_DAYS { get; set; }

        [Key]
        [Column(Order = 15)]
        public byte COLLECTION_DAYS { get; set; }

        [Key]
        [Column(Order = 16)]
        public byte AMORT_PAYMENT_CNT { get; set; }

        [Key]
        [Column(Order = 17, TypeName = "smallmoney")]
        public decimal SCHED_LAST_PAYMENT_AMT { get; set; }

        [Column(TypeName = "date")]
        public DateTime? SCHED_LAST_PAYMENT_DATE { get; set; }

        [Key]
        [Column(Order = 18, TypeName = "smallmoney")]
        public decimal LAST_PAYMENT_AMT { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LAST_PAYMENT_DATE { get; set; }

        [Key]
        [Column(Order = 19, TypeName = "smallmoney")]
        public decimal NEXT_DUE_AMT { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NEXT_DUE_DATE { get; set; }

        [Key]
        [Column(Order = 20, TypeName = "smallmoney")]
        public decimal EST_FINANCE_CHARGE { get; set; }

        [Key]
        [Column(Order = 21, TypeName = "smallmoney")]
        public decimal CREDIT_LIMIT { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CLOSED_DATE { get; set; }

        [Key]
        [Column(Order = 22)]
        public bool SUSPEND_INTEREST { get; set; }

        [Key]
        [Column(Order = 23, TypeName = "smallmoney")]
        public decimal PENDING_SCHED_ACH_AMT { get; set; }

        [Key]
        [Column(Order = 24, TypeName = "smallmoney")]
        public decimal TRANS_FEE_AMT { get; set; }

        public int? CREDITCARD_KEY { get; set; }

        [Key]
        [Column(Order = 25, TypeName = "smallmoney")]
        public decimal PAYMENT_PLAN_FEE { get; set; }

        [Key]
        [Column(Order = 26)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PAYMENT_PLAN_LOAN_KEY { get; set; }

        [Key]
        [Column(Order = 27)]
        public bool IS_BUSINESS_LOAN { get; set; }

        [Key]
        [Column(Order = 28)]
        [StringLength(1)]
        public string TRANS_FEE_METHOD { get; set; }

        [Key]
        [Column(Order = 29, TypeName = "smallmoney")]
        public decimal TRANS_FEE_COLORADO_POSTPONE_AMT { get; set; }

        [Key]
        [Column(Order = 30)]
        public bool DECLINED_AUTO_PAY { get; set; }

        [Key]
        [Column(Order = 31)]
        public byte SET_INACTIVE_ON_DAY { get; set; }

        [Key]
        [Column(Order = 32)]
        public byte SET_INACTIVE_ON_MISSED_PAYMENT_COUNT { get; set; }

        [Key]
        [Column(Order = 33)]
        public byte SET_INACTIVE_ON_DAY_AFTER_MISSED_PAYMENT_COUNT { get; set; }

        [Key]
        [Column(Order = 34)]
        public byte SELECTED_CYCLE_WEEKS { get; set; }

        [Key]
        [Column(Order = 35, TypeName = "smallmoney")]
        public decimal COLL_FEE_PAST_DUE_BAL { get; set; }

        [Key]
        [Column(Order = 36, TypeName = "smallmoney")]
        public decimal LEGAL_FEE_PAST_DUE_BAL { get; set; }

        [Key]
        [Column(Order = 37, TypeName = "smallmoney")]
        public decimal LOAN_FEE_DUE_BAL { get; set; }

        [Key]
        [Column(Order = 38, TypeName = "smallmoney")]
        public decimal TRANS_FEE_DUE_BAL { get; set; }

        [Key]
        [Column(Order = 39, TypeName = "smallmoney")]
        public decimal INTEREST_DUE_BAL { get; set; }

        [Key]
        [Column(Order = 40, TypeName = "smallmoney")]
        public decimal PRINC_DUE_BAL { get; set; }

        [Key]
        [Column(Order = 41, TypeName = "smallmoney")]
        public decimal PAYMENT_DUE_BAL { get; set; }

        [Key]
        [Column(Order = 42, TypeName = "smallmoney")]
        public decimal PAYMENT_PAST_DUE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? COLLECTIONS_BAL { get; set; }

        [Key]
        [Column(Order = 43, TypeName = "numeric")]
        public decimal CAB_ANNUAL_RATE_PCT { get; set; }

        [Key]
        [Column(Order = 44, TypeName = "numeric")]
        public decimal CAB_MONTHLY_RATE_PCT { get; set; }

        [Key]
        [Column(Order = 45, TypeName = "numeric")]
        public decimal CAB_DAILY_RATE_PCT { get; set; }

        [Key]
        [Column(Order = 46, TypeName = "smallmoney")]
        public decimal CAB_COLL_FEE_PAST_DUE_BAL { get; set; }

        [Key]
        [Column(Order = 47, TypeName = "smallmoney")]
        public decimal CAB_INTEREST_DUE_BAL { get; set; }

        [Column(TypeName = "date")]
        public DateTime? RESUME_INTEREST_DATE { get; set; }

        [Key]
        [Column(Order = 48)]
        public bool RESUME_INTEREST_ON_PAYMENT { get; set; }

        [Key]
        [Column(Order = 49)]
        [StringLength(1)]
        public string APPLY_DISCOUNT_TO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? INACTIVE_DATE { get; set; }

        [Key]
        [Column(Order = 50, TypeName = "smallmoney")]
        public decimal RI_FEE_PER_DEFAULT { get; set; }

        [Key]
        [Column(Order = 51)]
        public byte RI_FEES_PER_LOAN { get; set; }

        [Key]
        [Column(Order = 52, TypeName = "smallmoney")]
        public decimal NSF_FEE_PAST_DUE_BAL { get; set; }

        [Key]
        [Column(Order = 53)]
        public bool MATCH_SPAY_RATE { get; set; }

        [Key]
        [Column(Order = 54)]
        public bool CYCLE_DAYS_FIXED { get; set; }

        [Key]
        [Column(Order = 55)]
        public bool CYCLE_DUE_DATE_MATCH { get; set; }

        [Key]
        [Column(Order = 56)]
        public bool IS_DAY_AFTER_DUE { get; set; }

        [Key]
        [Column(Order = 57)]
        public byte MAX_RI_FEES_PER_LOAN_SERIES { get; set; }

        [Key]
        [Column(Order = 58)]
        public bool RI_FEE_REQUIRES_BANK_ACCOUNT { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ORIG_MATURITY_DATE { get; set; }

        [Key]
        [Column(Order = 59, TypeName = "date")]
        public DateTime ADJUSTED_MATURITY_DATE { get; set; }

        [Key]
        [Column(Order = 60)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CYCLES_PAST_DUE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DAILY_INTEREST_AMT { get; set; }

        [Key]
        [Column(Order = 61, TypeName = "smallmoney")]
        public decimal INSURANCE_DUE_BAL { get; set; }

        [Key]
        [Column(Order = 62)]
        [StringLength(2)]
        public string X2 { get; set; }

        [Key]
        [Column(Order = 63)]
        [StringLength(1)]
        public string LOAN_TYPE { get; set; }

        [Key]
        [Column(Order = 64)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short LOCATION { get; set; }

        [Key]
        [Column(Order = 65)]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Key]
        [Column(Order = 66, TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Key]
        [Column(Order = 67)]
        public bool COURTESY_CALL { get; set; }

        [Key]
        [Column(Order = 68)]
        public bool DEFAULTED { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DEFAULT_DATE { get; set; }

        [Key]
        [Column(Order = 69)]
        [StringLength(1)]
        public string LOAN_STATUS { get; set; }

        [Key]
        [Column(Order = 70, TypeName = "smallmoney")]
        public decimal LOAN_BALANCE { get; set; }

        [Key]
        [Column(Order = 71, TypeName = "smallmoney")]
        public decimal LOAN_AMT { get; set; }

        [Key]
        [Column(Order = 72, TypeName = "smallmoney")]
        public decimal CASH_AMT { get; set; }

        [Key]
        [Column(Order = 73, TypeName = "smallmoney")]
        public decimal PRINC_AMT { get; set; }

        [Key]
        [Column(Order = 74)]
        [StringLength(10)]
        public string CHECK_NO { get; set; }

        [Key]
        [Column(Order = 75)]
        public bool DIRECT_DEPOSIT { get; set; }

        [Key]
        [Column(Order = 76)]
        [StringLength(1)]
        public string PRODUCT_TYPE { get; set; }

        [Key]
        [Column(Order = 77)]
        [StringLength(1)]
        public string ORIG_CODE { get; set; }

        public int? ORIG_LOAN_KEY { get; set; }

        public int? PAID_LOAN_KEY { get; set; }

        public int? PAYMENT_PLAN_KEY { get; set; }

        [Key]
        [Column(Order = 78)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short ROLLOVER_NUM { get; set; }

        [Key]
        [Column(Order = 79, TypeName = "numeric")]
        public decimal RATE_PCT { get; set; }

        [Key]
        [Column(Order = 80, TypeName = "smallmoney")]
        public decimal DISC_AMT { get; set; }

        [Key]
        [Column(Order = 81, TypeName = "smallmoney")]
        public decimal REBATE_AMT { get; set; }

        [Key]
        [Column(Order = 82, TypeName = "smallmoney")]
        public decimal GRACE_AMT { get; set; }

        [Key]
        [Column(Order = 83, TypeName = "smallmoney")]
        public decimal FEE_AMT { get; set; }

        [Key]
        [Column(Order = 84, TypeName = "smallmoney")]
        public decimal L_TRANS_FEE_AMT { get; set; }

        [Key]
        [Column(Order = 85, TypeName = "smallmoney")]
        public decimal LIEN_FEE_AMT { get; set; }

        [Key]
        [Column(Order = 86)]
        public bool CHARGE_TRANS_FEE { get; set; }

        [Key]
        [Column(Order = 87)]
        public bool CHARGE_LIEN_FEE { get; set; }

        [Key]
        [Column(Order = 88, TypeName = "smallmoney")]
        public decimal TOT_FEE_AMT { get; set; }

        [Key]
        [Column(Order = 89, TypeName = "smallmoney")]
        public decimal INSURANCE_FEE_AMT { get; set; }

        [Key]
        [Column(Order = 90, TypeName = "smalldatetime")]
        public DateTime ORIG_DUE_DATE { get; set; }

        [Key]
        [Column(Order = 91, TypeName = "smalldatetime")]
        public DateTime ADJUSTED_DUE_DATE { get; set; }

        [Key]
        [Column(Order = 92, TypeName = "smalldatetime")]
        public DateTime CALC_DUE_DATE { get; set; }

        [Key]
        [Column(Order = 93, TypeName = "smalldatetime")]
        public DateTime LOAN_STATUS_DATE { get; set; }

        [Key]
        [Column(Order = 94)]
        public bool REVERSED { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? REVERSED_DATE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ORIG_APR { get; set; }

        public int? DRAWERZ_KEY { get; set; }

        [Key]
        [Column(Order = 95)]
        public bool JOINT_LOAN { get; set; }

        [Key]
        [Column(Order = 96)]
        [StringLength(1)]
        public string PRINT_LANGUAGE { get; set; }

        public int? DWDOCID { get; set; }

        [Key]
        [Column(Order = 97)]
        public bool DOCLOST { get; set; }

        [Key]
        [Column(Order = 98)]
        [StringLength(15)]
        public string DW_LOAN_NO { get; set; }
    }
}
