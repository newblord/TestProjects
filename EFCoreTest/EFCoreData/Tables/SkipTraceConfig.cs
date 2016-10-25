using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class SkipTraceConfig
    {
        public SkipTraceConfig()
        {
            SkipTraceStep = new HashSet<SkipTraceStep>();
            SkipTraceThread = new HashSet<SkipTraceThread>();
            SkipTraceVendor = new HashSet<SkipTraceVendor>();
        }

        public int SkipTraceConfigKey { get; set; }
        public bool IsAdAstra { get; set; }
        public short MaxCyclesPerCustomer { get; set; }
        public short DaysBetweenCycles { get; set; }
        public int WatchListVendorKey { get; set; }
        public decimal BalanceRangeFrom { get; set; }
        public decimal BalanceRangeTo { get; set; }

        public virtual ICollection<SkipTraceStep> SkipTraceStep { get; set; }
        public virtual ICollection<SkipTraceThread> SkipTraceThread { get; set; }
        public virtual ICollection<SkipTraceVendor> SkipTraceVendor { get; set; }
    }
}
