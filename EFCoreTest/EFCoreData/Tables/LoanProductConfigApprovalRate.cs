using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LoanProductConfigApprovalRate
    {
        public int LoanProductConfigApprovalRateKey { get; set; }
        public int LoanProductConfigKey { get; set; }
        public decimal IncomeToAmt { get; set; }
        public decimal ApprovalVal { get; set; }
        public string ApprovalPctOrAmt { get; set; }
        public DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string UpdatedBy { get; set; }

        public virtual LoanProductConfig LoanProductConfigKeyNavigation { get; set; }
    }
}
