using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class Denomination
    {
        public Denomination()
        {
            DrawerMasterParsedCash = new HashSet<DrawerMasterParsedCash>();
            TransDetailCashParsedCash = new HashSet<TransDetailCashParsedCash>();
            VaultCountCalcParsedCash = new HashSet<VaultCountCalcParsedCash>();
            VaultCountEnteredParsedCash = new HashSet<VaultCountEnteredParsedCash>();
            VaultMasterParsedCash = new HashSet<VaultMasterParsedCash>();
        }

        public int DenominationKey { get; set; }
        public int CurrencyKey { get; set; }
        public short DisplaySequence { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public string DenominationType { get; set; }
        public int? BaseDenominationKey { get; set; }
        public bool IsEnabled { get; set; }

        public virtual ICollection<DrawerMasterParsedCash> DrawerMasterParsedCash { get; set; }
        public virtual ICollection<TransDetailCashParsedCash> TransDetailCashParsedCash { get; set; }
        public virtual ICollection<VaultCountCalcParsedCash> VaultCountCalcParsedCash { get; set; }
        public virtual ICollection<VaultCountEnteredParsedCash> VaultCountEnteredParsedCash { get; set; }
        public virtual ICollection<VaultMasterParsedCash> VaultMasterParsedCash { get; set; }
        public virtual Denomination BaseDenominationKeyNavigation { get; set; }
        public virtual ICollection<Denomination> InverseBaseDenominationKeyNavigation { get; set; }
        public virtual Currency CurrencyKeyNavigation { get; set; }
    }
}
