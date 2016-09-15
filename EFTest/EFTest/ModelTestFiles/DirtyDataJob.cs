namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DirtyDataJob")]
    public partial class DirtyDataJob
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DirtyDataJob()
        {
            DirtyDataJobRuns = new HashSet<DirtyDataJobRun>();
        }

        [Key]
        public int DIRTY_DATA_JOB_KEY { get; set; }

        public int GROUP_KEY { get; set; }

        [Required]
        [StringLength(50)]
        public string JOB_NAME { get; set; }

        [Required]
        [StringLength(2000)]
        public string DESCRIPTION { get; set; }

        [Required]
        [StringLength(100)]
        public string STORED_PROC_NAME { get; set; }

        public bool IS_ENABLED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        public virtual DirtyDataGroup DirtyDataGroup { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DirtyDataJobRun> DirtyDataJobRuns { get; set; }
    }
}
