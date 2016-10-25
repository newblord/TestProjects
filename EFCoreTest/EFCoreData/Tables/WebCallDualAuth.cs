using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebCallDualAuth
    {
        public int WebCallDualAuthId { get; set; }
        public int FeatureId { get; set; }
        public int CustomerId { get; set; }
        public int VisitorId { get; set; }
        public int LoanId { get; set; }
        public decimal? LoanAmount { get; set; }
        public string RequestedBy { get; set; }
        public string AuthorizedBy { get; set; }
        public DateTime AuthorizedDate { get; set; }
    }
}
