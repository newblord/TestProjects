using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebErrorLog
    {
        public int WebErrorLogKey { get; set; }
        public int? VisitorKey { get; set; }
        public int? ApplicationKey { get; set; }
        public int? CustomerKey { get; set; }
        public int? LoanKey { get; set; }
        public string CurrentPage { get; set; }
        public string ExceptionType { get; set; }
        public DateTime DateEntered { get; set; }
        public string ErrorMsg { get; set; }

        public virtual LoanApplication ApplicationKeyNavigation { get; set; }
        public virtual Customer CustomerKeyNavigation { get; set; }
        public virtual Loan LoanKeyNavigation { get; set; }
        public virtual Visitor VisitorKeyNavigation { get; set; }
    }
}
