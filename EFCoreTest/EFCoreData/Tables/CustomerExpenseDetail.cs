using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CustomerExpenseDetail
    {
        public int CustomerExpenseDetailKey { get; set; }
        public int CustomerExpenseKey { get; set; }
        public int ExpenseTypeKey { get; set; }
        public decimal? Amount { get; set; }

        public virtual CustomerExpense CustomerExpenseKeyNavigation { get; set; }
        public virtual ExpenseType ExpenseTypeKeyNavigation { get; set; }
    }
}
