namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Xmplisa")]
    public partial class Xmplisa
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int mplisakey { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int lkey { get; set; }

        public short? l_LOCATION { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(1)]
        public string xa { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(1)]
        public string LOAN_STATUS { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(1)]
        public string C_LOAN_STATUS { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(1)]
        public string xb { get; set; }

        [Key]
        [Column(Order = 8, TypeName = "smallmoney")]
        public decimal LOAN_BALANCE { get; set; }

        [Key]
        [Column(Order = 9, TypeName = "smallmoney")]
        public decimal C_LOAN_BALANCE { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(1)]
        public string xc { get; set; }

        [Key]
        [Column(Order = 11, TypeName = "smallmoney")]
        public decimal RI_BALANCE { get; set; }

        [Key]
        [Column(Order = 12, TypeName = "smallmoney")]
        public decimal C_RI_BALANCE { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(1)]
        public string xd { get; set; }

        [Key]
        [Column(Order = 14, TypeName = "smallmoney")]
        public decimal PRINC_AMT { get; set; }

        [Key]
        [Column(Order = 15, TypeName = "smallmoney")]
        public decimal C_PRINC_AMT { get; set; }

        [Key]
        [Column(Order = 16)]
        [StringLength(1)]
        public string xe { get; set; }

        [Key]
        [Column(Order = 17, TypeName = "smallmoney")]
        public decimal CASH_AMT { get; set; }

        [Key]
        [Column(Order = 18, TypeName = "smallmoney")]
        public decimal C_CASH_AMT { get; set; }

        [Key]
        [Column(Order = 19)]
        [StringLength(1)]
        public string xf { get; set; }

        [Key]
        [Column(Order = 20, TypeName = "smallmoney")]
        public decimal LOAN_AMT { get; set; }

        [Key]
        [Column(Order = 21, TypeName = "smallmoney")]
        public decimal C_LOAN_AMT { get; set; }

        [Key]
        [Column(Order = 22)]
        [StringLength(1)]
        public string xg { get; set; }

        [Key]
        [Column(Order = 23, TypeName = "smallmoney")]
        public decimal TRANS_FEE_AMT { get; set; }

        [Key]
        [Column(Order = 24, TypeName = "smallmoney")]
        public decimal C_TRANS_FEE_AMT { get; set; }

        [Key]
        [Column(Order = 25)]
        [StringLength(1)]
        public string xh { get; set; }

        [Key]
        [Column(Order = 26, TypeName = "smallmoney")]
        public decimal LIEN_FEE_AMT { get; set; }

        [Key]
        [Column(Order = 27, TypeName = "smallmoney")]
        public decimal C_LIEN_FEE_AMT { get; set; }

        [Key]
        [Column(Order = 28)]
        [StringLength(1)]
        public string xi { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ORIG_DUE_DATE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? C_ORIG_DUE_DATE { get; set; }

        [Key]
        [Column(Order = 29)]
        [StringLength(1)]
        public string xj { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ADJUSTED_DUE_DATE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? C_ADJUSTED_DUE_DATE { get; set; }

        [Key]
        [Column(Order = 30)]
        [StringLength(1)]
        public string xk { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DEFAULT_DATE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? C_DEFAULT_DATE { get; set; }

        [Key]
        [Column(Order = 31)]
        [StringLength(1)]
        public string xl { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? LAST_PAYMENT_DATE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? C_LAST_PAYMENT_DATE { get; set; }

        [Key]
        [Column(Order = 32)]
        [StringLength(1)]
        public string xm { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NEXT_DUE_DATE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? C_NEXT_DUE_DATE { get; set; }

        [Key]
        [Column(Order = 33)]
        [StringLength(1)]
        public string xn { get; set; }

        [Key]
        [Column(Order = 34)]
        public bool DEFAULTED { get; set; }

        [Key]
        [Column(Order = 35)]
        public bool C_DEFAULTED { get; set; }

        [Key]
        [Column(Order = 36)]
        [StringLength(1)]
        public string xo { get; set; }

        [Key]
        [Column(Order = 37, TypeName = "smallmoney")]
        public decimal LAST_PAYMENT_AMT { get; set; }

        [Key]
        [Column(Order = 38, TypeName = "smallmoney")]
        public decimal C_LAST_PAYMENT_AMT { get; set; }

        [Key]
        [Column(Order = 39)]
        [StringLength(1)]
        public string xp { get; set; }

        [Key]
        [Column(Order = 40, TypeName = "smallmoney")]
        public decimal NEXT_DUE_AMT { get; set; }

        [Key]
        [Column(Order = 41, TypeName = "smallmoney")]
        public decimal C_NEXT_DUE_AMT { get; set; }

        [Key]
        [Column(Order = 42)]
        [StringLength(1)]
        public string xq { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? PENDING_SCHED_ACH_SENT { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? C_PENDING_SCHED_ACH_SENT { get; set; }

        [Key]
        [Column(Order = 43)]
        [StringLength(1)]
        public string xr { get; set; }

        [Key]
        [Column(Order = 44, TypeName = "smallmoney")]
        public decimal PENDING_SCHED_ACH_AMT { get; set; }

        [Key]
        [Column(Order = 45, TypeName = "smallmoney")]
        public decimal C_PENDING_SCHED_ACH_AMT { get; set; }

        [Key]
        [Column(Order = 46)]
        [StringLength(1)]
        public string xs { get; set; }

        [Key]
        [Column(Order = 47, TypeName = "smallmoney")]
        public decimal PAYMENT_PAST_DUE_BAL { get; set; }

        [Key]
        [Column(Order = 48, TypeName = "smallmoney")]
        public decimal C_PAYMENT_PAST_DUE_BAL { get; set; }

        [Key]
        [Column(Order = 49)]
        [StringLength(1)]
        public string xt { get; set; }

        [Key]
        [Column(Order = 50, TypeName = "smallmoney")]
        public decimal PAYMENT_DUE_BAL { get; set; }

        [Key]
        [Column(Order = 51, TypeName = "smallmoney")]
        public decimal C_PAYMENT_DUE_BAL { get; set; }

        [Key]
        [Column(Order = 52)]
        [StringLength(1)]
        public string xu { get; set; }

        [Key]
        [Column(Order = 53, TypeName = "smallmoney")]
        public decimal NSF_FEE_PAST_DUE_BAL { get; set; }

        [Key]
        [Column(Order = 54, TypeName = "smallmoney")]
        public decimal C_NSF_FEE_PAST_DUE_BAL { get; set; }

        [Key]
        [Column(Order = 55)]
        [StringLength(1)]
        public string xv { get; set; }

        [Key]
        [Column(Order = 56, TypeName = "smallmoney")]
        public decimal COLL_FEE_PAST_DUE_BAL { get; set; }

        [Key]
        [Column(Order = 57, TypeName = "smallmoney")]
        public decimal C_COLL_FEE_PAST_DUE_BAL { get; set; }

        [Key]
        [Column(Order = 58)]
        [StringLength(1)]
        public string xw { get; set; }

        [Key]
        [Column(Order = 59, TypeName = "smallmoney")]
        public decimal LEGAL_FEE_PAST_DUE_BAL { get; set; }

        [Key]
        [Column(Order = 60, TypeName = "smallmoney")]
        public decimal C_LEGAL_FEE_PAST_DUE_BAL { get; set; }

        [Key]
        [Column(Order = 61)]
        [StringLength(1)]
        public string xx { get; set; }

        [Key]
        [Column(Order = 62, TypeName = "smallmoney")]
        public decimal LOAN_FEE_DUE_BAL { get; set; }

        [Key]
        [Column(Order = 63, TypeName = "smallmoney")]
        public decimal C_LOAN_FEE_DUE_BAL { get; set; }

        [Key]
        [Column(Order = 64)]
        [StringLength(1)]
        public string xy { get; set; }

        [Key]
        [Column(Order = 65, TypeName = "smallmoney")]
        public decimal TRANS_FEE_DUE_BAL { get; set; }

        [Key]
        [Column(Order = 66, TypeName = "smallmoney")]
        public decimal C_TRANS_FEE_DUE_BAL { get; set; }

        [Key]
        [Column(Order = 67)]
        [StringLength(1)]
        public string xz { get; set; }

        [Key]
        [Column(Order = 68, TypeName = "smallmoney")]
        public decimal INTEREST_DUE_BAL { get; set; }

        [Key]
        [Column(Order = 69, TypeName = "smallmoney")]
        public decimal C_INTEREST_DUE_BAL { get; set; }

        [Key]
        [Column(Order = 70)]
        [StringLength(1)]
        public string x0 { get; set; }

        [Key]
        [Column(Order = 71, TypeName = "smallmoney")]
        public decimal INSURANCE_DUE_BAL { get; set; }

        [Key]
        [Column(Order = 72, TypeName = "smallmoney")]
        public decimal C_INSURANCE_DUE_BAL { get; set; }

        [Key]
        [Column(Order = 73)]
        [StringLength(1)]
        public string x1 { get; set; }

        [Key]
        [Column(Order = 74, TypeName = "smallmoney")]
        public decimal PRINC_DUE_BAL { get; set; }

        [Key]
        [Column(Order = 75, TypeName = "smallmoney")]
        public decimal C_PRINC_DUE_BAL { get; set; }

        [Key]
        [Column(Order = 76)]
        [StringLength(1)]
        public string x2 { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? TRANS_FEE_COLORADO_POSTPONE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? C_TRANS_FEE_COLORADO_POSTPONE_AMT { get; set; }

        [Key]
        [Column(Order = 77)]
        [StringLength(1)]
        public string x3 { get; set; }

        [Key]
        [Column(Order = 78, TypeName = "smallmoney")]
        public decimal CAB_INTEREST_DUE_BAL { get; set; }

        [Key]
        [Column(Order = 79, TypeName = "smallmoney")]
        public decimal C_CAB_INTEREST_DUE_BAL { get; set; }

        [Key]
        [Column(Order = 80)]
        [StringLength(1)]
        public string x4 { get; set; }

        [Key]
        [Column(Order = 81, TypeName = "smallmoney")]
        public decimal CAB_COLL_FEE_PAST_DUE_BAL { get; set; }

        [Key]
        [Column(Order = 82, TypeName = "smallmoney")]
        public decimal C_CAB_COLL_FEE_PAST_DUE_BAL { get; set; }

        [Key]
        [Column(Order = 83)]
        [StringLength(1)]
        public string x5 { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? INVENTORY_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? C_INVENTORY_AMT { get; set; }

        [Key]
        [Column(Order = 84)]
        [StringLength(1)]
        public string x6 { get; set; }

        [Key]
        [Column(Order = 85)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CYCLES_PAST_DUE { get; set; }

        [Key]
        [Column(Order = 86)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int C_CYCLES_PAST_DUE { get; set; }

        [Key]
        [Column(Order = 87)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short C_ADJ_CNT_INT { get; set; }

        [Key]
        [Column(Order = 88)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short C_ADJ_CNT_PENDING_ACH_INT { get; set; }

        [Key]
        [Column(Order = 89)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short C_ADJ_CNT_LP_MPAY_RECORD { get; set; }

        [Key]
        [Column(Order = 90)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MPAY_LOAN_IN_SYNC_ADJ_KEY { get; set; }

        [Key]
        [Column(Order = 91)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LOAN_KEY { get; set; }

        [Key]
        [Column(Order = 92, TypeName = "smalldatetime")]
        public DateTime de { get; set; }
    }
}
