using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class DocuwareCabinet
    {
        public DocuwareCabinet()
        {
            DocuwareLoanLkup = new HashSet<DocuwareLoanLkup>();
        }

        public int DocuwareCabinetKey { get; set; }
        public short ServerId { get; set; }
        public string CabinetDbTable { get; set; }
        public string DwReferenceLookup { get; set; }

        public virtual ICollection<DocuwareLoanLkup> DocuwareLoanLkup { get; set; }
    }
}
