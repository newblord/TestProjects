using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebVisitSrcXref
    {
        public int WebVisitSrcXrefKey { get; set; }
        public int? LoanKey { get; set; }
        public int? CustomerKey { get; set; }
        public int? LoanApplicationKey { get; set; }
        public int? VisitorKey { get; set; }
        public string WebVisitSessionGuid { get; set; }
        public long WebVisitSourceKey { get; set; }
        public string SourceCreditCategory { get; set; }
    }
}
