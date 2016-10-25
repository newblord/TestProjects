using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class PrepaidCardStopPayment
    {
        public PrepaidCardStopPayment()
        {
            PrepaidCardStopPaymentEdit = new HashSet<PrepaidCardStopPaymentEdit>();
        }

        public int PrepaidCardStopPaymentKey { get; set; }
        public int CreditCardKey { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }
        public string SourceInstitution { get; set; }
        public decimal? StopPaymentAmount { get; set; }
        public int PrepaidCardStopPaymentReasonKey { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime? CancelledDate { get; set; }
        public string CancelledBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public string LastUpdatedBy { get; set; }
        public string OtherReasonDescribe { get; set; }
        public bool ReportedToVendor { get; set; }
        public DateTime? ReportedToVendorDate { get; set; }

        public virtual ICollection<PrepaidCardStopPaymentEdit> PrepaidCardStopPaymentEdit { get; set; }
        public virtual CreditCards CreditCardKeyNavigation { get; set; }
        public virtual PrepaidCardStopPaymentReason PrepaidCardStopPaymentReasonKeyNavigation { get; set; }
    }
}
