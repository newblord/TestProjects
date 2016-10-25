namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SkipTraceEvents_NotUsed
    {
        [Key]
        public int SKIP_TRACE_EVENTS_KEY { get; set; }

        public int SKIP_TRACE_THREAD_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(1)]
        public string EVENT_CODE { get; set; }

        public int? SKIP_TRACE_VENDOR_KEY { get; set; }
    }
}
