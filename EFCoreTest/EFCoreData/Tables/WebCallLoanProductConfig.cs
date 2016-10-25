using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebCallLoanProductConfig
    {
        public int WebCallLoanProductConfigKey { get; set; }
        public int LoanProductKey { get; set; }
        public string ConfigName { get; set; }
        public string ConfigValue { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime DateEntered { get; set; }
        public DateTime DateLastUpdated { get; set; }
        public string CreatedBy { get; set; }
        public string LastUpdatedBy { get; set; }
        public bool SupOnly { get; set; }
        public string ExternalLinkCaption { get; set; }
        public string ExternalLink { get; set; }

        public virtual LoanProduct LoanProductKeyNavigation { get; set; }
    }
}
