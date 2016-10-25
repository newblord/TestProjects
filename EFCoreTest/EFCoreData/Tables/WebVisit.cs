using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebVisit
    {
        public long WebVisitKey { get; set; }
        public DateTime DateEntered { get; set; }
        public DateTime DateSessionEnd { get; set; }
        public string UserAgent { get; set; }
        public string IpAddress { get; set; }
        public string DestinationUrl { get; set; }
        public string DestinationDomain { get; set; }
        public bool IsSecureUrl { get; set; }
        public string SourceUrl { get; set; }
        public string SourceDomain { get; set; }
        public string SearchQuery { get; set; }
        public string Keywords { get; set; }
        public string Description { get; set; }
        public string LinkType { get; set; }
        public string Vendor { get; set; }
        public string Channel { get; set; }
        public string SubChannel { get; set; }
        public string Campaign { get; set; }
        public string Content { get; set; }
        public int? VisitorKey { get; set; }
        public int? LoanApplicationKey { get; set; }

        public virtual LoanApplication LoanApplicationKeyNavigation { get; set; }
        public virtual Visitor VisitorKeyNavigation { get; set; }
    }
}
