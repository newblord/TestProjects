namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SkipTraceStep_AuditCategory
    {
        public int SKIP_TRACE_STEP_KEY { get; set; }

        public int? RIS_AUDIT_KEY { get; set; }

        [Key]
        public int SKIP_TRACE_STEP_AUDIT_CATEGORY_KEY { get; set; }

        public virtual RISAUDIT RISAUDIT { get; set; }

        public virtual SkipTraceStep SkipTraceStep { get; set; }
    }
}
