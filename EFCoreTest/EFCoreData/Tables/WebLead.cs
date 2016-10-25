using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebLead
    {
        public int WebLeadKey { get; set; }
        public int WebLeadGenKey { get; set; }
        public int? LoanApplicationKey { get; set; }
        public int? Attributes { get; set; }
        public decimal? Price { get; set; }
        public DateTime DateEntered { get; set; }
        public decimal? MinPrice { get; set; }
        public int? SubId { get; set; }
        public bool? IsStoreLead { get; set; }
        public int? CustomerKey { get; set; }
        public int? LoanKey { get; set; }

        public virtual Customer CustomerKeyNavigation { get; set; }
        public virtual Loan LoanKeyNavigation { get; set; }
        public virtual WebLeadGen WebLeadGenKeyNavigation { get; set; }
    }
}
