namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CashedCheckPayment")]
    public partial class CashedCheckPayment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CashedCheckPayment()
        {
            AttorneyPayments = new HashSet<AttorneyPayment>();
            CashedCheckPaymentRefunds = new HashSet<CashedCheckPaymentRefund>();
            CashedCheckPaymentRefundXRefs = new HashSet<CashedCheckPaymentRefundXRef>();
            CashedCheckPaymentRefundXRefs1 = new HashSet<CashedCheckPaymentRefundXRef>();
        }

        [Key]
        public int CASHED_CHECK_PAYMENT_KEY { get; set; }

        public int CASHED_CHECK_KEY { get; set; }

        public int TRANS_DETAIL_KEY { get; set; }

        public short LOCATION { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(500)]
        public string NOTE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PAID_AMT { get; set; }

        public bool REVERSED { get; set; }

        public DateTime? REVERSED_DATE { get; set; }

        public short PAYMENT_METHOD { get; set; }

        public byte TRANS_CODE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AttorneyPayment> AttorneyPayments { get; set; }

        public virtual CashedCheck CashedCheck { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CashedCheckPaymentRefund> CashedCheckPaymentRefunds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CashedCheckPaymentRefundXRef> CashedCheckPaymentRefundXRefs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CashedCheckPaymentRefundXRef> CashedCheckPaymentRefundXRefs1 { get; set; }
    }
}
