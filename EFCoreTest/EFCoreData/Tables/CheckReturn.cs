using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CheckReturn
    {
        public int CheckReturnKey { get; set; }
        public int TransDetailKey { get; set; }
        public int CrGlAcct { get; set; }
        public byte CrReasonCode { get; set; }

        public virtual Glacct CrGlAcctNavigation { get; set; }
    }
}
