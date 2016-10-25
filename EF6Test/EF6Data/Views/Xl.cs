namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Xl")]
    public partial class Xl
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int lkey { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ckey { get; set; }

        public int? ikey { get; set; }

        public int? olkey { get; set; }

        public int? plkey { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int tdkey { get; set; }

        public int? lpkey { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(2)]
        public string BUSINESS_STATE { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool IS_INTERNET { get; set; }

        [StringLength(25)]
        public string c_LASTNAME { get; set; }

        [StringLength(24)]
        public string c_FIRSTNAME { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LOAN_KEY { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TRANS_DETAIL_KEY { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CUSTOMER_KEY { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short LOCATION { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Key]
        [Column(Order = 10, TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Key]
        [Column(Order = 11)]
        public bool COURTESY_CALL { get; set; }

        public int? ISSUER_KEY { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(10)]
        public string CHECK_NO { get; set; }

        [Key]
        [Column(Order = 13)]
        public bool DIRECT_DEPOSIT { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(1)]
        public string LOAN_TYPE { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(1)]
        public string ORIG_CODE { get; set; }

        public int? ORIG_LOAN_KEY { get; set; }

        public int? PAID_LOAN_KEY { get; set; }

        public int? PAYMENT_PLAN_KEY { get; set; }

        [Key]
        [Column(Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short ROLLOVER_NUM { get; set; }

        [Key]
        [Column(Order = 17)]
        [StringLength(1)]
        public string LOAN_STATUS { get; set; }

        [Key]
        [Column(Order = 18, TypeName = "smallmoney")]
        public decimal LOAN_BALANCE { get; set; }

        [Key]
        [Column(Order = 19, TypeName = "smallmoney")]
        public decimal LOAN_AMT { get; set; }

        [Key]
        [Column(Order = 20, TypeName = "smallmoney")]
        public decimal CASH_AMT { get; set; }

        [Key]
        [Column(Order = 21, TypeName = "smallmoney")]
        public decimal PRINC_AMT { get; set; }

        [Key]
        [Column(Order = 22, TypeName = "numeric")]
        public decimal RATE_PCT { get; set; }

        [Key]
        [Column(Order = 23, TypeName = "smallmoney")]
        public decimal DISC_AMT { get; set; }

        [Key]
        [Column(Order = 24, TypeName = "smallmoney")]
        public decimal REBATE_AMT { get; set; }

        [Key]
        [Column(Order = 25, TypeName = "smallmoney")]
        public decimal GRACE_AMT { get; set; }

        [Key]
        [Column(Order = 26, TypeName = "smallmoney")]
        public decimal FEE_AMT { get; set; }

        [Key]
        [Column(Order = 27, TypeName = "smallmoney")]
        public decimal TRANS_FEE_AMT { get; set; }

        [Key]
        [Column(Order = 28, TypeName = "smallmoney")]
        public decimal LIEN_FEE_AMT { get; set; }

        [Key]
        [Column(Order = 29)]
        public bool CHARGE_TRANS_FEE { get; set; }

        [Key]
        [Column(Order = 30)]
        public bool CHARGE_LIEN_FEE { get; set; }

        [Key]
        [Column(Order = 31, TypeName = "smallmoney")]
        public decimal TOT_FEE_AMT { get; set; }

        [Key]
        [Column(Order = 32, TypeName = "smalldatetime")]
        public DateTime ORIG_DUE_DATE { get; set; }

        [Key]
        [Column(Order = 33, TypeName = "smalldatetime")]
        public DateTime ADJUSTED_DUE_DATE { get; set; }

        [Key]
        [Column(Order = 34)]
        public bool DEFAULTED { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DEFAULT_DATE { get; set; }

        [Key]
        [Column(Order = 35)]
        public bool REVERSED { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? REVERSED_DATE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ORIG_APR { get; set; }

        public int? DRAWERZ_KEY { get; set; }

        [Key]
        [Column(Order = 36, TypeName = "smalldatetime")]
        public DateTime LOAN_STATUS_DATE { get; set; }

        [Key]
        [Column(Order = 37)]
        public bool JOINT_LOAN { get; set; }

        [Key]
        [Column(Order = 38)]
        [StringLength(1)]
        public string PRINT_LANGUAGE { get; set; }

        [Key]
        [Column(Order = 39, TypeName = "smalldatetime")]
        public DateTime CALC_DUE_DATE { get; set; }

        public int? DWDOCID { get; set; }

        [Key]
        [Column(Order = 40)]
        public bool DOCLOST { get; set; }

        [Key]
        [Column(Order = 41)]
        [StringLength(15)]
        public string DW_LOAN_NO { get; set; }

        [Key]
        [Column(Order = 42)]
        [StringLength(1)]
        public string PRODUCT_TYPE { get; set; }

        [Key]
        [Column(Order = 43)]
        [StringLength(10)]
        public string DISPLAY_CHECK_NO { get; set; }

        [Key]
        [Column(Order = 44, TypeName = "smallmoney")]
        public decimal PENDING_SCHED_ACH_AMT { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? PENDING_SCHED_ACH_SENT { get; set; }

        [Key]
        [Column(Order = 45, TypeName = "smallmoney")]
        public decimal PENDING_COLL_ACH_AMT { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? PENDING_COLL_ACH_SENT { get; set; }

        public byte? DEPOSIT_ORDER { get; set; }

        public byte? DEPOSIT_STATUS { get; set; }

        [Key]
        [Column(Order = 46, TypeName = "smalldatetime")]
        public DateTime LOAN_DATE { get; set; }

        [Key]
        [Column(Order = 47)]
        public byte FUNDING_METHOD { get; set; }

        public int? CREDIT_CARD_KEY { get; set; }

        public bool? IS_MULTI_CHECK { get; set; }

        public int? LOAN_PRODUCT_KEY { get; set; }

        public bool? IS_GAIL_LOAN { get; set; }

        [Key]
        [Column(Order = 48)]
        public bool EXCLUDE_FROM_CAP { get; set; }

        [Key]
        [Column(Order = 49)]
        public bool IS_ESIGN { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CAPS_CHANGE_DATE { get; set; }

        [Key]
        [Column(Order = 50, TypeName = "smallmoney")]
        public decimal FASTER_PAYMENTS_FEE { get; set; }

        [Key]
        [Column(Order = 51)]
        public byte ESIGN_DOC_METHOD { get; set; }

        [Key]
        [Column(Order = 52, TypeName = "numeric")]
        public decimal STANDARD_RATE_PCT { get; set; }

        [Key]
        [Column(Order = 53)]
        public byte LOAN_RATE_SOURCE { get; set; }

        public short? CREDITED_LOCATION { get; set; }

        [Key]
        [Column(Order = 54, TypeName = "numeric")]
        public decimal TILA_APR { get; set; }

        [Key]
        [Column(Order = 55, TypeName = "smallmoney")]
        public decimal TILA_FINANCE_CHARGE { get; set; }

        [Key]
        [Column(Order = 56, TypeName = "smallmoney")]
        public decimal TILA_AMOUNT_FINANCED { get; set; }

        [Key]
        [Column(Order = 57, TypeName = "smallmoney")]
        public decimal TILA_TOTAL_PAYMENTS { get; set; }

        [Key]
        [Column(Order = 58)]
        public bool INTEREST_AND_FEES_CAP_REACHED { get; set; }

        [Column(TypeName = "date")]
        public DateTime? INTEREST_AND_FEES_CAP_REACHED_DATE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? WITHDRAW_DATE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? WITHDRAW_ADJUSTED_DUE_DATE { get; set; }

        [Key]
        [Column(Order = 59)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LOAN_PRODUCT_CONFIG_KEY { get; set; }

        [Key]
        [Column(Order = 60)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LOAN_PRODUCT_TILA_KEY { get; set; }

        [StringLength(25)]
        public string Spell_DEPOSIT_STATUS { get; set; }

        [StringLength(40)]
        public string Spell_DEPOSIT_ORDER { get; set; }

        [StringLength(75)]
        public string PRODUCT_NAME { get; set; }
    }
}
