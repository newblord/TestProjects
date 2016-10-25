using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class SkipTraceVendor
    {
        public SkipTraceVendor()
        {
            SkipTraceThread = new HashSet<SkipTraceThread>();
        }

        public int SkipTraceVendorKey { get; set; }
        public int SkipTraceConfigKey { get; set; }
        public string VendorName { get; set; }
        public short VendorPriority { get; set; }
        public bool VendorActive { get; set; }
        public bool VendorDeleted { get; set; }
        public decimal VendorCost { get; set; }
        public string VendorLogin { get; set; }
        public string VendorPassword { get; set; }
        public string CryptoKey { get; set; }
        public string ToVendorUri { get; set; }
        public string FromVendorUri { get; set; }
        public string VendorPath { get; set; }

        public virtual ICollection<SkipTraceThread> SkipTraceThread { get; set; }
        public virtual SkipTraceConfig SkipTraceConfigKeyNavigation { get; set; }
    }
}
