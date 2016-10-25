using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LoanCheck
    {
        public LoanCheck()
        {
            LoanPaymentLoanCheckXref = new HashSet<LoanPaymentLoanCheckXref>();
        }

        public int LoanCheckKey { get; set; }
        public int LoanKey { get; set; }
        public string Sequence { get; set; }
        public string CheckNo { get; set; }
        public decimal CheckAmt { get; set; }
        public DateTime OrigDueDate { get; set; }
        public DateTime AdjustedDueDate { get; set; }
        public string CheckStatus { get; set; }
        public DateTime StatusDate { get; set; }
        public bool Shredded { get; set; }

        public virtual ICollection<LoanPaymentLoanCheckXref> LoanPaymentLoanCheckXref { get; set; }
        public virtual Loan LoanKeyNavigation { get; set; }
    }
}
