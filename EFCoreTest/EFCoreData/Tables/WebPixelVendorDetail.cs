using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebPixelVendorDetail
    {
        public int WebPixelVendorDetailKey { get; set; }
        public int WebPixelVendorKey { get; set; }
        public string RuleSetName { get; set; }
        public string Description { get; set; }
        public string TestUrl { get; set; }
        public string ProductionUrl { get; set; }
        public string TestUserId { get; set; }
        public string ProductionUserId { get; set; }
        public string TestPassword { get; set; }
        public string ProductionPassword { get; set; }
        public string LicenseKey { get; set; }
        public string UserKey { get; set; }
        public bool IsEnabled { get; set; }

        public virtual WebPixelVendor WebPixelVendorKeyNavigation { get; set; }
    }
}
