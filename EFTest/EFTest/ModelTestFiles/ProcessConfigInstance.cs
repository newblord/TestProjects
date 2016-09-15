namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProcessConfigInstance")]
    public partial class ProcessConfigInstance
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProcessConfigInstance()
        {
            ProcessConfigDetails = new HashSet<ProcessConfigDetail>();
            ProcessConfigDetailHistories = new HashSet<ProcessConfigDetailHistory>();
            ProcessSchedules = new HashSet<ProcessSchedule>();
            ProcessConfigInstanceGroups = new HashSet<ProcessConfigInstanceGroup>();
            ProcessConfigInstanceTellers = new HashSet<ProcessConfigInstanceTeller>();
        }

        [Key]
        public int PROCESS_CONFIG_INSTANCE_KEY { get; set; }

        public int PROCESS_CONFIG_KEY { get; set; }

        [Required]
        [StringLength(100)]
        public string INSTANCE_NAME { get; set; }

        public bool IS_PRIVATE { get; set; }

        public bool IS_ACTIVE { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [StringLength(3)]
        public string UPDATED_BY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? UPDATED_DATE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? LASTUSED_DATE { get; set; }

        public virtual ProcessConfig ProcessConfig { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProcessConfigDetail> ProcessConfigDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProcessConfigDetailHistory> ProcessConfigDetailHistories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProcessSchedule> ProcessSchedules { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProcessConfigInstanceGroup> ProcessConfigInstanceGroups { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProcessConfigInstanceTeller> ProcessConfigInstanceTellers { get; set; }
    }
}
