using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class DrawerZcash
    {
        public int DrawerzCashKey { get; set; }
        public int DrawerzKey { get; set; }
        public int CurrencyKey { get; set; }
        public decimal EnteredAmount { get; set; }
        public decimal CalculatedAmount { get; set; }

        public virtual Currency CurrencyKeyNavigation { get; set; }
        public virtual DrawerZ DrawerzKeyNavigation { get; set; }
    }
}
