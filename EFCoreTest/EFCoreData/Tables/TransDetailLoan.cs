using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class TransDetailLoan
    {
        public int TransDetailLoanKey { get; set; }
        public int TransDetailKey { get; set; }
        public short Location { get; set; }
        public string LoanFrom { get; set; }
        public string LoanTo { get; set; }
        public string LoanType { get; set; }
        public decimal LoanAmt { get; set; }
        public byte LoanCnt { get; set; }
        public string ProductType { get; set; }

        public virtual TransDetail TransDetailKeyNavigation { get; set; }
    }
}
