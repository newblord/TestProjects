using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebPixelVendor
    {
        public WebPixelVendor()
        {
            WebPixelVendorData = new HashSet<WebPixelVendorData>();
            WebPixelVendorDetail = new HashSet<WebPixelVendorDetail>();
        }

        public int WpvKey { get; set; }
        public string VendorName { get; set; }
        public bool Enabled { get; set; }
        public string ClassName { get; set; }
        public bool UseNumericScore { get; set; }
        public string NumericPassScore { get; set; }
        public string NumericWarnScore { get; set; }
        public string NumericFailScore { get; set; }
        public bool AlphaPassOnUnknown { get; set; }
        public string AlphaPassScore { get; set; }
        public string AlphaWarnScore { get; set; }
        public string AlphaFailScore { get; set; }
        public string Proxy { get; set; }

        public virtual ICollection<WebPixelVendorData> WebPixelVendorData { get; set; }
        public virtual ICollection<WebPixelVendorDetail> WebPixelVendorDetail { get; set; }
    }
}
