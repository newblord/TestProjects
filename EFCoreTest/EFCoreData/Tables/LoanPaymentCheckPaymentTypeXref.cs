using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LoanPaymentCheckPaymentTypeXref
    {
        public int LoanPaymentCheckPaymentTypeXrefKey { get; set; }
        public int LoanPaymentKey { get; set; }
        public int CheckPaymentTypeKey { get; set; }
        public DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }

        public virtual CheckPaymentType CheckPaymentTypeKeyNavigation { get; set; }
    }
}
