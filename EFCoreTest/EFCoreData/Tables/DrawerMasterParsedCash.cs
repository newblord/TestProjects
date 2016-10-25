using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class DrawerMasterParsedCash
    {
        public int DrawerMasterParsedCashKey { get; set; }
        public int DrawerKey { get; set; }
        public int DenominationKey { get; set; }
        public decimal Amount { get; set; }

        public virtual Denomination DenominationKeyNavigation { get; set; }
        public virtual DrawerMaster DrawerKeyNavigation { get; set; }
    }
}
