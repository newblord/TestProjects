using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class SkipTraceStepAuditCategory
    {
        public int SkipTraceStepKey { get; set; }
        public int? RisAuditKey { get; set; }
        public int SkipTraceStepAuditCategoryKey { get; set; }

        public virtual Risaudit RisAuditKeyNavigation { get; set; }
        public virtual SkipTraceStep SkipTraceStepKeyNavigation { get; set; }
    }
}
