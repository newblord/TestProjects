using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class FurtherFinanceJobType
    {
        public int FurtherFinanceJobTypeKey { get; set; }
        public int IncomeJobTypeKey { get; set; }
        public decimal Increase1 { get; set; }
        public decimal Increase2 { get; set; }

        public virtual IncomeJobType IncomeJobTypeKeyNavigation { get; set; }
    }
}
