using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class VaultMasterParsedCash
    {
        public int VaultMasterParsedCashKey { get; set; }
        public int VaultKey { get; set; }
        public int DenominationKey { get; set; }
        public decimal Amount { get; set; }

        public virtual Denomination DenominationKeyNavigation { get; set; }
        public virtual VaultMaster VaultKeyNavigation { get; set; }
    }
}
