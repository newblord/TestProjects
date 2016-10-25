using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CustomerExpense
    {
        public CustomerExpense()
        {
            CustomerExpenseDetail = new HashSet<CustomerExpenseDetail>();
        }

        public int CustomerExpenseKey { get; set; }
        public int CustomerKey { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }

        public virtual ICollection<CustomerExpenseDetail> CustomerExpenseDetail { get; set; }
        public virtual Customer CustomerKeyNavigation { get; set; }
    }
}
