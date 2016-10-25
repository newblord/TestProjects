using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CashedCheckPayment
    {
        public CashedCheckPayment()
        {
            AttorneyPayment = new HashSet<AttorneyPayment>();
            CashedCheckPaymentRefund = new HashSet<CashedCheckPaymentRefund>();
            CashedCheckPaymentRefundXrefRefundCashedCheckPaymentKeyNavigation = new HashSet<CashedCheckPaymentRefundXref>();
            CashedCheckPaymentRefundXrefRefundedCashedCheckPaymentKeyNavigation = new HashSet<CashedCheckPaymentRefundXref>();
        }

        public int CashedCheckPaymentKey { get; set; }
        public int CashedCheckKey { get; set; }
        public int TransDetailKey { get; set; }
        public short Location { get; set; }
        public string Teller { get; set; }
        public DateTime DateEntered { get; set; }
        public string Note { get; set; }
        public decimal PaidAmt { get; set; }
        public bool Reversed { get; set; }
        public DateTime? ReversedDate { get; set; }
        public short PaymentMethod { get; set; }
        public byte TransCode { get; set; }

        public virtual ICollection<AttorneyPayment> AttorneyPayment { get; set; }
        public virtual ICollection<CashedCheckPaymentRefund> CashedCheckPaymentRefund { get; set; }
        public virtual ICollection<CashedCheckPaymentRefundXref> CashedCheckPaymentRefundXrefRefundCashedCheckPaymentKeyNavigation { get; set; }
        public virtual ICollection<CashedCheckPaymentRefundXref> CashedCheckPaymentRefundXrefRefundedCashedCheckPaymentKeyNavigation { get; set; }
        public virtual CashedCheck CashedCheckKeyNavigation { get; set; }
    }
}
