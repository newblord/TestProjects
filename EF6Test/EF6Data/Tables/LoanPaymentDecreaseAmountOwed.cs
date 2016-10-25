namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoanPaymentDecreaseAmountOwed")]
    public partial class LoanPaymentDecreaseAmountOwed
    {
        [Key]
        public int LOAN_PAYMENT_DECREASE_AMOUNT_OWED_KEY { get; set; }

        public int LOAN_PAYMENT_KEY { get; set; }

        [Required]
        [StringLength(1)]
        public string DECREASE_AMOUNT_OWED_TYPE { get; set; }

        [Required]
        [StringLength(1)]
        public string DECREASE_AMOUNT_OWED_REASON { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal APPLY_BUCKET_AMT { get; set; }

        [Required]
        [StringLength(1)]
        public string APPLY_DUE_TYPE { get; set; }

        [Required]
        [StringLength(1)]
        public string APPLY_BUCKET_TYPE { get; set; }

        public virtual LoanPayment LoanPayment { get; set; }
    }
}
