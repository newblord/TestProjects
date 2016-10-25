using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CompanyExpenseType
    {
        public int CompanyExpenseTypeKey { get; set; }
        public short Location { get; set; }
        public int ExpenseTypeKey { get; set; }

        public virtual ExpenseType ExpenseTypeKeyNavigation { get; set; }
        public virtual Company LocationNavigation { get; set; }
    }
}
