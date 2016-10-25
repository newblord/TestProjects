using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class ErrorLogBase
    {
        public int ErrorLogKey { get; set; }
        public string ErrorMessage { get; set; }
        public string SupportMessage { get; set; }
        public int? VisitorKey { get; set; }
        public int? CustomerKey { get; set; }
        public int? ApplicationKey { get; set; }
        public int? LoanKey { get; set; }
        public int? Severity { get; set; }
        public string Client { get; set; }
        public string Tier { get; set; }
        public string CodeLocation { get; set; }
        public string ExceptionText { get; set; }
        public string StateDump { get; set; }
        public int? TransDetail { get; set; }
        public string WebServer { get; set; }
        public string AppServer { get; set; }
        public string UserAgent { get; set; }
        public string Browser { get; set; }
        public DateTime DateEntered { get; set; }
        public DateTime? DateEnteredDay { get; set; }
        public DateTime? DateEnteredHour { get; set; }
        public DateTime? DateEnteredMinute { get; set; }
        public string CurrentPage { get; set; }
        public string ReferringPage { get; set; }
        public bool? SupportRedirect { get; set; }
    }
}
