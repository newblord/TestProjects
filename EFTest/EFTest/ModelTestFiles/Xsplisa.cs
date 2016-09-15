namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Xsplisa")]
    public partial class Xsplisa
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int splisakey { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int lkey { get; set; }

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
        [Column(Order = 5, TypeName = "smallmoney")]
        public decimal LOAN_AMT { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "smallmoney")]
        public decimal C_LOAN_AMT { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(1)]
        public string xb { get; set; }

        [Key]
        [Column(Order = 8, TypeName = "smallmoney")]
        public decimal PRINC_AMT { get; set; }

        [Key]
        [Column(Order = 9, TypeName = "smallmoney")]
        public decimal C_PRINC_AMT { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(1)]
        public string xc { get; set; }

        [Key]
        [Column(Order = 11, TypeName = "smallmoney")]
        public decimal CASH_AMT { get; set; }

        [Key]
        [Column(Order = 12, TypeName = "smallmoney")]
        public decimal C_CASH_AMT { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(1)]
        public string xd { get; set; }

        [Key]
        [Column(Order = 14, TypeName = "smallmoney")]
        public decimal LOAN_FEE_AMT { get; set; }

        [Key]
        [Column(Order = 15, TypeName = "smallmoney")]
        public decimal C_LOAN_FEE_AMT { get; set; }

        [Key]
        [Column(Order = 16)]
        [StringLength(1)]
        public string xe { get; set; }

        [Key]
        [Column(Order = 17, TypeName = "smallmoney")]
        public decimal LIEN_FEE_AMT { get; set; }

        [Key]
        [Column(Order = 18, TypeName = "smallmoney")]
        public decimal C_LIEN_FEE_AMT { get; set; }

        [Key]
        [Column(Order = 19)]
        [StringLength(1)]
        public string xf { get; set; }

        [Key]
        [Column(Order = 20)]
        [StringLength(1)]
        public string LOAN_STATUS { get; set; }

        [Key]
        [Column(Order = 21)]
        [StringLength(1)]
        public string C_LOAN_STATUS { get; set; }

        [Key]
        [Column(Order = 22)]
        [StringLength(1)]
        public string xg { get; set; }

        [Key]
        [Column(Order = 23, TypeName = "smallmoney")]
        public decimal LOAN_BALANCE { get; set; }

        [Key]
        [Column(Order = 24, TypeName = "smallmoney")]
        public decimal C_LOAN_BALANCE { get; set; }

        [Key]
        [Column(Order = 25)]
        [StringLength(1)]
        public string xh { get; set; }

        [Key]
        [Column(Order = 26, TypeName = "smallmoney")]
        public decimal RI_BALANCE { get; set; }

        [Key]
        [Column(Order = 27, TypeName = "smallmoney")]
        public decimal C_RI_BALANCE { get; set; }

        [Key]
        [Column(Order = 28)]
        [StringLength(1)]
        public string xi { get; set; }

        [Key]
        [Column(Order = 29)]
        public bool DEFAULTED { get; set; }

        [Key]
        [Column(Order = 30)]
        public bool C_DEFAULTED { get; set; }

        [Key]
        [Column(Order = 31)]
        [StringLength(1)]
        public string xj { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DEFAULT_DATE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? C_DEFAULT_DATE { get; set; }

        [Key]
        [Column(Order = 32)]
        [StringLength(1)]
        public string xk { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? PENDING_SCHED_ACH_SENT { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? C_PENDING_SCHED_ACH_SENT { get; set; }

        [Key]
        [Column(Order = 33)]
        [StringLength(1)]
        public string xl { get; set; }

        [Key]
        [Column(Order = 34, TypeName = "smallmoney")]
        public decimal PENDING_SCHED_ACH_AMT { get; set; }

        [Key]
        [Column(Order = 35, TypeName = "smallmoney")]
        public decimal C_PENDING_SCHED_ACH_AMT { get; set; }

        [Key]
        [Column(Order = 36)]
        [StringLength(1)]
        public string xm { get; set; }

        [Key]
        [Column(Order = 37, TypeName = "smallmoney")]
        public decimal COLL_FEE_BALANCE { get; set; }

        [Key]
        [Column(Order = 38, TypeName = "smallmoney")]
        public decimal C_COLL_FEE_BALANCE { get; set; }

        [Key]
        [Column(Order = 39)]
        [StringLength(1)]
        public string xn { get; set; }

        [Key]
        [Column(Order = 40, TypeName = "smallmoney")]
        public decimal LEGAL_FEE_BALANCE { get; set; }

        [Key]
        [Column(Order = 41, TypeName = "smallmoney")]
        public decimal C_LEGAL_FEE_BALANCE { get; set; }

        [Key]
        [Column(Order = 42)]
        [StringLength(1)]
        public string xo { get; set; }

        [Key]
        [Column(Order = 43, TypeName = "smallmoney")]
        public decimal LOAN_FEE_BALANCE { get; set; }

        [Key]
        [Column(Order = 44, TypeName = "smallmoney")]
        public decimal C_LOAN_FEE_BALANCE { get; set; }

        [Key]
        [Column(Order = 45)]
        [StringLength(1)]
        public string xp { get; set; }

        [Key]
        [Column(Order = 46, TypeName = "smallmoney")]
        public decimal INTEREST_BALANCE { get; set; }

        [Key]
        [Column(Order = 47, TypeName = "smallmoney")]
        public decimal C_INTEREST_BALANCE { get; set; }

        [Key]
        [Column(Order = 48)]
        [StringLength(1)]
        public string xq { get; set; }

        [Key]
        [Column(Order = 49, TypeName = "smallmoney")]
        public decimal PRINC_BALANCE { get; set; }

        [Key]
        [Column(Order = 50, TypeName = "smallmoney")]
        public decimal C_PRINC_BALANCE { get; set; }

        [Key]
        [Column(Order = 51)]
        [StringLength(1)]
        public string xr { get; set; }

        [Key]
        [Column(Order = 52, TypeName = "smallmoney")]
        public decimal TOTAL_INTEREST_AMT { get; set; }

        [Key]
        [Column(Order = 53, TypeName = "smallmoney")]
        public decimal C_TOTAL_INTEREST_AMT { get; set; }

        [Key]
        [Column(Order = 54)]
        [StringLength(1)]
        public string xs { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? INVENTORY_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? C_INVENTORY_AMT { get; set; }

        [Key]
        [Column(Order = 55)]
        [StringLength(1)]
        public string xt { get; set; }

        [Key]
        [Column(Order = 56)]
        public bool CHARGE_LIEN_FEE { get; set; }

        [Key]
        [Column(Order = 57)]
        public bool C_CHARGE_LIEN_FEE { get; set; }

        [Key]
        [Column(Order = 58)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short C_ADJ_CNT_INT { get; set; }

        [Key]
        [Column(Order = 59)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short C_ADJ_CNT_LP_SPAY_RECORD { get; set; }

        [Key]
        [Column(Order = 60)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SPAY_LOAN_IN_SYNC_ADJ_KEY { get; set; }

        [Key]
        [Column(Order = 61)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LOAN_KEY { get; set; }
    }
}
