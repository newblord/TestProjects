namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MPayLoanInSyncAdj")]
    public partial class MPayLoanInSyncAdj
    {
        [Key]
        public int MPAY_LOAN_IN_SYNC_ADJ_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        public int LOAN_KEY { get; set; }

        [Required]
        [StringLength(1)]
        public string LOAN_STATUS { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal LOAN_BALANCE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal RI_BALANCE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PRINC_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CASH_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal TRANS_FEE_AMT { get; set; }

        public bool CHARGE_TRANS_FEE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal LIEN_FEE_AMT { get; set; }

        public bool CHARGE_LIEN_FEE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ORIG_DUE_DATE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ADJUSTED_DUE_DATE { get; set; }

        public bool DEFAULTED { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DEFAULT_DATE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal LAST_PAYMENT_AMT { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? LAST_PAYMENT_DATE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NEXT_DUE_DATE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NEXT_DUE_AMT { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? PENDING_SCHED_ACH_SENT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PENDING_SCHED_ACH_AMT { get; set; }

        [Required]
        [StringLength(1)]
        public string C_LOAN_STATUS { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_LOAN_BALANCE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_RI_BALANCE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_PRINC_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_CASH_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_TRANS_FEE_AMT { get; set; }

        public bool C_CHARGE_TRANS_FEE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_LIEN_FEE_AMT { get; set; }

        public bool C_CHARGE_LIEN_FEE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? C_ORIG_DUE_DATE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? C_ADJUSTED_DUE_DATE { get; set; }

        public bool C_DEFAULTED { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? C_DEFAULT_DATE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_LAST_PAYMENT_AMT { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? C_LAST_PAYMENT_DATE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? C_NEXT_DUE_DATE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_NEXT_DUE_AMT { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? C_PENDING_SCHED_ACH_SENT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_PENDING_SCHED_ACH_AMT { get; set; }

        public int C_ADJ_CNT_INT { get; set; }

        public int C_ADJ_CNT_PENDING_ACH_INT { get; set; }

        public int C_ADJ_CNT_LP_MPAY_RECORD { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? TRANS_FEE_COLORADO_POSTPONE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? C_TRANS_FEE_COLORADO_POSTPONE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal COLL_FEE_PAST_DUE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal LEGAL_FEE_PAST_DUE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal LOAN_FEE_DUE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal TRANS_FEE_DUE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal INTEREST_DUE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PRINC_DUE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_COLL_FEE_PAST_DUE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_LEGAL_FEE_PAST_DUE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_LOAN_FEE_DUE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_TRANS_FEE_DUE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_INTEREST_DUE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_PRINC_DUE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PAYMENT_DUE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PAYMENT_PAST_DUE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_PAYMENT_DUE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_PAYMENT_PAST_DUE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? INVENTORY_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? C_INVENTORY_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CAB_INTEREST_DUE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CAB_COLL_FEE_PAST_DUE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_CAB_INTEREST_DUE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_CAB_COLL_FEE_PAST_DUE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal LOAN_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_LOAN_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NSF_FEE_PAST_DUE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_NSF_FEE_PAST_DUE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? REBATE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? C_REBATE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? DISC_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? C_DISC_AMT { get; set; }

        public bool? IS_IN_LEGAL_STATUS { get; set; }

        public int CYCLES_PAST_DUE { get; set; }

        public int C_CYCLES_PAST_DUE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PENDING_PMT_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_PENDING_PMT_AMT { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PENDING_PMT_DATE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? C_PENDING_PMT_DATE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PENDING_PMT_PRINC { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_PENDING_PMT_PRINC { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PENDING_PMT_INTEREST_CAP { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_PENDING_PMT_INTEREST_CAP { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PENDING_PMT_CAB_INTEREST_CAP { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_PENDING_PMT_CAB_INTEREST_CAP { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal INSURANCE_DUE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_INSURANCE_DUE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal DUE_DATE_PAYMENT_QUEUE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_DUE_DATE_PAYMENT_QUEUE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal INVENTORY_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_INVENTORY_BAL { get; set; }
    }
}
