using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebLoanCreditFraud
    {
        public int WebLoanCreditFraudKey { get; set; }
        public int CustomerKey { get; set; }
        public int TransDetailKey { get; set; }
        public short Location { get; set; }
        public int LoanKey { get; set; }
        public string FraudType { get; set; }
        public bool IsProcessed { get; set; }
        public DateTime DateEntered { get; set; }

        public virtual Customer CustomerKeyNavigation { get; set; }
        public virtual Loan LoanKeyNavigation { get; set; }
        public virtual Company LocationNavigation { get; set; }
        public virtual TransDetail TransDetailKeyNavigation { get; set; }
    }
}
