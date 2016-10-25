namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EOscarBatch")]
    public partial class EOscarBatch
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EOscarBatch()
        {
            EOscarBatchDetails = new HashSet<EOscarBatchDetail>();
            EOscarBatchDetails1 = new HashSet<EOscarBatchDetail>();
        }

        [Key]
        public int EOSCAR_BATCH_KEY { get; set; }

        [Column(TypeName = "date")]
        public DateTime DATE_ENTERED { get; set; }

        public int BATCH_ID { get; set; }

        public int QUEUE_ID { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Required]
        [StringLength(1)]
        public string SEND_RECV { get; set; }

        [Required]
        public string RAW_XML { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EOscarBatchDetail> EOscarBatchDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EOscarBatchDetail> EOscarBatchDetails1 { get; set; }
    }
}
