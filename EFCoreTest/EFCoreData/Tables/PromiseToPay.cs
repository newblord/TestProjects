using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class PromiseToPay
    {
        public PromiseToPay()
        {
            PromiseToPayDetail = new HashSet<PromiseToPayDetail>();
        }

        public int PromiseToPayKey { get; set; }
        public int CustomerKey { get; set; }
        public int RisreptKey { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }
        public byte PtpPmts { get; set; }
        public short PtpLocation { get; set; }
        public string PtpCourtesyCall { get; set; }
        public string ApprovedBy { get; set; }
        public bool Cancelled { get; set; }
        public bool WaiveFee { get; set; }
        public DateTime? CancelledDate { get; set; }
        public string CancelledBy { get; set; }
        public int? CollectionActionKey { get; set; }
        public DateTime? ReversedDate { get; set; }
        public bool Reversed { get; set; }
        public int PtpConfigKey { get; set; }
        public int? TransDetailKey { get; set; }
        public int? CustomerDocumentKey { get; set; }

        public virtual ICollection<PromiseToPayDetail> PromiseToPayDetail { get; set; }
        public virtual Customer CustomerKeyNavigation { get; set; }
        public virtual RiptppaymentPlanConfig PtpConfigKeyNavigation { get; set; }
        public virtual Risrept RisreptKeyNavigation { get; set; }
    }
}
