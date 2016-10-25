using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class ProductOpenLoanMatrix
    {
        public int ProductOpenLoanMatrixKey { get; set; }
        public short Location { get; set; }
        public int LoanProductKeyOpen { get; set; }
        public int LoanProductKeyAllowed { get; set; }

        public virtual LoanProduct LoanProductKeyAllowedNavigation { get; set; }
        public virtual LoanProduct LoanProductKeyOpenNavigation { get; set; }
        public virtual Company LocationNavigation { get; set; }
    }
}
