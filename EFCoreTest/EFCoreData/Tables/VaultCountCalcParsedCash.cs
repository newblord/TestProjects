using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class VaultCountCalcParsedCash
    {
        public int VaultCountCalcParsedCashKey { get; set; }
        public int VaultCountKey { get; set; }
        public int DenominationKey { get; set; }
        public decimal Amount { get; set; }

        public virtual Denomination DenominationKeyNavigation { get; set; }
        public virtual VaultCount VaultCountKeyNavigation { get; set; }
    }
}
