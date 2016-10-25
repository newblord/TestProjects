using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebPixelVendorData
    {
        public int WpvdKey { get; set; }
        public int LoanApplicationKey { get; set; }
        public DateTime? DateEntered { get; set; }
        public string IpAddress { get; set; }
        public int ScoringVendor { get; set; }
        public short? MsforResponse { get; set; }
        public string PassWarnFail { get; set; }
        public string RawResponse { get; set; }
        public string DeviceAlias { get; set; }
        public string VendorResponseMessage { get; set; }

        public virtual LoanApplication LoanApplicationKeyNavigation { get; set; }
        public virtual WebPixelVendor ScoringVendorNavigation { get; set; }
    }
}
