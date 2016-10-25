namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CapsRunStatu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CapsRunStatu()
        {
            CapsRuns = new HashSet<CapsRun>();
        }

        [Key]
        public byte CAPS_RUN_STATUS_KEY { get; set; }

        [Required]
        [StringLength(50)]
        public string RUN_STATUS_DESC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CapsRun> CapsRuns { get; set; }
    }
}
