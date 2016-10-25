using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class Smsinbound
    {
        public Smsinbound()
        {
            RolloverRequest = new HashSet<RolloverRequest>();
        }

        public int SmsInboundKey { get; set; }
        public string SmsSource { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? ReceivedDate { get; set; }
        public string CallingFromNumber { get; set; }
        public string CallingToNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Message { get; set; }
        public int? SmsOutboundKey { get; set; }
        public int? LoanApplicationKey { get; set; }
        public int? LoanKey { get; set; }
        public int? VisitorKey { get; set; }
        public int? WebCallQueueKey { get; set; }
        public DateTime? LockedDate { get; set; }
        public Guid? LockedGuid { get; set; }
        public bool? Closed { get; set; }

        public virtual ICollection<RolloverRequest> RolloverRequest { get; set; }
        public virtual LoanApplication LoanApplicationKeyNavigation { get; set; }
        public virtual Loan LoanKeyNavigation { get; set; }
        public virtual Smsoutbound SmsOutboundKeyNavigation { get; set; }
        public virtual Visitor VisitorKeyNavigation { get; set; }
        public virtual WebCallQueue WebCallQueueKeyNavigation { get; set; }
    }
}
