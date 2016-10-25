namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SignatureLoanApproval")]
    public partial class SignatureLoanApproval
    {
        [Key]
        public int SIGNATURE_LOAN_APPROVAL_KEY { get; set; }

        public int LOAN_KEY { get; set; }

        public int CUSTOMER_KEY { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal GROSS_INCOME_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal NET_INCOME_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal OPEN_LOANS_PRINC_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal APPROVAL_BASE_INCOME_AMT { get; set; }

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
        public decimal APPROVAL_AMT { get; set; }

        public short SCORED_INCREMENT_AMOUNT { get; set; }

        public short? SCORED_INCREMENT_NUM { get; set; }

        public virtual Loan Loan { get; set; }
    }
}
