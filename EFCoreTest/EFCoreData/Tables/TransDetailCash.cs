using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class TransDetailCash
    {
        public TransDetailCash()
        {
            TransDetailCashParsedCash = new HashSet<TransDetailCashParsedCash>();
        }

        public int TransDetailCashKey { get; set; }
        public int TransDetailKey { get; set; }
        public string CashFrom { get; set; }
        public string CashTo { get; set; }
        public decimal CashAmt { get; set; }
        public decimal CcardAmt { get; set; }
        public int? ParseCashKey { get; set; }
        public int? DrawerKey { get; set; }
        public int CurrencyKey { get; set; }

        public virtual ICollection<TransDetailCashParsedCash> TransDetailCashParsedCash { get; set; }
        public virtual Currency CurrencyKeyNavigation { get; set; }
        public virtual ParseCash ParseCashKeyNavigation { get; set; }
        public virtual TransDetail TransDetailKeyNavigation { get; set; }
    }
}
