namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PromiseToPay")]
    public partial class PromiseToPay
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PromiseToPay()
        {
            PromiseToPayDetails = new HashSet<PromiseToPayDetail>();
        }

        [Key]
        public int PROMISE_TO_PAY_KEY { get; set; }

        public int CUSTOMER_KEY { get; set; }

        public int RISREPT_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        public byte PTP_PMTS { get; set; }

        public short PTP_LOCATION { get; set; }

        [Required]
        [StringLength(1)]
        public string PTP_COURTESY_CALL { get; set; }

        [StringLength(3)]
        public string APPROVED_BY { get; set; }

        public bool CANCELLED { get; set; }

        public bool WAIVE_FEE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CANCELLED_DATE { get; set; }

        [StringLength(3)]
        public string CANCELLED_BY { get; set; }

        public int? COLLECTION_ACTION_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? REVERSED_DATE { get; set; }

        public bool REVERSED { get; set; }

        public int PTP_CONFIG_KEY { get; set; }

        public int? TRANS_DETAIL_KEY { get; set; }

        public int? CUSTOMER_DOCUMENT_KEY { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual RIPTPPaymentPlanConfig RIPTPPaymentPlanConfig { get; set; }

        public virtual RISREPT RISREPT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PromiseToPayDetail> PromiseToPayDetails { get; set; }
    }
}
