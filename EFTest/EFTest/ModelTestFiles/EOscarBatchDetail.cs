namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EOscarBatchDetail")]
    public partial class EOscarBatchDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EOscarBatchDetail()
        {
            EOscarDetailDisputeCodes = new HashSet<EOscarDetailDisputeCode>();
        }

        [Key]
        public int EOSCAR_BATCH_DETAIL_KEY { get; set; }

        public int EOSCAR_BATCH_KEY_RECV { get; set; }

        public int? EOSCAR_BATCH_KEY_SENT { get; set; }

        public int ACDV_IDENTIFIER { get; set; }

        [Required]
        [StringLength(100)]
        public string ACDV_CONTROL_NUMBER { get; set; }

        public int RISREPT_KEY { get; set; }

        public int CUSTOMER_KEY { get; set; }

        public bool MANUAL_EXPORT { get; set; }

        public bool MANUAL_REVIEW { get; set; }

        public bool PROCESSED { get; set; }

        [Required]
        public string XML_RECV { get; set; }

        public string XML_SENT { get; set; }

        public virtual EOscarBatch EOscarBatch { get; set; }

        public virtual EOscarBatch EOscarBatch1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EOscarDetailDisputeCode> EOscarDetailDisputeCodes { get; set; }
    }
}
