namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CapsSkipReason")]
    public partial class CapsSkipReason
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CapsSkipReason()
        {
            CapsHolds = new HashSet<CapsHold>();
        }

        [Key]
        public byte CAPS_SKIP_REASON_KEY { get; set; }

        [Required]
        [StringLength(50)]
        public string SKIP_DESC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CapsHold> CapsHolds { get; set; }
    }
}
