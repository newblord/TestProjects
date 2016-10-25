using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class FcrmAmlServiceXref
    {
        public int FcrmAmlServiceXrefKey { get; set; }
        public int FcrmAmlTransCodeKey { get; set; }
        public int ServiceMasterKey { get; set; }
        public DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }

        public virtual FcrmAmlTransCode FcrmAmlTransCodeKeyNavigation { get; set; }
    }
}
