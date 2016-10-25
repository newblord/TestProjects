using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class BanksParent
    {
        public BanksParent()
        {
            Banks = new HashSet<Banks>();
        }

        public int BanksParentKey { get; set; }
        public string BanksParentName { get; set; }
        public int AchBankKey { get; set; }
        public bool AllowsMiddayProcessing { get; set; }
        public int CreditAchBankKey { get; set; }
        public int DebitAchBankKey { get; set; }

        public virtual ICollection<Banks> Banks { get; set; }
        public virtual Achbank AchBankKeyNavigation { get; set; }
    }
}
