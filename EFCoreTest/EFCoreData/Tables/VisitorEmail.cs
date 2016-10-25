using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class VisitorEmail
    {
        public VisitorEmail()
        {
            VisitorEmailDisposition = new HashSet<VisitorEmailDisposition>();
            WebBlobVisitorEmailXref = new HashSet<WebBlobVisitorEmailXref>();
        }

        public int VisitorEmailKey { get; set; }
        public int VisitorKey { get; set; }
        public string EmailAddress { get; set; }
        public byte EmailId { get; set; }
        public string EmailSubject { get; set; }
        public string EmailBody { get; set; }
        public DateTime DateEntered { get; set; }
        public int? LoanApplicationKey { get; set; }
        public int? LoanKey { get; set; }
        public string EmailOrigination { get; set; }
        public string EmailFromAddress { get; set; }
        public int? EmailTemplateKey { get; set; }
        public DateTime? EmailDate { get; set; }

        public virtual ICollection<VisitorEmailDisposition> VisitorEmailDisposition { get; set; }
        public virtual ICollection<WebBlobVisitorEmailXref> WebBlobVisitorEmailXref { get; set; }
        public virtual EmailTemplate EmailTemplateKeyNavigation { get; set; }
        public virtual LoanApplication LoanApplicationKeyNavigation { get; set; }
        public virtual Loan LoanKeyNavigation { get; set; }
        public virtual Visitor VisitorKeyNavigation { get; set; }
    }
}
