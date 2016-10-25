using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class FurtherFinanceOutcome
    {
        public FurtherFinanceOutcome()
        {
            FurtherFinanceExecutionLogDetail = new HashSet<FurtherFinanceExecutionLogDetail>();
            FurtherFinanceResultDetail = new HashSet<FurtherFinanceResultDetail>();
        }

        public int FurtherFinanceOutcomeKey { get; set; }
        public string OutcomeDescription { get; set; }
        public decimal OutcomeApprovalPct { get; set; }

        public virtual ICollection<FurtherFinanceExecutionLogDetail> FurtherFinanceExecutionLogDetail { get; set; }
        public virtual ICollection<FurtherFinanceResultDetail> FurtherFinanceResultDetail { get; set; }
    }
}
