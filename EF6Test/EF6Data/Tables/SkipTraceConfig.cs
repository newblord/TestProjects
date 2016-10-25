namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SkipTraceConfig")]
    public partial class SkipTraceConfig
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SkipTraceConfig()
        {
            SkipTraceSteps = new HashSet<SkipTraceStep>();
            SkipTraceThreads = new HashSet<SkipTraceThread>();
            SkipTraceVendors = new HashSet<SkipTraceVendor>();
        }

        [Key]
        public int SKIP_TRACE_CONFIG_KEY { get; set; }

        public bool IS_AD_ASTRA { get; set; }

        public short MAX_CYCLES_PER_CUSTOMER { get; set; }

        public short DAYS_BETWEEN_CYCLES { get; set; }

        public int WATCH_LIST_VENDOR_KEY { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal BALANCE_RANGE_FROM { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal BALANCE_RANGE_TO { get; set; }

        public virtual SkipTraceConfig_RisAudit SkipTraceConfig_RisAudit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SkipTraceStep> SkipTraceSteps { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SkipTraceThread> SkipTraceThreads { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SkipTraceVendor> SkipTraceVendors { get; set; }
    }
}
