namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CashedCheckPaymentRefund")]
    public partial class CashedCheckPaymentRefund
    {
        [Key]
        public int CASHED_CHECK_PAYMENT_REFUND_KEY { get; set; }

        public int TRANS_DETAIL_KEY { get; set; }

        public int REFUNDED_CASHED_CHECK_PAYMENT_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        public short LOCATION { get; set; }

        public bool REVERSED { get; set; }

        public int? REVERSE_TRANS_DETAIL_KEY { get; set; }

        public virtual CashedCheckPayment CashedCheckPayment { get; set; }

        public virtual TransDetail TransDetail { get; set; }
    }
}
