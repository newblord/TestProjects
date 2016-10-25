using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebBlobLoanXref
    {
        public int WebBlobLoanXrefKey { get; set; }
        public int WebBlobKey { get; set; }
        public int LoanKey { get; set; }
        public string Description { get; set; }
        public DateTime DateEntered { get; set; }

        public virtual Loan LoanKeyNavigation { get; set; }
        public virtual WebBlob WebBlobKeyNavigation { get; set; }
    }
}
