namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SPayLoanInSyncAdj")]
    public partial class SPayLoanInSyncAdj
    {
        [Key]
        public int SPAY_LOAN_IN_SYNC_ADJ_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        public int LOAN_KEY { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal LOAN_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PRINC_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CASH_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal LOAN_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal LIEN_FEE_AMT { get; set; }

        public bool CHARGE_LIEN_FEE { get; set; }

        [Required]
        [StringLength(1)]
        public string LOAN_STATUS { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal LOAN_BALANCE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal RI_BALANCE { get; set; }

        public bool DEFAULTED { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DEFAULT_DATE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? PENDING_SCHED_ACH_SENT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PENDING_SCHED_ACH_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal COLL_FEE_BALANCE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal LEGAL_FEE_BALANCE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal LOAN_FEE_BALANCE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal INTEREST_BALANCE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PRINC_BALANCE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal TOTAL_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? INVENTORY_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_LOAN_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_PRINC_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_CASH_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_LOAN_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_LIEN_FEE_AMT { get; set; }

        public bool C_CHARGE_LIEN_FEE { get; set; }

        [Required]
        [StringLength(1)]
        public string C_LOAN_STATUS { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_LOAN_BALANCE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_RI_BALANCE { get; set; }

        public bool C_DEFAULTED { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? C_DEFAULT_DATE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? C_PENDING_SCHED_ACH_SENT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_PENDING_SCHED_ACH_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_COLL_FEE_BALANCE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_LEGAL_FEE_BALANCE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_LOAN_FEE_BALANCE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_INTEREST_BALANCE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_PRINC_BALANCE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_TOTAL_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? C_INVENTORY_AMT { get; set; }

        public int C_ADJ_CNT_INT { get; set; }

        public int C_ADJ_CNT_LP_SPAY_RECORD { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CAB_INTEREST_BALANCE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal TOT_CAB_INTEREST { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_CAB_INTEREST_BALANCE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_TOT_CAB_INTEREST { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CAB_LENDER_COLL_FEE_PAST_DUE_BALANCE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_CAB_LENDER_COLL_FEE_PAST_DUE_BALANCE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NSF_FEE_DUE_BALANCE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_NSF_FEE_DUE_BALANCE { get; set; }

        public bool? IS_IN_LEGAL_STATUS { get; set; }
    }
}
