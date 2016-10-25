namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MPayRecalcLoanPaymentAdj")]
    public partial class MPayRecalcLoanPaymentAdj
    {
        [Key]
        public int MPAY_RECALC_LOAN_PAYMENT_ADJ_KEY { get; set; }

        public int LOAN_PAYMENT_KEY { get; set; }

        public int LOAN_KEY { get; set; }

        [Required]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        public byte? TRANSCODE { get; set; }

        public byte C_TRANSCODE { get; set; }

        public bool ADD_TO_COLL { get; set; }

        public bool C_ADD_TO_COLL { get; set; }

        public bool REM_FROM_COLL { get; set; }

        public bool C_REM_FROM_COLL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PENDING_SCHED_ACH_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_PENDING_SCHED_ACH_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal COLL_FEE_PAST_DUE_PAID { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_COLL_FEE_PAST_DUE_PAID { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal LEGAL_FEE_PAST_DUE_PAID { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_LEGAL_FEE_PAST_DUE_PAID { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal LOAN_FEE_DUE_PAID { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_LOAN_FEE_DUE_PAID { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal TRANS_FEE_DUE_PAID { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_TRANS_FEE_DUE_PAID { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal INTEREST_DUE_PAID { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_INTEREST_DUE_PAID { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PRINC_DUE_PAID { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_PRINC_DUE_PAID { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PAYMENT_DUE_PAID { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_PAYMENT_DUE_PAID { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PAYMENT_PAST_DUE_PAID { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_PAYMENT_PAST_DUE_PAID { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CAB_COLL_FEE_PAST_DUE_PAID { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_CAB_COLL_FEE_PAST_DUE_PAID { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CAB_INTEREST_DUE_PAID { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_CAB_INTEREST_DUE_PAID { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NSF_FEE_PAST_DUE_PAID { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_NSF_FEE_PAST_DUE_PAID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? LPDD_ORIG_DUE_DATE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? C_LPDD_ORIG_DUE_DATE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? LPDD_ADJUSTED_DUE_DATE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? C_LPDD_ADJUSTED_DUE_DATE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal LPDD_PAST_DUE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_LPDD_PAST_DUE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal LPDD_COLLECTIONS_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_LPDD_COLLECTIONS_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal LPDD_PENDING_ACH_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_LPDD_PENDING_ACH_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal INSURANCE_DUE_PAID { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_INSURANCE_DUE_PAID { get; set; }
    }
}
