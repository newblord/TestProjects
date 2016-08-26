namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SkipTraceStep_Location
    {
        public int SKIP_TRACE_STEP_KEY { get; set; }

        public short? LOCATION { get; set; }

        [Key]
        public int SKIP_TRACE_STEP_LOCATION_KEY { get; set; }

        public virtual Company Company { get; set; }

        public virtual SkipTraceStep SkipTraceStep { get; set; }
    }
}
