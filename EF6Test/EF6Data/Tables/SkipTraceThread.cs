namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SkipTraceThread")]
    public partial class SkipTraceThread
    {
        [Key]
        public int SKIP_TRACE_THREAD_KEY { get; set; }

        public int SKIP_TRACE_CONFIG_KEY { get; set; }

        public int? RISREPT_KEY { get; set; }

        public int? CUSTOMER_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ACTIVE { get; set; }

        public bool IF_NO_ADDRESS { get; set; }

        public bool IF_NO_CELL_PHONE { get; set; }

        public bool IF_NO_HOME_PHONE { get; set; }

        public bool IF_NO_WORK_PHONE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DATE_LAST_CONTACT { get; set; }

        public byte PASS_COUNTER { get; set; }

        public byte STEP_NUMBER { get; set; }

        public int? SKIP_TRACE_STEP_KEY { get; set; }

        public byte VENDOR_NUMBER { get; set; }

        public int? SKIP_TRACE_VENDOR_KEY { get; set; }

        [Required]
        [StringLength(1)]
        public string TRACE_STATUS { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual RISREPT RISREPT { get; set; }

        public virtual SkipTraceConfig SkipTraceConfig { get; set; }

        public virtual SkipTraceStep SkipTraceStep { get; set; }

        public virtual SkipTraceVendor SkipTraceVendor { get; set; }
    }
}
