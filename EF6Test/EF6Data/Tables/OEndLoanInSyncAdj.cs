namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OEndLoanInSyncAdj")]
    public partial class OEndLoanInSyncAdj
    {
        [Key]
        [Column(Order = 0)]
        public int OEND_LOAN_INSYNC_ADJ_KEY { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LOAN_KEY { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        [StringLength(1)]
        public string LOAN_STATUS { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? LOAN_BALANCE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? CASH_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? TRANS_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? LIEN_FEE_AMT { get; set; }

        public bool? CHARGE_LIEN_FEE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ADJUSTED_DUE_DATE { get; set; }

        public bool? DEFAULTED { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DEFAULT_DATE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? LAST_PAYMENT_AMT { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? LAST_PAYMENT_DATE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? LAST_CASH_ADV_AMT { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? LAST_CASH_ADV_DATE { get; set; }

        public int? LAST_STATEMENT_NUM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? LAST_STATEMENT_DATE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NEXT_STATEMENT_DATE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NEXT_DUE_DATE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? PAST_DUE_TRANS_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? PAST_DUE_LIEN_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? PAST_DUE_COLL_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? PAST_DUE_ACTIVITY_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? PAST_DUE_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? PAST_DUE_PRINC_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? CURR_DUE_TRANS_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? CURR_DUE_LIEN_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? CURR_DUE_ACTIVITY_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? CURR_DUE_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? CURR_DUE_PRINC_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? NEXT_DUE_TRANS_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? NEXT_DUE_LIEN_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? NEXT_DUE_ACTIVITY_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? NEXT_DUE_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? NEXT_DUE_PRINC_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? NOT_DUE_TRANS_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? NOT_DUE_LIEN_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? NOT_DUE_ACTIVITY_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? NOT_DUE_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? NOT_DUE_PRINC_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? RI_BALANCE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? PRINC_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? INVENTORY_AMT { get; set; }

        [StringLength(1)]
        public string CLOAN_STATUS { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? CLOAN_BALANCE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? CCASH_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? CTRANS_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? CLIEN_FEE_AMT { get; set; }

        public bool? CCHARGE_LIEN_FEE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CADJUSTED_DUE_DATE { get; set; }

        public bool? CDEFAULTED { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CDEFAULT_DATE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? CLAST_PAYMENT_AMT { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CLAST_PAYMENT_DATE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? CLAST_CASH_ADV_AMT { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CLAST_CASH_ADV_DATE { get; set; }

        public int? CLAST_STATEMENT_NUM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CLAST_STATEMENT_DATE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CNEXT_STATEMENT_DATE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CNEXT_DUE_DATE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? CPAST_DUE_TRANS_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? CPAST_DUE_LIEN_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? CPAST_DUE_COLL_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? CPAST_DUE_ACTIVITY_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? CPAST_DUE_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? CPAST_DUE_PRINC_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? CCURR_DUE_TRANS_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? CCURR_DUE_LIEN_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? CCURR_DUE_ACTIVITY_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? CCURR_DUE_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? CCURR_DUE_PRINC_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? CNEXT_DUE_TRANS_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? CNEXT_DUE_LIEN_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? CNEXT_DUE_ACTIVITY_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? CNEXT_DUE_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? CNEXT_DUE_PRINC_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? CNOT_DUE_TRANS_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? CNOT_DUE_LIEN_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? CNOT_DUE_ACTIVITY_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? CNOT_DUE_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? CNOT_DUE_PRINC_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? CRI_BALANCE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? CPRINC_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? C_INVENTORY_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? PAST_DUE_CSO_LENDER_COLL_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? PAST_DUE_CSO_LENDER_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? CURR_DUE_CSO_LENDER_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? NEXT_DUE_CSO_LENDER_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? NOT_DUE_CSO_LENDER_INTEREST_AMT { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? TERM_LIMIT_FINAL_STATEMENT_DATE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? TERM_LIMIT_FINAL_DUE_DATE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? CPAST_DUE_CSO_LENDER_COLL_FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? CPAST_DUE_CSO_LENDER_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? CCURR_DUE_CSO_LENDER_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? CNEXT_DUE_CSO_LENDER_INTEREST_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? CNOT_DUE_CSO_LENDER_INTEREST_AMT { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CTERM_LIMIT_FINAL_STATEMENT_DATE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CTERM_LIMIT_FINAL_DUE_DATE { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "smallmoney")]
        public decimal CREDIT_AVAIL { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "smallmoney")]
        public decimal CCREDIT_AVAIL { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "smallmoney")]
        public decimal CREDIT_AVAILABLE_FOR_BUYUP { get; set; }

        [Key]
        [Column(Order = 7, TypeName = "smallmoney")]
        public decimal CCREDIT_AVAILABLE_FOR_BUYUP { get; set; }

        [Key]
        [Column(Order = 8, TypeName = "smallmoney")]
        public decimal CREDIT_AVAILABLE_FOR_BUYUP_NON_ORDINANCE { get; set; }

        [Key]
        [Column(Order = 9, TypeName = "smallmoney")]
        public decimal CCREDIT_AVAILABLE_FOR_BUYUP_NON_ORDINANCE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? INACTIVE_DATE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CINACTIVE_DATE { get; set; }

        public bool? IS_IN_LEGAL_STATUS { get; set; }

        public byte? RUN_MODE { get; set; }
    }
}
