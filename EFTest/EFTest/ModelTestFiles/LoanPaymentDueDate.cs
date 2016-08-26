namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoanPaymentDueDate")]
    public partial class LoanPaymentDueDate
    {
        [Key]
        public int LOAN_PAYMENT_DUE_DATE_KEY { get; set; }

        public int LOAN_PAYMENT_KEY { get; set; }

        [Column(TypeName = "date")]
        public DateTime ORIG_DUE_DATE { get; set; }

        [Column(TypeName = "date")]
        public DateTime ADJUSTED_DUE_DATE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PAST_DUE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal COLLECTIONS_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PENDING_ACH_AMT { get; set; }

        public virtual LoanPayment LoanPayment { get; set; }
    }
}
