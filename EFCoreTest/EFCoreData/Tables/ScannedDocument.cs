using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class ScannedDocument
    {
        public ScannedDocument()
        {
            ScannedDocumentOverride = new HashSet<ScannedDocumentOverride>();
        }

        public int ScannedDocumentKey { get; set; }
        public int TransDetailKey { get; set; }
        public int? LoanDocKey { get; set; }
        public int? DocumentSystemKey { get; set; }
        public DateTime? DocumentSystemScanDate { get; set; }

        public virtual ICollection<ScannedDocumentOverride> ScannedDocumentOverride { get; set; }
        public virtual LoanDoc LoanDocKeyNavigation { get; set; }
        public virtual TransDetail TransDetailKeyNavigation { get; set; }
    }
}
