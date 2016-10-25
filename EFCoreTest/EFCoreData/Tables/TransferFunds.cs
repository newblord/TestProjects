using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class TransferFunds
    {
        public int TransferFundsKey { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }
        public short Location { get; set; }
        public string FundsFrom { get; set; }
        public string FundsTo { get; set; }
        public int GlAcct { get; set; }
        public decimal TotAmount { get; set; }
        public string Description { get; set; }
        public int TransDetailKey { get; set; }
        public int CurrencyKey { get; set; }

        public virtual Glacct GlAcctNavigation { get; set; }
        public virtual Tellerid TellerNavigation { get; set; }
        public virtual TransDetail TransDetailKeyNavigation { get; set; }
    }
}
