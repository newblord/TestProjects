using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class Risaudit
    {
        public Risaudit()
        {
            FormLetter = new HashSet<FormLetter>();
            FormLetterAuditCode = new HashSet<FormLetterAuditCode>();
            Ris = new HashSet<Ris>();
            Risrept = new HashSet<Risrept>();
            SkipTraceStepAuditCategory = new HashSet<SkipTraceStepAuditCategory>();
        }

        public string Audit { get; set; }
        public string Desc { get; set; }
        public string Short { get; set; }
        public int RisAuditId { get; set; }
        public bool? Displayed { get; set; }
        public bool IsAdAstra { get; set; }
        public bool IsInLegalStatus { get; set; }
        public int RisAuditKey { get; set; }
        public bool DialerExclude { get; set; }
        public bool SuspendInterest { get; set; }
        public bool Repossession { get; set; }
        public bool BlockEmails { get; set; }
        public bool IsEligibleForRepo { get; set; }
        public bool BlockStatements { get; set; }
        public bool? IsPtp { get; set; }

        public virtual ICollection<FormLetter> FormLetter { get; set; }
        public virtual ICollection<FormLetterAuditCode> FormLetterAuditCode { get; set; }
        public virtual ICollection<Ris> Ris { get; set; }
        public virtual ICollection<Risrept> Risrept { get; set; }
        public virtual ICollection<SkipTraceStepAuditCategory> SkipTraceStepAuditCategory { get; set; }
    }
}
