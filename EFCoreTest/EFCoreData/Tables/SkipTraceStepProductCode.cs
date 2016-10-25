using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class SkipTraceStepProductCode
    {
        public int SkipTraceStepKey { get; set; }
        public string ProductCode { get; set; }
        public int SkipTraceStepProductCodeKey { get; set; }

        public virtual SkipTraceStep SkipTraceStepKeyNavigation { get; set; }
    }
}
