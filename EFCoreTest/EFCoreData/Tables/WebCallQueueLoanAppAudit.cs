using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebCallQueueLoanAppAudit
    {
        public int WebCallQueueLoanAppAuditKey { get; set; }
        public int WebCallQueueKey { get; set; }
        public int LoanApplicationKey { get; set; }
        public bool? IsQualified { get; set; }
        public string ReasonDenied { get; set; }
        public DateTime DateCreated { get; set; }

        public virtual WebCallQueue WebCallQueueKeyNavigation { get; set; }
    }
}
