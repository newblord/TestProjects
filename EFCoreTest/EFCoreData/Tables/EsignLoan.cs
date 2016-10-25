using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class EsignLoan
    {
        public int LoanKey { get; set; }
        public byte[] Document { get; set; }
        public byte EsignStatusKey { get; set; }
        public DateTime DateEntered { get; set; }
        public bool IsSubmitted { get; set; }
        public string SubmitError { get; set; }

        public virtual EsignLoanStatus EsignStatusKeyNavigation { get; set; }
    }
}
