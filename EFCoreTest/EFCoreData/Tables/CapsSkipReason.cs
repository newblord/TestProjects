using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CapsSkipReason
    {
        public CapsSkipReason()
        {
            CapsHold = new HashSet<CapsHold>();
        }

        public byte CapsSkipReasonKey { get; set; }
        public string SkipDesc { get; set; }

        public virtual ICollection<CapsHold> CapsHold { get; set; }
    }
}
