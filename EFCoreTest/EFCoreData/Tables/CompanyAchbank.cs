using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CompanyAchbank
    {
        public int CompanyAchbankKey { get; set; }
        public short Location { get; set; }
        public int? CreditAchBankKey { get; set; }
        public int? DebitAchBankKey { get; set; }

        public virtual Achbank CreditAchBankKeyNavigation { get; set; }
        public virtual Achbank DebitAchBankKeyNavigation { get; set; }
    }
}
