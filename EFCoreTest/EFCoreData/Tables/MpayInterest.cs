using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class MpayInterest
    {
        public int MpayInterestKey { get; set; }
        public int LoanKey { get; set; }
        public decimal PrincDue { get; set; }
        public decimal InterestAdded { get; set; }
        public DateTime DateEntered { get; set; }
        public DateTime InterestDate { get; set; }
        public decimal LoanBalance { get; set; }
        public bool IsAchAdj { get; set; }
        public bool IsErrAdj { get; set; }
        public decimal TransFeeAdded { get; set; }
        public decimal CabInterestAdded { get; set; }
        public bool IsDiscount { get; set; }
        public decimal? CollectionsAmt { get; set; }

        public virtual Loan LoanKeyNavigation { get; set; }
    }
}
