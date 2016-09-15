namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SkipTraceStep")]
    public partial class SkipTraceStep
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SkipTraceStep()
        {
            SkipTraceStep_AuditCategory = new HashSet<SkipTraceStep_AuditCategory>();
            SkipTraceStep_Location = new HashSet<SkipTraceStep_Location>();
            SkipTraceStep_ProductCode = new HashSet<SkipTraceStep_ProductCode>();
            SkipTraceStep1 = new HashSet<SkipTraceStep>();
            SkipTraceThreads = new HashSet<SkipTraceThread>();
        }

        [Key]
        public int SKIP_TRACE_STEP_KEY { get; set; }

        public int SKIP_TRACE_CONFIG_KEY { get; set; }

        public int? STEP_ACTIVE_ALIAS { get; set; }

        [Required]
        [StringLength(28)]
        public string STEP_NAME { get; set; }

        public short STEP_PRIORITY { get; set; }

        public short DELINQUENCY_DAYS_FROM { get; set; }

        public short DELINQUENCY_DAYS_TO { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal BALANCE_RANGE_FROM { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal BALANCE_RANGE_TO { get; set; }

        public short DAYS_SINCE_LAST_CONTACT { get; set; }

        public bool PROCESS_WHEN_NO_HOME_ADDRESS { get; set; }

        public bool PROCESS_WHEN_NO_HOME_PHONE { get; set; }

        public bool PROCESS_WHEN_NO_CELL_PHONE { get; set; }

        public bool PROCESS_WHEN_NO_WORK_PHONE { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public bool? STEP_ACTIVE { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public bool? STEP_CURRENT { get; set; }

        public virtual SkipTraceConfig SkipTraceConfig { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SkipTraceStep_AuditCategory> SkipTraceStep_AuditCategory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SkipTraceStep_Location> SkipTraceStep_Location { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SkipTraceStep_ProductCode> SkipTraceStep_ProductCode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SkipTraceStep> SkipTraceStep1 { get; set; }

        public virtual SkipTraceStep SkipTraceStep2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SkipTraceThread> SkipTraceThreads { get; set; }
    }
}
