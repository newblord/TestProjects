using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class Currency
    {
        public Currency()
        {
            Company = new HashSet<Company>();
            Country = new HashSet<Country>();
            CurrencyExchangeConfig = new HashSet<CurrencyExchangeConfig>();
            Denomination = new HashSet<Denomination>();
            DrawerZcash = new HashSet<DrawerZcash>();
            TransDetailCash = new HashSet<TransDetailCash>();
        }

        public int CurrencyKey { get; set; }
        public string CurrencyCode { get; set; }
        public string Description { get; set; }
        public string CurrencySymbol { get; set; }
        public string BillDisplay { get; set; }
        public string GroupedCoinDisplay { get; set; }
        public bool IsEnabled { get; set; }
        public int Acct { get; set; }
        public int CashTransitAcct { get; set; }
        public int OperatingAcct { get; set; }

        public virtual ICollection<Company> Company { get; set; }
        public virtual ICollection<Country> Country { get; set; }
        public virtual ICollection<CurrencyExchangeConfig> CurrencyExchangeConfig { get; set; }
        public virtual ICollection<Denomination> Denomination { get; set; }
        public virtual ICollection<DrawerZcash> DrawerZcash { get; set; }
        public virtual ICollection<TransDetailCash> TransDetailCash { get; set; }
        public virtual Glacct AcctNavigation { get; set; }
        public virtual Glacct CashTransitAcctNavigation { get; set; }
        public virtual Glacct OperatingAcctNavigation { get; set; }
    }
}
