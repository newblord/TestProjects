using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class FurtherFinanceResult
    {
        public FurtherFinanceResult()
        {
            FurtherFinanceResultDetail = new HashSet<FurtherFinanceResultDetail>();
        }

        public int FurtherFinanceResultKey { get; set; }
        public int? FurtherFinanceParentOutcomeKey { get; set; }
        public int? LoanApplicationKey { get; set; }
        public int CustomerKey { get; set; }
        public DateTime? DateEntered { get; set; }
        public string Teller { get; set; }
        public string ProductTypeSelected { get; set; }

        public virtual ICollection<FurtherFinanceResultDetail> FurtherFinanceResultDetail { get; set; }
        public virtual Customer CustomerKeyNavigation { get; set; }
        public virtual LoanApplication LoanApplicationKeyNavigation { get; set; }
    }
}
