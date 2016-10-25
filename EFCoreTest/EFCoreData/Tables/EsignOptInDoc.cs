using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class EsignOptInDoc
    {
        public int EsignOptInDocKey { get; set; }
        public string DocXml { get; set; }
        public string Language { get; set; }
        public string DocName { get; set; }
        public DateTime DateUpdated { get; set; }
        public string UpdatedBy { get; set; }
    }
}
