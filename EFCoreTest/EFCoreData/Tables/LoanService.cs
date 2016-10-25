using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LoanService
    {
        public int LoanServiceKey { get; set; }
        public int LoanKey { get; set; }
        public int ServiceDetailKey { get; set; }
        public decimal ServiceCost { get; set; }
        public decimal Price { get; set; }
        public decimal MarkDown { get; set; }
        public decimal SalesTax { get; set; }
        public decimal DownPayment { get; set; }

        public virtual Loan LoanKeyNavigation { get; set; }
        public virtual ServiceDetail ServiceDetailKeyNavigation { get; set; }
    }
}
