namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Xlpoe")]
    public partial class Xlpoe
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int lpoekey { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int lpkey { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int tdkey { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int lkey { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ckey { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short lp_LOCATION { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(1)]
        public string lp_PRODUCT_TYPE { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(1)]
        public string lp_LOAN_TYPE { get; set; }

        [Key]
        [Column(Order = 8, TypeName = "smallmoney")]
        public decimal lp_PAID_AMT { get; set; }

        [Key]
        [Column(Order = 9)]
        public byte lp_TRANS_CODE { get; set; }

        [StringLength(50)]
        public string Spell_TRANS_CODE { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short lp_PAYMENT_METHOD { get; set; }

        [StringLength(15)]
        public string Spell_PAYMENT_METHOD { get; set; }

        [Key]
        [Column(Order = 11)]
        public bool lp_REVERSED { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? lp_REVERSED_DATE { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(3)]
        public string lp_TELLER { get; set; }

        [Key]
        [Column(Order = 13)]
        public DateTime lp_DATE_ENTERED { get; set; }

        [Column(TypeName = "date")]
        public DateTime? lp_DATE_ENTERED_no_time { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(500)]
        public string lp_NOTE { get; set; }

        [Key]
        [Column(Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LOAN_PAYMENT_OPEN_END_KEY { get; set; }

        [Key]
        [Column(Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LOAN_PAYMENT_KEY { get; set; }

        [Key]
        [Column(Order = 17, TypeName = "smallmoney")]
        public decimal PAST_DUE_TRANS_FEE_AMT { get; set; }

        [Key]
        [Column(Order = 18, TypeName = "smallmoney")]
        public decimal PAST_DUE_LIEN_FEE_AMT { get; set; }

        [Key]
        [Column(Order = 19, TypeName = "smallmoney")]
        public decimal PAST_DUE_ACTIVITY_FEE_AMT { get; set; }

        [Key]
        [Column(Order = 20, TypeName = "smallmoney")]
        public decimal PAST_DUE_COLL_FEE_AMT { get; set; }

        [Key]
        [Column(Order = 21, TypeName = "smallmoney")]
        public decimal PAST_DUE_INTEREST_AMT { get; set; }

        [Key]
        [Column(Order = 22, TypeName = "smallmoney")]
        public decimal PAST_DUE_PRINC_AMT { get; set; }

        [Key]
        [Column(Order = 23, TypeName = "smallmoney")]
        public decimal CURR_DUE_TRANS_FEE_AMT { get; set; }

        [Key]
        [Column(Order = 24, TypeName = "smallmoney")]
        public decimal CURR_DUE_LIEN_FEE_AMT { get; set; }

        [Key]
        [Column(Order = 25, TypeName = "smallmoney")]
        public decimal CURR_DUE_ACTIVITY_FEE_AMT { get; set; }

        [Key]
        [Column(Order = 26, TypeName = "smallmoney")]
        public decimal CURR_DUE_INTEREST_AMT { get; set; }

        [Key]
        [Column(Order = 27, TypeName = "smallmoney")]
        public decimal CURR_DUE_PRINC_AMT { get; set; }

        [Key]
        [Column(Order = 28, TypeName = "smallmoney")]
        public decimal NEXT_DUE_TRANS_FEE_AMT { get; set; }

        [Key]
        [Column(Order = 29, TypeName = "smallmoney")]
        public decimal NEXT_DUE_LIEN_FEE_AMT { get; set; }

        [Key]
        [Column(Order = 30, TypeName = "smallmoney")]
        public decimal NEXT_DUE_ACTIVITY_FEE_AMT { get; set; }

        [Key]
        [Column(Order = 31, TypeName = "smallmoney")]
        public decimal NEXT_DUE_INTEREST_AMT { get; set; }

        [Key]
        [Column(Order = 32, TypeName = "smallmoney")]
        public decimal NEXT_DUE_PRINC_AMT { get; set; }

        [Key]
        [Column(Order = 33, TypeName = "smallmoney")]
        public decimal NOT_DUE_TRANS_FEE_AMT { get; set; }

        [Key]
        [Column(Order = 34, TypeName = "smallmoney")]
        public decimal NOT_DUE_LIEN_FEE_AMT { get; set; }

        [Key]
        [Column(Order = 35, TypeName = "smallmoney")]
        public decimal NOT_DUE_ACTIVITY_FEE_AMT { get; set; }

        [Key]
        [Column(Order = 36, TypeName = "smallmoney")]
        public decimal NOT_DUE_INTEREST_AMT { get; set; }

        [Key]
        [Column(Order = 37, TypeName = "smallmoney")]
        public decimal NOT_DUE_PRINC_AMT { get; set; }

        [Key]
        [Column(Order = 38)]
        public bool ADD_TO_COLL { get; set; }

        [Key]
        [Column(Order = 39)]
        public bool REM_FROM_COLL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? TOT_TRANS_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? TOT_LIEN_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? TOT_ACTIVITY_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? TOT_INTEREST_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? TOT_PRINC_FEE_AMT { get; set; }

        [Key]
        [Column(Order = 40, TypeName = "smallmoney")]
        public decimal FUNDING_AMT { get; set; }

        [Key]
        [Column(Order = 41)]
        [StringLength(1)]
        public string FUNDING_STATUS_CODE { get; set; }

        public int? FUNDING_ACH_HISTORY_KEY { get; set; }

        public int? FUNDING_LOAN_PAYMENT_KEY { get; set; }

        [Key]
        [Column(Order = 42, TypeName = "smallmoney")]
        public decimal PENDING_SCHED_ACH_AMT { get; set; }

        [Key]
        [Column(Order = 43)]
        public bool IS_INTEREST_REDUCTION_PAYMENT { get; set; }

        [Key]
        [Column(Order = 44)]
        public bool IS_PRINCIPLE_ONLY_PAYMENT { get; set; }

        [Key]
        [Column(Order = 45, TypeName = "smallmoney")]
        public decimal PAST_DUE_CSO_LENDER_COLL_FEE_AMT { get; set; }

        [Key]
        [Column(Order = 46, TypeName = "smallmoney")]
        public decimal PAST_DUE_CSO_LENDER_INTEREST_AMT { get; set; }

        [Key]
        [Column(Order = 47, TypeName = "smallmoney")]
        public decimal CURR_DUE_CSO_LENDER_INTEREST_AMT { get; set; }

        [Key]
        [Column(Order = 48, TypeName = "smallmoney")]
        public decimal NEXT_DUE_CSO_LENDER_INTEREST_AMT { get; set; }

        [Key]
        [Column(Order = 49, TypeName = "smallmoney")]
        public decimal NOT_DUE_CSO_LENDER_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? TOT_PAST_DUE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? TOT_CURR_DUE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? TOT_NEXT_DUE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? TOT_NOT_DUE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? TOT_CSO_LENDER_INTEREST_FEE_AMT { get; set; }

        [Key]
        [Column(Order = 50)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short FUNDING_METHOD { get; set; }

        public int? ACH_PROCESSING_QUEUE_KEY { get; set; }
    }
}
