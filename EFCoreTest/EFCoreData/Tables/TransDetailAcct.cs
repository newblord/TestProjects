using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class TransDetailAcct
    {
        public int TransDetailAcctKey { get; set; }
        public int TransDetailKey { get; set; }
        public short Location { get; set; }
        public byte AcctType { get; set; }
        public decimal Amount { get; set; }
        public int GlAcct { get; set; }

        public virtual Glacct GlAcctNavigation { get; set; }
        public virtual TransDetail TransDetailKeyNavigation { get; set; }
    }
}
