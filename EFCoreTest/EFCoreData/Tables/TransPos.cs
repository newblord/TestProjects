using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class TransPos
    {
        public TransPos()
        {
            CurrencyExchangeTrans = new HashSet<CurrencyExchangeTrans>();
            TransDetail = new HashSet<TransDetail>();
            VaultMgrAuthorizationDetail = new HashSet<VaultMgrAuthorizationDetail>();
        }

        public int TransPosKey { get; set; }
        public int? CustomerKey { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }
        public short Location { get; set; }
        public decimal CashRecv { get; set; }
        public decimal CashPaid { get; set; }
        public decimal CcardRecv { get; set; }
        public decimal CcardPaid { get; set; }

        public virtual ICollection<CurrencyExchangeTrans> CurrencyExchangeTrans { get; set; }
        public virtual ICollection<TransDetail> TransDetail { get; set; }
        public virtual ICollection<VaultMgrAuthorizationDetail> VaultMgrAuthorizationDetail { get; set; }
        public virtual Customer CustomerKeyNavigation { get; set; }
        public virtual Tellerid TellerNavigation { get; set; }
    }
}
