namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ACHProcessingType")]
    public partial class ACHProcessingType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ACHProcessingType()
        {
            ACHProcessingQueues = new HashSet<ACHProcessingQueue>();
        }

        [Key]
        public int ACH_PROCESSING_TYPE_KEY { get; set; }

        [Required]
        [StringLength(50)]
        public string ACH_PROCESSING_TYPE_DESC { get; set; }

        [Required]
        [StringLength(1)]
        public string FILE_TYPE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACHProcessingQueue> ACHProcessingQueues { get; set; }
    }
}
