using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class RbcEfundSecurity
    {
        public int RbcEfundSecurityKey { get; set; }
        public int LoanKey { get; set; }
        public int SecurityCode { get; set; }

        public virtual Loan LoanKeyNavigation { get; set; }
    }
}
