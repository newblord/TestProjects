namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoanPaymentWaiveRIFee")]
    public partial class LoanPaymentWaiveRIFee
    {
        [Key]
        public int LOAN_PAYMENT_WAIVE_RI_FEE_KEY { get; set; }

        public int LOAN_PAYMENT_KEY { get; set; }

        [Required]
        [StringLength(1)]
        public string WAIVE_RI_FEE_REASON_CODE { get; set; }

        public virtual LoanPayment LoanPayment { get; set; }
    }
}
