namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PrepaidCardStopPaymentReason")]
    public partial class PrepaidCardStopPaymentReason
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PrepaidCardStopPaymentReason()
        {
            PrepaidCardStopPayments = new HashSet<PrepaidCardStopPayment>();
        }

        [Key]
        public int PREPAID_CARD_STOP_PAYMENT_REASON_KEY { get; set; }

        public bool IS_ACTIVE { get; set; }

        [Required]
        [StringLength(30)]
        public string DESCRIPTION { get; set; }

        public bool ALLOW_OTHER_NOTE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrepaidCardStopPayment> PrepaidCardStopPayments { get; set; }
    }
}
