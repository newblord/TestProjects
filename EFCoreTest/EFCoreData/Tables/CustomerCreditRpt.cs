using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CustomerCreditRpt
    {
        public CustomerCreditRpt()
        {
            CustomerCreditRptDetail = new HashSet<CustomerCreditRptDetail>();
        }

        public int CreditRptKey { get; set; }
        public int CustomerKey { get; set; }
        public int Location { get; set; }
        public string Teller { get; set; }
        public DateTime DateEntered { get; set; }

        public virtual ICollection<CustomerCreditRptDetail> CustomerCreditRptDetail { get; set; }
        public virtual Customer CustomerKeyNavigation { get; set; }
    }
}
