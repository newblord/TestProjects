using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class PurchaseService
    {
        public int PurchaseServiceKey { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }
        public short Location { get; set; }
        public int? GlAcct { get; set; }
        public byte PaymentFrom { get; set; }
        public decimal TotCost { get; set; }
        public int TransDetailKey { get; set; }
        public string OptplusCardFirst { get; set; }
        public string OptplusCardLast { get; set; }
        public bool Reversed { get; set; }
        public DateTime? ReversedDate { get; set; }

        public virtual Tellerid TellerNavigation { get; set; }
        public virtual TransDetail TransDetailKeyNavigation { get; set; }
    }
}
