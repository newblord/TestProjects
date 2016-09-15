namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SkipTraceStep_ProductCode
    {
        public int SKIP_TRACE_STEP_KEY { get; set; }

        [Required]
        [StringLength(3)]
        public string PRODUCT_CODE { get; set; }

        [Key]
        public int SKIP_TRACE_STEP_PRODUCT_CODE_KEY { get; set; }

        public virtual SkipTraceStep SkipTraceStep { get; set; }
    }
}
