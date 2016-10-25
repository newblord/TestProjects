using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class FcrmAmlTransCodeXref
    {
        public int FcrmAmlTransCodeXrefKey { get; set; }
        public int FcrmAmlTransCodeKey { get; set; }
        public int TransCode { get; set; }
        public DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }

        public virtual FcrmAmlTransCode FcrmAmlTransCodeKeyNavigation { get; set; }
    }
}
