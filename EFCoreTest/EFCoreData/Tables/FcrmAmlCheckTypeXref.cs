using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class FcrmAmlCheckTypeXref
    {
        public int FcrmAmlChecktypeXrefKey { get; set; }
        public int FcrmAmlTransCodeKey { get; set; }
        public int CheckTypeKey { get; set; }
        public DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }

        public virtual FcrmAmlTransCode FcrmAmlTransCodeKeyNavigation { get; set; }
    }
}
