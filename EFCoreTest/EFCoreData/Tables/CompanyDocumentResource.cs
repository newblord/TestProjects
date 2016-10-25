using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CompanyDocumentResource
    {
        public int CompanyDocumentResourceKey { get; set; }
        public short Location { get; set; }
        public int DocumentResourceKey { get; set; }
        public string DocumentFieldName { get; set; }

        public virtual DocumentResource DocumentResourceKeyNavigation { get; set; }
        public virtual Company LocationNavigation { get; set; }
    }
}
