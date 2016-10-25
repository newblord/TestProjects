using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class SkipTraceThread
    {
        public int SkipTraceThreadKey { get; set; }
        public int SkipTraceConfigKey { get; set; }
        public int? RisreptKey { get; set; }
        public int? CustomerKey { get; set; }
        public DateTime DateEntered { get; set; }
        public DateTime DateActive { get; set; }
        public bool IfNoAddress { get; set; }
        public bool IfNoCellPhone { get; set; }
        public bool IfNoHomePhone { get; set; }
        public bool IfNoWorkPhone { get; set; }
        public DateTime? DateLastContact { get; set; }
        public byte PassCounter { get; set; }
        public byte StepNumber { get; set; }
        public int? SkipTraceStepKey { get; set; }
        public byte VendorNumber { get; set; }
        public int? SkipTraceVendorKey { get; set; }
        public string TraceStatus { get; set; }

        public virtual Customer CustomerKeyNavigation { get; set; }
        public virtual Risrept RisreptKeyNavigation { get; set; }
        public virtual SkipTraceConfig SkipTraceConfigKeyNavigation { get; set; }
        public virtual SkipTraceStep SkipTraceStepKeyNavigation { get; set; }
        public virtual SkipTraceVendor SkipTraceVendorKeyNavigation { get; set; }
    }
}
