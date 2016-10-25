namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OpenEndRecalcStatementSnapshot")]
    public partial class OpenEndRecalcStatementSnapshot
    {
        [Key]
        public int OPEN_END_RECALC_STATEMENT_SNAPSHOT_KEY { get; set; }

        public int OPEN_END_LOAN_STATEMENT_SNAPSHOT_KEY { get; set; }

        [Required]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? PAST_DUE_TRANS_FEE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? C_PAST_DUE_TRANS_FEE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? PAST_DUE_LIEN_FEE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? C_PAST_DUE_LIEN_FEE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? PAST_DUE_CAB_FEE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? C_PAST_DUE_CAB_FEE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? PAST_DUE_COLL_FEE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? C_PAST_DUE_COLL_FEE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? PAST_DUE_CAB_LENDER_COLL_FEE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? C_PAST_DUE_CAB_LENDER_COLL_FEE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? PAST_DUE_INTEREST_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? C_PAST_DUE_INTEREST_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? PAST_DUE_CAB_LENDER_INTEREST_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? C_PAST_DUE_CAB_LENDER_INTEREST_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? PAST_DUE_PRINC_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? C_PAST_DUE_PRINC_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? CURR_DUE_TRANS_FEE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? C_CURR_DUE_TRANS_FEE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? CURR_DUE_LIEN_FEE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? C_CURR_DUE_LIEN_FEE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? CURR_DUE_CAB_FEE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? C_CURR_DUE_CAB_FEE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? CURR_DUE_INTEREST_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? C_CURR_DUE_INTEREST_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? CURR_DUE_CAB_LENDER_INTEREST_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? C_CURR_DUE_CAB_LENDER_INTEREST_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? CURR_DUE_PRINC_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? C_CURR_DUE_PRINC_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? NEXT_DUE_TRANS_FEE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? C_NEXT_DUE_TRANS_FEE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? NEXT_DUE_LIEN_FEE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? C_NEXT_DUE_LIEN_FEE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? NEXT_DUE_CAB_FEE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? C_NEXT_DUE_CAB_FEE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? NEXT_DUE_INTEREST_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? C_NEXT_DUE_INTEREST_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? NEXT_DUE_CAB_LENDER_INTEREST_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? C_NEXT_DUE_CAB_LENDER_INTEREST_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? NEXT_DUE_PRINC_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? C_NEXT_DUE_PRINC_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? NOT_DUE_TRANS_FEE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? C_NOT_DUE_TRANS_FEE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? NOT_DUE_LIEN_FEE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? C_NOT_DUE_LIEN_FEE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? NOT_DUE_CAB_FEE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? C_NOT_DUE_CAB_FEE_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? NOT_DUE_INTEREST_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? C_NOT_DUE_INTEREST_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? NOT_DUE_CAB_LENDER_INTEREST_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? C_NOT_DUE_CAB_LENDER_INTEREST_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? NOT_DUE_PRINC_BAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? C_NOT_DUE_PRINC_BAL { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NEXT_STATEMENT_DATE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? C_NEXT_STATEMENT_DATE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NEXT_DUE_DATE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? C_NEXT_DUE_DATE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? PENDING_SCHED_ACH_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? C_PENDING_SCHED_ACH_AMT { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PENDING_SCHED_ACH_SENT { get; set; }

        [Column(TypeName = "date")]
        public DateTime? C_PENDING_SCHED_ACH_SENT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? PENDING_COLL_ACH_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? C_PENDING_COLL_ACH_AMT { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PENDING_COLL_ACH_SENT { get; set; }

        [Column(TypeName = "date")]
        public DateTime? C_PENDING_COLL_ACH_SENT { get; set; }

        public virtual OpenEndLoanStatementSnapshot OpenEndLoanStatementSnapshot { get; set; }
    }
}
