using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class SkipTraceStepLocation
    {
        public int SkipTraceStepKey { get; set; }
        public short? Location { get; set; }
        public int SkipTraceStepLocationKey { get; set; }

        public virtual Company LocationNavigation { get; set; }
        public virtual SkipTraceStep SkipTraceStepKeyNavigation { get; set; }
    }
}
