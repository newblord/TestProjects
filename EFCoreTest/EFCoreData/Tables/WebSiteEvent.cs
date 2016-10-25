using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebSiteEvent
    {
        public int WebSiteEventKey { get; set; }
        public int? CustomerKey { get; set; }
        public int? VisitorKey { get; set; }
        public int? LoanKey { get; set; }
        public int? LoanApplicationKey { get; set; }
        public string EventName { get; set; }
        public string Comments { get; set; }
        public DateTime DateEntered { get; set; }
    }
}
