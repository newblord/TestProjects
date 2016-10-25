namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoanPaymentSuspendInterest")]
    public partial class LoanPaymentSuspendInterest
    {
        [Key]
        public int LOAN_PAYMENT_SUSPEND_INTEREST_KEY { get; set; }

        public int LOAN_PAYMENT_SUSPEND_KEY { get; set; }

        public int? LOAN_PAYMENT_RESUME_KEY { get; set; }

        [Column(TypeName = "date")]
        public DateTime? RESUME_INTEREST_DATE { get; set; }

        public bool IS_RESUME_ON_PAYMENT { get; set; }

        [Required]
        [StringLength(1)]
        public string STATUS { get; set; }

        public virtual LoanPayment LoanPayment { get; set; }

        public virtual LoanPayment LoanPayment1 { get; set; }
    }
}
