using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class DocumentSigningStatus
    {
        public int DocumentSigningStatusKey { get; set; }
        public DateTime DateEntered { get; set; }
        public int? LoanApplicationKey { get; set; }
        public int? LoanKey { get; set; }
        public string GeneratedPin { get; set; }
        public bool IsPinValidated { get; set; }
        public DateTime? ValidatedDate { get; set; }

        public virtual LoanApplication LoanApplicationKeyNavigation { get; set; }
        public virtual Loan LoanKeyNavigation { get; set; }
    }
}
