namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoanPaymentAddToQueue")]
    public partial class LoanPaymentAddToQueue
    {
        [Key]
        public int LOAN_PAYMENT_ADD_TO_QUEUE_KEY { get; set; }

        public int LOAN_PAYMENT_KEY { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal ADD_TO_PAYMENT_QUEUE_AMT { get; set; }

        public virtual LoanPayment LoanPayment { get; set; }
    }
}
