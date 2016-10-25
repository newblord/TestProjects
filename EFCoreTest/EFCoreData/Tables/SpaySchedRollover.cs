using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class SpaySchedRollover
    {
        public SpaySchedRollover()
        {
            SpaySchedRolloverDetail = new HashSet<SpaySchedRolloverDetail>();
        }

        public int SpaySchedRolloverKey { get; set; }
        public int LoanKey { get; set; }
        public int ZeroRecLoanKey { get; set; }
        public int CustomerKey { get; set; }
        public int LoanPaymentKey { get; set; }
        public byte NumRollovers { get; set; }

        public virtual ICollection<SpaySchedRolloverDetail> SpaySchedRolloverDetail { get; set; }
        public virtual Customer CustomerKeyNavigation { get; set; }
        public virtual Loan LoanKeyNavigation { get; set; }
    }
}
