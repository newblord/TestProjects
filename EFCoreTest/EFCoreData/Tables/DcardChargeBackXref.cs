using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class DcardChargeBackXref
    {
        public int DcardChargeBackXrefKey { get; set; }
        public int RefundTransDetailKey { get; set; }
        public int RefundedTransDetailKey { get; set; }
        public decimal ChargeBackAmount { get; set; }

        public virtual TransDetail RefundTransDetailKeyNavigation { get; set; }
        public virtual TransDetail RefundedTransDetailKeyNavigation { get; set; }
    }
}
