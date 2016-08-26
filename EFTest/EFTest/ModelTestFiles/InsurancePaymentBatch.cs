namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InsurancePaymentBatch")]
    public partial class InsurancePaymentBatch
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InsurancePaymentBatch()
        {
            InsurancePayments = new HashSet<InsurancePayment>();
        }

        [Key]
        public int INSURANCE_PAYMENT_BATCH_KEY { get; set; }

        [Required]
        [StringLength(255)]
        public string INSURANCE_FILE_NAME { get; set; }

        public short PROCESSED_CNT { get; set; }

        public short ERROR_CNT { get; set; }

        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InsurancePayment> InsurancePayments { get; set; }
    }
}
