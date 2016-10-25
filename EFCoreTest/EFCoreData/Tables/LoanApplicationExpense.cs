using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LoanApplicationExpense
    {
        public LoanApplicationExpense()
        {
            LoanApplicationExpenseDetail = new HashSet<LoanApplicationExpenseDetail>();
        }

        public int LoanApplicationExpenseKey { get; set; }
        public DateTime DateEntered { get; set; }
        public int? LoanApplicationKey { get; set; }
        public int? RolloverRequestKey { get; set; }
        public int VisitorKey { get; set; }
        public bool? IsCustomerVerified { get; set; }

        public virtual ICollection<LoanApplicationExpenseDetail> LoanApplicationExpenseDetail { get; set; }
        public virtual LoanApplication LoanApplicationKeyNavigation { get; set; }
        public virtual RolloverRequest RolloverRequestKeyNavigation { get; set; }
        public virtual Visitor VisitorKeyNavigation { get; set; }
    }
}
