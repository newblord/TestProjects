using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class ExpenseType
    {
        public ExpenseType()
        {
            CompanyExpenseType = new HashSet<CompanyExpenseType>();
            CustomerExpenseDetail = new HashSet<CustomerExpenseDetail>();
            LoanApplicationExpenseDetail = new HashSet<LoanApplicationExpenseDetail>();
        }

        public int ExpenseTypeKey { get; set; }
        public int Code { get; set; }
        public string Description { get; set; }
        public string HelpDescription { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }

        public virtual ICollection<CompanyExpenseType> CompanyExpenseType { get; set; }
        public virtual ICollection<CustomerExpenseDetail> CustomerExpenseDetail { get; set; }
        public virtual ICollection<LoanApplicationExpenseDetail> LoanApplicationExpenseDetail { get; set; }
    }
}
