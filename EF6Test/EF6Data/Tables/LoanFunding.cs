namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoanFunding")]
    public partial class LoanFunding
    {
        [Key]
        public int LOAN_FUNDING_KEY { get; set; }

        public int LOAN_KEY { get; set; }

        public int APPROVED_LOAN_PAYMENT_KEY { get; set; }

        public int? FUNDING_TRANS_DETAIL_KEY { get; set; }

        [Required]
        [StringLength(1)]
        public string REQUESTED_FUNDING_METHOD { get; set; }

        [Required]
        [StringLength(1)]
        public string ACTUAL_FUNDING_METHOD { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal FUNDING_AMT { get; set; }

        [Required]
        [StringLength(1)]
        public string FUNDING_STATUS { get; set; }

        public virtual Loan Loan { get; set; }

        public virtual LoanPayment LoanPayment { get; set; }

        public virtual TransDetail TransDetail { get; set; }
    }
}
