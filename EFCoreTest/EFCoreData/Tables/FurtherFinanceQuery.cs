using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class FurtherFinanceQuery
    {
        public FurtherFinanceQuery()
        {
            FurtherFinanceExecutionLogDetail = new HashSet<FurtherFinanceExecutionLogDetail>();
            FurtherFinanceResultDetail = new HashSet<FurtherFinanceResultDetail>();
        }

        public int FurtherFinanceQueryKey { get; set; }
        public string QueryName { get; set; }
        public string Description { get; set; }

        public virtual ICollection<FurtherFinanceExecutionLogDetail> FurtherFinanceExecutionLogDetail { get; set; }
        public virtual ICollection<FurtherFinanceResultDetail> FurtherFinanceResultDetail { get; set; }
    }
}
