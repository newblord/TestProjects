namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PaydayLoanApproval")]
    public partial class PaydayLoanApproval
    {
        [Key]
        public int PAYDAY_LOAN_APPROVAL_KEY { get; set; }

        public int LOAN_KEY { get; set; }

        public int CUSTOMER_KEY { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal GROSS_INCOME_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NET_INCOME_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal OPEN_LOANS_PRINC_AMT { get; set; }

        public byte STATE_MAX_PCT_OF_INCOME { get; set; }

        [Required]
        [StringLength(1)]
        public string STATE_MAX_NET_OR_GROSS { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal STATE_MAX_MULTI_LOAN_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal STATE_MAX_INCOME_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal STATE_MAX_PER_LOAN_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal STATE_MAX_AMT { get; set; }

        public bool APPROVAL_ENABLED { get; set; }

        public byte APPROVAL_PCT_OF_INCOME { get; set; }

        [Required]
        [StringLength(1)]
        public string APPROVAL_NET_OR_GROSS { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal APPROVAL_BASE_INCOME_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal APPROVAL_CCARD_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal APPROVAL_DIR_DEP_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal APPROVAL_SUCCESSFUL_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal APPROVAL_BASE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal MGR_OVERRIDE_AMT { get; set; }

        [Required]
        [StringLength(3)]
        public string MGR_OVERRIDE_INITS { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PREV_PRINC_OVERRIDE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal APPROVAL_STATE_MAX_ADJ_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal APPROVAL_AMT { get; set; }

        public short SCORED_INCREMENT_AMOUNT { get; set; }

        public short? SCORED_INCREMENT_NUM { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal INCLUDE_FEE_MAX_PRINC_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal INCLUDE_FEE_MAX_LOAN_AMT { get; set; }

        public virtual Loan Loan { get; set; }
    }
}
