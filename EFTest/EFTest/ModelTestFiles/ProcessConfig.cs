namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProcessConfig")]
    public partial class ProcessConfig
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProcessConfig()
        {
            ProcessConfigInstances = new HashSet<ProcessConfigInstance>();
        }

        [Key]
        public int PROCESS_CONFIG_KEY { get; set; }

        [Required]
        [StringLength(100)]
        public string PROCESS_NAME { get; set; }

        [Required]
        [StringLength(50)]
        public string PROCESS_COMMAND { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [StringLength(3)]
        public string UPDATED_BY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? UPDATED_DATE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProcessConfigInstance> ProcessConfigInstances { get; set; }
    }
}
