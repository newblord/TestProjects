using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class Achbank
    {
        public Achbank()
        {
            BanksParent = new HashSet<BanksParent>();
            CompanyAchbankCreditAchBankKeyNavigation = new HashSet<CompanyAchbank>();
            CompanyAchbankDebitAchBankKeyNavigation = new HashSet<CompanyAchbank>();
        }

        public int AchBankKey { get; set; }
        public string Name { get; set; }
        public bool IsInternet { get; set; }
        public bool IsAdastra { get; set; }
        public string DebitOrCredit { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<BanksParent> BanksParent { get; set; }
        public virtual ICollection<CompanyAchbank> CompanyAchbankCreditAchBankKeyNavigation { get; set; }
        public virtual ICollection<CompanyAchbank> CompanyAchbankDebitAchBankKeyNavigation { get; set; }
    }
}
