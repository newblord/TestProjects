using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class EmailTemplate
    {
        public EmailTemplate()
        {
            VisitorEmail = new HashSet<VisitorEmail>();
        }

        public int EmailTemplateKey { get; set; }
        public DateTime DateEntered { get; set; }
        public bool IsActive { get; set; }
        public byte EmailId { get; set; }
        public string EmailFrom { get; set; }
        public string SubjectLine { get; set; }
        public string BodyHtml { get; set; }
        public string Notes { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string UpdatedBy { get; set; }
        public string EnteredBy { get; set; }

        public virtual ICollection<VisitorEmail> VisitorEmail { get; set; }
    }
}
