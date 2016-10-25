using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class SpecialMessageLoanProduct
    {
        public int SpecialMessageLoanProductKey { get; set; }
        public int SpecialMessageKey { get; set; }
        public int LoanProductKey { get; set; }

        public virtual LoanProduct LoanProductKeyNavigation { get; set; }
        public virtual SpecialMessage SpecialMessageKeyNavigation { get; set; }
    }
}
