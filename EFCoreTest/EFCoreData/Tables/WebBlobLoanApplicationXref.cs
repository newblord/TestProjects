using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebBlobLoanApplicationXref
    {
        public int WebBlobLoanApplicationXrefKey { get; set; }
        public int WebBlobKey { get; set; }
        public int LoanApplicationKey { get; set; }
        public string Description { get; set; }
        public DateTime DateEntered { get; set; }
        public string SourceUrl { get; set; }

        public virtual LoanApplication LoanApplicationKeyNavigation { get; set; }
        public virtual WebBlob WebBlobKeyNavigation { get; set; }
    }
}
