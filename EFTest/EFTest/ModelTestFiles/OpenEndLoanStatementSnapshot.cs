namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OpenEndLoanStatementSnapshot")]
    public partial class OpenEndLoanStatementSnapshot
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OpenEndLoanStatementSnapshot()
        {
            OpenEndLoanStatements = new HashSet<OpenEndLoanStatement>();
            OpenEndRecalcStatementSnapshots = new HashSet<OpenEndRecalcStatementSnapshot>();
        }

        [Key]
        public int OPEN_END_LOAN_STATEMENT_SNAPSHOT_KEY { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PAST_DUE_TRANS_FEE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PAST_DUE_LIEN_FEE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PAST_DUE_CAB_FEE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PAST_DUE_COLL_FEE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PAST_DUE_CAB_LENDER_COLL_FEE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PAST_DUE_INTEREST_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PAST_DUE_CAB_LENDER_INTEREST_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PAST_DUE_PRINC_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CURR_DUE_TRANS_FEE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CURR_DUE_LIEN_FEE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CURR_DUE_CAB_FEE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CURR_DUE_INTEREST_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CURR_DUE_CAB_LENDER_INTEREST_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CURR_DUE_PRINC_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NEXT_DUE_TRANS_FEE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NEXT_DUE_LIEN_FEE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NEXT_DUE_CAB_FEE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NEXT_DUE_INTEREST_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NEXT_DUE_CAB_LENDER_INTEREST_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NEXT_DUE_PRINC_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NOT_DUE_TRANS_FEE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NOT_DUE_LIEN_FEE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NOT_DUE_CAB_FEE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NOT_DUE_INTEREST_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NOT_DUE_CAB_LENDER_INTEREST_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NOT_DUE_PRINC_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? TRANS_FEE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? LIEN_FEE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? CAB_FEE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? CAB_LENDER_INTEREST_FEE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? INTEREST_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? PRINC_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? PAST_DUE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? CURR_DUE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? NEXT_DUE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? NOT_DUE_BAL { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NEXT_STATEMENT_DATE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NEXT_DUE_DATE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PENDING_SCHED_ACH_AMT { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PENDING_SCHED_ACH_SENT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PENDING_COLL_ACH_AMT { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PENDING_COLL_ACH_SENT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OpenEndLoanStatement> OpenEndLoanStatements { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OpenEndRecalcStatementSnapshot> OpenEndRecalcStatementSnapshots { get; set; }
    }
}
