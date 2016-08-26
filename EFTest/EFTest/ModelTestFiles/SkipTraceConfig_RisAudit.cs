namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SkipTraceConfig_RisAudit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SKIP_TRACE_CONFIG_KEY { get; set; }

        public int? RIS_AUDIT_KEY { get; set; }

        public virtual RISAUDIT RISAUDIT { get; set; }

        public virtual SkipTraceConfig SkipTraceConfig { get; set; }
    }
}
