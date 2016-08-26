namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PrepaidCardStopPayment")]
    public partial class PrepaidCardStopPayment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PrepaidCardStopPayment()
        {
            PrepaidCardStopPaymentEdits = new HashSet<PrepaidCardStopPaymentEdit>();
        }

        [Key]
        public int PREPAID_CARD_STOP_PAYMENT_KEY { get; set; }

        public int CREDIT_CARD_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Required]
        [StringLength(22)]
        public string SOURCE_INSTITUTION { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? STOP_PAYMENT_AMOUNT { get; set; }

        public int PREPAID_CARD_STOP_PAYMENT_REASON_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime EFFECTIVE_DATE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CANCELLED_DATE { get; set; }

        [StringLength(3)]
        public string CANCELLED_BY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? LAST_UPDATED_DATE { get; set; }

        [StringLength(3)]
        public string LAST_UPDATED_BY { get; set; }

        [StringLength(120)]
        public string OTHER_REASON_DESCRIBE { get; set; }

        public bool REPORTED_TO_VENDOR { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? REPORTED_TO_VENDOR_DATE { get; set; }

        public virtual CreditCard CreditCard { get; set; }

        public virtual PrepaidCardStopPaymentReason PrepaidCardStopPaymentReason { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrepaidCardStopPaymentEdit> PrepaidCardStopPaymentEdits { get; set; }
    }
}
