namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoanPaymentOpenEnd")]
    public partial class LoanPaymentOpenEnd
    {
        [Key]
        public int LOAN_PAYMENT_OPEN_END_KEY { get; set; }

        public int LOAN_PAYMENT_KEY { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PAST_DUE_TRANS_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PAST_DUE_LIEN_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PAST_DUE_ACTIVITY_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PAST_DUE_COLL_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PAST_DUE_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PAST_DUE_PRINC_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CURR_DUE_TRANS_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CURR_DUE_LIEN_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CURR_DUE_ACTIVITY_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CURR_DUE_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CURR_DUE_PRINC_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NEXT_DUE_TRANS_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NEXT_DUE_LIEN_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NEXT_DUE_ACTIVITY_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NEXT_DUE_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NEXT_DUE_PRINC_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NOT_DUE_TRANS_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NOT_DUE_LIEN_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NOT_DUE_ACTIVITY_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NOT_DUE_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NOT_DUE_PRINC_AMT { get; set; }

        public bool ADD_TO_COLL { get; set; }

        public bool REM_FROM_COLL { get; set; }

        [Column(TypeName = "smallmoney")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? TOT_TRANS_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? TOT_LIEN_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? TOT_ACTIVITY_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? TOT_INTEREST_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? TOT_PRINC_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal FUNDING_AMT { get; set; }

        [Required]
        [StringLength(1)]
        public string FUNDING_STATUS_CODE { get; set; }

        public int? FUNDING_ACH_HISTORY_KEY { get; set; }

        public int? FUNDING_LOAN_PAYMENT_KEY { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PENDING_SCHED_ACH_AMT { get; set; }

        public bool IS_INTEREST_REDUCTION_PAYMENT { get; set; }

        public bool IS_PRINCIPLE_ONLY_PAYMENT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PAST_DUE_CSO_LENDER_COLL_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PAST_DUE_CSO_LENDER_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CURR_DUE_CSO_LENDER_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NEXT_DUE_CSO_LENDER_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NOT_DUE_CSO_LENDER_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? TOT_PAST_DUE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? TOT_CURR_DUE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? TOT_NEXT_DUE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? TOT_NOT_DUE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? TOT_CSO_LENDER_INTEREST_FEE_AMT { get; set; }

        public short FUNDING_METHOD { get; set; }

        public int? ACH_PROCESSING_QUEUE_KEY { get; set; }

        public virtual LoanPayment LoanPayment { get; set; }
    }
}
