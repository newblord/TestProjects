namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OpenEndRecalcLoanPaymentAdj")]
    public partial class OpenEndRecalcLoanPaymentAdj
    {
        [Key]
        public int OPEN_END_RECALC_LOAN_PAYMENT_ADJ_KEY { get; set; }

        public int LOAN_PAYMENT_KEY { get; set; }

        public int LOAN_KEY { get; set; }

        [Required]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        public byte? TRANSCODE { get; set; }

        public byte C_TRANSCODE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PAST_DUE_TRANS_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_PAST_DUE_TRANS_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PAST_DUE_LIEN_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_PAST_DUE_LIEN_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PAST_DUE_ACTIVITY_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_PAST_DUE_ACTIVITY_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PAST_DUE_COLL_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_PAST_DUE_COLL_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PAST_DUE_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_PAST_DUE_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PAST_DUE_PRINC_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_PAST_DUE_PRINC_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PAST_DUE_CSO_LENDER_COLL_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_PAST_DUE_CSO_LENDER_COLL_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PAST_DUE_CSO_LENDER_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_PAST_DUE_CSO_LENDER_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CURR_DUE_TRANS_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_CURR_DUE_TRANS_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CURR_DUE_LIEN_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_CURR_DUE_LIEN_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CURR_DUE_ACTIVITY_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_CURR_DUE_ACTIVITY_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CURR_DUE_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_CURR_DUE_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CURR_DUE_PRINC_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_CURR_DUE_PRINC_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CURR_DUE_CSO_LENDER_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_CURR_DUE_CSO_LENDER_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NEXT_DUE_TRANS_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_NEXT_DUE_TRANS_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NEXT_DUE_LIEN_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_NEXT_DUE_LIEN_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NEXT_DUE_ACTIVITY_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_NEXT_DUE_ACTIVITY_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NEXT_DUE_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_NEXT_DUE_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NEXT_DUE_PRINC_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_NEXT_DUE_PRINC_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NEXT_DUE_CSO_LENDER_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_NEXT_DUE_CSO_LENDER_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NOT_DUE_TRANS_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_NOT_DUE_TRANS_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NOT_DUE_LIEN_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_NOT_DUE_LIEN_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NOT_DUE_ACTIVITY_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_NOT_DUE_ACTIVITY_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NOT_DUE_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_NOT_DUE_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NOT_DUE_PRINC_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_NOT_DUE_PRINC_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NOT_DUE_CSO_LENDER_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_NOT_DUE_CSO_LENDER_INTEREST_AMT { get; set; }

        public bool ADD_TO_COLL { get; set; }

        public bool C_ADD_TO_COLL { get; set; }

        public bool REM_FROM_COLL { get; set; }

        public bool C_REM_FROM_COLL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PENDING_SCHED_ACH_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_PENDING_SCHED_ACH_AMT { get; set; }

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
    }
}
