using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LoanDoc
    {
        public LoanDoc()
        {
            LoanDocPrinted = new HashSet<LoanDocPrinted>();
            LoanDocUsed = new HashSet<LoanDocUsed>();
            ScannedDocument = new HashSet<ScannedDocument>();
        }

        public int LoanDocKey { get; set; }
        public byte LoanDocTypeKey { get; set; }
        public string LoanDocFilename { get; set; }
        public string LoanDocExt { get; set; }
        public string LoanDocRevision { get; set; }
        public byte[] LoanDocFile { get; set; }
        public string LoanDocState { get; set; }
        public string LoanDocLanguage { get; set; }
        public bool LoanDocEnabled { get; set; }
        public bool PrintOnlyMilitary { get; set; }
        public string Teller { get; set; }
        public DateTime DateEntered { get; set; }

        public virtual ICollection<LoanDocPrinted> LoanDocPrinted { get; set; }
        public virtual ICollection<LoanDocUsed> LoanDocUsed { get; set; }
        public virtual ICollection<ScannedDocument> ScannedDocument { get; set; }
        public virtual LoanDocType LoanDocTypeKeyNavigation { get; set; }
    }
}
