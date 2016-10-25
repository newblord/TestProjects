using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CourtesyPayout
    {
        public int CourtesyPayoutKey { get; set; }
        public int TransDetailKey { get; set; }
        public int? LoanKey { get; set; }
        public int CustomerKey { get; set; }
        public decimal CourtesyPayoutAmt { get; set; }
        public string CourtesyPayoutType { get; set; }
        public int? ServiceTransKey { get; set; }
        public DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public short Location { get; set; }
        public string Note { get; set; }
        public string RtfNote { get; set; }
        public int? CashedCheckKey { get; set; }

        public virtual CashedCheck CashedCheckKeyNavigation { get; set; }
        public virtual Customer CustomerKeyNavigation { get; set; }
        public virtual Loan LoanKeyNavigation { get; set; }
        public virtual ServiceTrans ServiceTransKeyNavigation { get; set; }
        public virtual TransDetail TransDetailKeyNavigation { get; set; }
    }
}
