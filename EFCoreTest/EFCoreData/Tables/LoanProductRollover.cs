using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LoanProductRollover
    {
        public int LoanProductRolloverKey { get; set; }
        public int LoanProductKeyPaidLoan { get; set; }
        public int LoanProductKeyNewLoan { get; set; }
        public short Location { get; set; }
        public DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string UpdatedBy { get; set; }

        public virtual LoanProduct LoanProductKeyNewLoanNavigation { get; set; }
        public virtual LoanProductConfig LoanProductKeyPaidLoanNavigation { get; set; }
        public virtual Company LocationNavigation { get; set; }
    }
}
