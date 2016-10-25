using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LoanPaymentSuspendInterest
    {
        public int LoanPaymentSuspendInterestKey { get; set; }
        public int LoanPaymentSuspendKey { get; set; }
        public int? LoanPaymentResumeKey { get; set; }
        public DateTime? ResumeInterestDate { get; set; }
        public bool IsResumeOnPayment { get; set; }
        public string Status { get; set; }

        public virtual LoanPayment LoanPaymentResumeKeyNavigation { get; set; }
        public virtual LoanPayment LoanPaymentSuspendKeyNavigation { get; set; }
    }
}
