using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LoanApplicationExpenseDetail
    {
        public int LoanApplicationExpenseDetailKey { get; set; }
        public int LoanApplicationExpenseKey { get; set; }
        public int ExpenseTypeKey { get; set; }
        public decimal? Amount { get; set; }

        public virtual ExpenseType ExpenseTypeKeyNavigation { get; set; }
        public virtual LoanApplicationExpense LoanApplicationExpenseKeyNavigation { get; set; }
    }
}
