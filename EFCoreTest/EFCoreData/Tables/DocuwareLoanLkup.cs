using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class DocuwareLoanLkup
    {
        public int DocuwareLoanLkupKey { get; set; }
        public int DocuwareCabinetKey { get; set; }
        public int LoanKey { get; set; }
        public int Dwdocid { get; set; }

        public virtual DocuwareCabinet DocuwareCabinetKeyNavigation { get; set; }
        public virtual Loan LoanKeyNavigation { get; set; }
    }
}
