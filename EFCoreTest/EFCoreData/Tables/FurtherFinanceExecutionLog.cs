using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class FurtherFinanceExecutionLog
    {
        public FurtherFinanceExecutionLog()
        {
            FurtherFinanceExecutionLogDetail = new HashSet<FurtherFinanceExecutionLogDetail>();
        }

        public int FurtherFinanceExecutionLogKey { get; set; }
        public int? FurtherFinanceParentOutcomeKey { get; set; }
        public int CustomerKey { get; set; }
        public string ProductType { get; set; }
        public string LoanType { get; set; }
        public DateTime? DateEntered { get; set; }
        public string Teller { get; set; }
        public int? LoanApplicationKey { get; set; }

        public virtual ICollection<FurtherFinanceExecutionLogDetail> FurtherFinanceExecutionLogDetail { get; set; }
        public virtual LoanApplication LoanApplicationKeyNavigation { get; set; }
    }
}
