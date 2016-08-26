namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CashedCheckPaymentRefundXRef")]
    public partial class CashedCheckPaymentRefundXRef
    {
        [Key]
        public int CASHED_CHECK_PAYMENT_REFUND_XREF_KEY { get; set; }

        public int REFUND_CASHED_CHECK_PAYMENT_KEY { get; set; }

        public int REFUNDED_CASHED_CHECK_PAYMENT_KEY { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal REFUND_AMOUNT { get; set; }

        public virtual CashedCheckPayment CashedCheckPayment { get; set; }

        public virtual CashedCheckPayment CashedCheckPayment1 { get; set; }
    }
}
