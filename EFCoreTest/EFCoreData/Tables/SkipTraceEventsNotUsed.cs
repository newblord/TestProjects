using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class SkipTraceEventsNotUsed
    {
        public int SkipTraceEventsKey { get; set; }
        public int SkipTraceThreadKey { get; set; }
        public DateTime DateEntered { get; set; }
        public string EventCode { get; set; }
        public int? SkipTraceVendorKey { get; set; }
    }
}
