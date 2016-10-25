using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class FormLetterAuditCode
    {
        public int FormLetterKey { get; set; }
        public int AuditCodeKey { get; set; }

        public virtual Risaudit AuditCodeKeyNavigation { get; set; }
        public virtual FormLetter FormLetterKeyNavigation { get; set; }
    }
}
