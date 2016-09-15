namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SkipTraceVendor")]
    public partial class SkipTraceVendor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SkipTraceVendor()
        {
            SkipTraceThreads = new HashSet<SkipTraceThread>();
        }

        [Key]
        public int SKIP_TRACE_VENDOR_KEY { get; set; }

        public int SKIP_TRACE_CONFIG_KEY { get; set; }

        [Required]
        [StringLength(28)]
        public string VENDOR_NAME { get; set; }

        public short VENDOR_PRIORITY { get; set; }

        public bool VENDOR_ACTIVE { get; set; }

        public bool VENDOR_DELETED { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal VENDOR_COST { get; set; }

        [StringLength(25)]
        public string VENDOR_LOGIN { get; set; }

        [StringLength(25)]
        public string VENDOR_PASSWORD { get; set; }

        [StringLength(25)]
        public string CRYPTO_KEY { get; set; }

        [StringLength(250)]
        public string TO_VENDOR_URI { get; set; }

        [StringLength(250)]
        public string FROM_VENDOR_URI { get; set; }

        [Required]
        [StringLength(250)]
        public string VENDOR_PATH { get; set; }

        public virtual SkipTraceConfig SkipTraceConfig { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SkipTraceThread> SkipTraceThreads { get; set; }
    }
}
