using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class Smsoutbound
    {
        public Smsoutbound()
        {
            SmsfailedSend = new HashSet<SmsfailedSend>();
            Smsinbound = new HashSet<Smsinbound>();
            Smsresponse = new HashSet<Smsresponse>();
        }

        public int SmsOutboundKey { get; set; }
        public DateTime? InitiatedDate { get; set; }
        public int? LoanApplicationKey { get; set; }
        public int? LoanKey { get; set; }
        public DateTime? LockedDate { get; set; }
        public Guid? LockedGuid { get; set; }
        public string Message { get; set; }
        public string MobileNumber { get; set; }
        public DateTime? SentDate { get; set; }
        public int? SmsSenderKey { get; set; }
        public int? VisitorKey { get; set; }

        public virtual ICollection<SmsfailedSend> SmsfailedSend { get; set; }
        public virtual ICollection<Smsinbound> Smsinbound { get; set; }
        public virtual ICollection<Smsresponse> Smsresponse { get; set; }
        public virtual LoanApplication LoanApplicationKeyNavigation { get; set; }
        public virtual Loan LoanKeyNavigation { get; set; }
        public virtual Smssender SmsSenderKeyNavigation { get; set; }
        public virtual Visitor VisitorKeyNavigation { get; set; }
    }
}
