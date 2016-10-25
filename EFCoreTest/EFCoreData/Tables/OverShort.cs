using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class OverShort
    {
        public int OsKey { get; set; }
        public int TransDetailKey { get; set; }
        public DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public short Location { get; set; }
        public int? DrawerzKey { get; set; }
        public int? VaultCountKey { get; set; }
        public int? ServiceDetailKey { get; set; }
        public decimal CalcAmt { get; set; }
        public decimal EnteredAmt { get; set; }
        public int? CalcQty { get; set; }
        public int? EnteredQty { get; set; }
        public decimal? AmtOver { get; set; }
        public decimal? AmtShort { get; set; }
        public int? CurrencyKey { get; set; }
        public int? QtyOver { get; set; }
        public int? QtyShort { get; set; }

        public virtual DrawerZ DrawerzKeyNavigation { get; set; }
        public virtual ServiceDetail ServiceDetailKeyNavigation { get; set; }
        public virtual TransDetail TransDetailKeyNavigation { get; set; }
        public virtual VaultCount VaultCountKeyNavigation { get; set; }
    }
}
