using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class OpenEndInterest
    {
        public int OpenEndInterestKey { get; set; }
        public int LoanKey { get; set; }
        public decimal PrincDue { get; set; }
        public decimal InterestAdded { get; set; }
        public DateTime DateEntered { get; set; }
        public DateTime InterestDate { get; set; }
        public int? OpenEndLoanStmtKey { get; set; }
        public decimal LoanBalance { get; set; }
        public decimal CsoLenderInterestAdded { get; set; }
        public bool IsAchAdj { get; set; }
        public bool IsErrAdj { get; set; }
        public decimal CabFeeBalance { get; set; }
        public decimal? CollectionsAmt { get; set; }
        public bool IsGracePeriodAdj { get; set; }

        public virtual OpenEndLoanStatement OpenEndLoanStmtKeyNavigation { get; set; }
    }
}
