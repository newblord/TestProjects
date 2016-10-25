using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebVisitSource
    {
        public WebVisitSource()
        {
            Customer = new HashSet<Customer>();
        }

        public string SessionGuid { get; set; }
        public string SourceUrl { get; set; }
        public int? VisitorKey { get; set; }
        public int? LoanApplicationKey { get; set; }
        public string Domain { get; set; }
        public string SearchQuery { get; set; }
        public DateTime DateEntered { get; set; }
        public DateTime? SessionEnd { get; set; }
        public string DestUrl { get; set; }
        public string LinkType { get; set; }
        public string UserAgent { get; set; }
        public string Description { get; set; }
        public string KeyWords { get; set; }
        public string IpAddress { get; set; }
        public bool IsSecureUrl { get; set; }
        public long WebVisitSourceKey { get; set; }
        public string Channel { get; set; }
        public string Vendor { get; set; }
        public string SubChannel { get; set; }
        public string Campaign { get; set; }
        public string Content { get; set; }
        public string DestDomain { get; set; }

        public virtual ICollection<Customer> Customer { get; set; }
        public virtual LoanApplication LoanApplicationKeyNavigation { get; set; }
        public virtual Visitor VisitorKeyNavigation { get; set; }
    }
}
