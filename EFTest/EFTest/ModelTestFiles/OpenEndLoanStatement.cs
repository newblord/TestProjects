namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OpenEndLoanStatement")]
    public partial class OpenEndLoanStatement
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OpenEndLoanStatement()
        {
            LoanDueDateChanges = new HashSet<LoanDueDateChange>();
            OpenEndInterests = new HashSet<OpenEndInterest>();
            OpenEndRecalcStatementAdjs = new HashSet<OpenEndRecalcStatementAdj>();
        }

        [Key]
        public int OPEN_END_LOAN_STMT_KEY { get; set; }

        public int TRANS_DETAIL_KEY { get; set; }

        public int LOAN_PAYMENT_KEY { get; set; }

        public int LOAN_KEY { get; set; }

        public int CUSTOMER_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        public short LOCATION { get; set; }

        public byte STATEMENT_NUM { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CREDIT_LIMIT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CREDIT_AVAIL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal AVG_DAILY_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PER_FIN_CHARGE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? EFFECTIVE_APR { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime START_DATE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal START_BALANCE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal START_PRINC { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime END_DATE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal END_BALANCE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal END_PRINC { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PAST_DUE_AMT { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? PAST_DUE_DATE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CURR_DUE_TRANS_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CURR_DUE_ACTIVITY_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CURR_DUE_COLL_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CURR_DUE_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CURR_DUE_PRINC_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CURR_DUE_AMT { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime CURR_DUE_DATE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NEXT_DUE_TRANS_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NEXT_DUE_ACTIVITY_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NEXT_DUE_COLL_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NEXT_DUE_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NEXT_DUE_PRINC_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NEXT_DUE_AMT { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime NEXT_DUE_DATE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NEW_TRANS_FEES { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NEW_LIEN_FEES { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NEW_ACTIVITY_FEES { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NEW_COLL_FEES { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NEW_INTEREST { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NEW_LOAN_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NEW_PAST_DUE_PAYMENTS { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NEW_FEE_PAYMENTS { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NEW_INTEREST_PAYMENTS { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NEW_PRINC_PAYMENTS { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NEW_PAYMENTS { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal TOT_TRANS_FEES { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal TOT_LIEN_FEES { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal TOT_ACTIVITY_FEES { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal TOT_COLL_FEES { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal TOT_INTEREST { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal TOT_LOAN_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal TOT_PAYMENTS { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal YTD_TRANS_FEES_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal YTD_ACTIVITY_FEES_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal YTD_COLL_FEES_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal YTD_INTEREST_AMT { get; set; }

        public byte MAIL_STATUS { get; set; }

        public bool MAILED_WITH_IMAGE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CURR_DUE_CSO_LENDER_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NEXT_DUE_CSO_LENDER_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NEW_CSO_LENDER_INTEREST { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal TOT_CSO_LENDER_INTEREST { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal YTD_CSO_LENDER_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NEW_CSO_LENDER_INTEREST_PAYMENTS { get; set; }

        public bool IS_FINAL_STATEMENT { get; set; }

        public DateTime ADJUSTED_DUE_DATE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal FINAL_EST_DUE_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal FINAL_EST_DUE_CSO_LENDER_INTEREST_AMT { get; set; }

        public int? OPEN_END_LOAN_STATEMENT_SNAPSHOT_KEY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanDueDateChange> LoanDueDateChanges { get; set; }

        public virtual LoanPayment LoanPayment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OpenEndInterest> OpenEndInterests { get; set; }

        public virtual OpenEndLoanStatementSnapshot OpenEndLoanStatementSnapshot { get; set; }

        public virtual TransDetail TransDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OpenEndRecalcStatementAdj> OpenEndRecalcStatementAdjs { get; set; }
    }
}
