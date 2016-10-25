using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class ScannedDocumentOverride
    {
        public int ScannedDocumentOverrideKey { get; set; }
        public int ScannedDocumentKey { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }
        public string Code { get; set; }

        public virtual ScannedDocument ScannedDocumentKeyNavigation { get; set; }
    }
}
