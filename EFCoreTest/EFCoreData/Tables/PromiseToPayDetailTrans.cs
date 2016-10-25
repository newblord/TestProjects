using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class PromiseToPayDetailTrans
    {
        public int PtpDetailTransKey { get; set; }
        public int PtpDetailKey { get; set; }
        public decimal PtpAmount { get; set; }
        public bool Reversed { get; set; }
        public DateTime? ReversedDate { get; set; }
        public int TransDetailKey { get; set; }

        public virtual PromiseToPayDetail PtpDetailKeyNavigation { get; set; }
        public virtual TransDetail TransDetailKeyNavigation { get; set; }
    }
}
