using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LoanPaymentRescind
    {
        public int LoanPaymentRescindKey { get; set; }
        public int LoanPaymentKey { get; set; }
        public int CashAdvanceLoanPaymentKey { get; set; }
        public decimal RescindAmount { get; set; }
        public decimal InterestRebate { get; set; }
        public decimal CabLenderInterestRebate { get; set; }

        public virtual LoanPayment CashAdvanceLoanPaymentKeyNavigation { get; set; }
        public virtual LoanPayment LoanPaymentKeyNavigation { get; set; }
    }
}
