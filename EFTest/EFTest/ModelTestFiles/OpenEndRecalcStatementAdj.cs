namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OpenEndRecalcStatementAdj")]
    public partial class OpenEndRecalcStatementAdj
    {
        [Key]
        public int OPEN_END_RECALC_STATEMENT_ADJ_KEY { get; set; }

        public int OPEN_END_LOAN_STMT_KEY { get; set; }

        [Required]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CREDIT_LIMIT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_CREDIT_LIMIT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CREDIT_AVAIL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_CREDIT_AVAIL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal AVG_DAILY_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_AVG_DAILY_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PER_FIN_CHARGE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_PER_FIN_CHARGE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? EFFECTIVE_APR { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? C_EFFECTIVE_APR { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime START_DATE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime C_START_DATE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal START_BALANCE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_START_BALANCE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal START_PRINC { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_START_PRINC { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime END_DATE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime C_END_DATE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal END_BALANCE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_END_BALANCE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal END_PRINC { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_END_PRINC { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PAST_DUE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_PAST_DUE_AMT { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? PAST_DUE_DATE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? C_PAST_DUE_DATE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CURR_DUE_TRANS_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_CURR_DUE_TRANS_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CURR_DUE_ACTIVITY_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_CURR_DUE_ACTIVITY_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CURR_DUE_COLL_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_CURR_DUE_COLL_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CURR_DUE_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_CURR_DUE_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CURR_DUE_PRINC_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_CURR_DUE_PRINC_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CURR_DUE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_CURR_DUE_AMT { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime CURR_DUE_DATE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime C_CURR_DUE_DATE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NEXT_DUE_TRANS_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_NEXT_DUE_TRANS_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NEXT_DUE_ACTIVITY_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_NEXT_DUE_ACTIVITY_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NEXT_DUE_COLL_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_NEXT_DUE_COLL_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NEXT_DUE_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_NEXT_DUE_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NEXT_DUE_PRINC_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_NEXT_DUE_PRINC_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NEXT_DUE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_NEXT_DUE_AMT { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime NEXT_DUE_DATE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime C_NEXT_DUE_DATE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NEW_TRANS_FEES { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_NEW_TRANS_FEES { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NEW_LIEN_FEES { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_NEW_LIEN_FEES { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NEW_ACTIVITY_FEES { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_NEW_ACTIVITY_FEES { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NEW_COLL_FEES { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_NEW_COLL_FEES { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NEW_INTEREST { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_NEW_INTEREST { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NEW_LOAN_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_NEW_LOAN_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NEW_PAST_DUE_PAYMENTS { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_NEW_PAST_DUE_PAYMENTS { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NEW_FEE_PAYMENTS { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_NEW_FEE_PAYMENTS { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NEW_INTEREST_PAYMENTS { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_NEW_INTEREST_PAYMENTS { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NEW_PRINC_PAYMENTS { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_NEW_PRINC_PAYMENTS { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NEW_PAYMENTS { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_NEW_PAYMENTS { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal TOT_TRANS_FEES { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_TOT_TRANS_FEES { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal TOT_LIEN_FEES { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_TOT_LIEN_FEES { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal TOT_ACTIVITY_FEES { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_TOT_ACTIVITY_FEES { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal TOT_COLL_FEES { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_TOT_COLL_FEES { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal TOT_INTEREST { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_TOT_INTEREST { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal TOT_LOAN_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_TOT_LOAN_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal TOT_PAYMENTS { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_TOT_PAYMENTS { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal YTD_TRANS_FEES_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_YTD_TRANS_FEES_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal YTD_ACTIVITY_FEES_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_YTD_ACTIVITY_FEES_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal YTD_COLL_FEES_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_YTD_COLL_FEES_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal YTD_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_YTD_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CURR_DUE_CSO_LENDER_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_CURR_DUE_CSO_LENDER_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NEXT_DUE_CSO_LENDER_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_NEXT_DUE_CSO_LENDER_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NEW_CSO_LENDER_INTEREST { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_NEW_CSO_LENDER_INTEREST { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal TOT_CSO_LENDER_INTEREST { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_TOT_CSO_LENDER_INTEREST { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal YTD_CSO_LENDER_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_YTD_CSO_LENDER_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NEW_CSO_LENDER_INTEREST_PAYMENTS { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_NEW_CSO_LENDER_INTEREST_PAYMENTS { get; set; }

        public bool IS_FINAL_STATEMENT { get; set; }

        public bool C_IS_FINAL_STATEMENT { get; set; }

        public DateTime ADJUSTED_DUE_DATE { get; set; }

        public DateTime C_ADJUSTED_DUE_DATE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal FINAL_EST_DUE_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_FINAL_EST_DUE_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal FINAL_EST_DUE_CSO_LENDER_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal C_FINAL_EST_DUE_CSO_LENDER_INTEREST_AMT { get; set; }

        public virtual OpenEndLoanStatement OpenEndLoanStatement { get; set; }
    }
}
