using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class MpayAmort
    {
        public MpayAmort()
        {
            MpayAmortDueDateChange = new HashSet<MpayAmortDueDateChange>();
        }

        public int MpayAmortKey { get; set; }
        public int LoanKey { get; set; }
        public byte PaymentNum { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal PaymentAmt { get; set; }
        public decimal PrincAmt { get; set; }
        public decimal InterestAmt { get; set; }
        public decimal Balance { get; set; }
        public decimal TransFeeAmt { get; set; }
        public decimal LoanFeeAmt { get; set; }
        public decimal CabInterestAmt { get; set; }
        public decimal DiscountAmt { get; set; }
        public DateTime AdjustedPaymentDate { get; set; }
        public decimal InsuranceFeeAmt { get; set; }

        public virtual ICollection<MpayAmortDueDateChange> MpayAmortDueDateChange { get; set; }
        public virtual Loan LoanKeyNavigation { get; set; }
    }
}
