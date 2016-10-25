using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LoanPaymentLoanCheckXref
    {
        public int LpLcXrefKey { get; set; }
        public int LoanPaymentKey { get; set; }
        public int LoanCheckKey { get; set; }

        public virtual LoanCheck LoanCheckKeyNavigation { get; set; }
    }
}
