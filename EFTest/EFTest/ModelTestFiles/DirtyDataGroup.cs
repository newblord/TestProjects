namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DirtyDataGroup")]
    public partial class DirtyDataGroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DirtyDataGroup()
        {
            DirtyDataJobs = new HashSet<DirtyDataJob>();
        }

        [Key]
        public int DIRTY_DATA_GROUP_KEY { get; set; }

        [Required]
        [StringLength(100)]
        public string GROUP_NAME { get; set; }

        [Required]
        [StringLength(2000)]
        public string DESCRIPTION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DirtyDataJob> DirtyDataJobs { get; set; }
    }
}
