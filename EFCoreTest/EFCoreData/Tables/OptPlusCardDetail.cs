using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class OptPlusCardDetail
    {
        public OptPlusCardDetail()
        {
            FormLetterOnDemand = new HashSet<FormLetterOnDemand>();
            FormLetterPrinted = new HashSet<FormLetterPrinted>();
            OptPlusCardRipayment = new HashSet<OptPlusCardRipayment>();
            Risrept = new HashSet<Risrept>();
            WebCallQueue = new HashSet<WebCallQueue>();
            WebCallWorkQueue = new HashSet<WebCallWorkQueue>();
        }

        public int OptplusCardDetailKey { get; set; }
        public int CreditCardKey { get; set; }
        public int OptplusProductKey { get; set; }
        public bool OverdraftOptedIn { get; set; }
        public decimal OverdraftAmount { get; set; }
        public bool IsEligibleColl { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }
        public int? IssuerKey { get; set; }
        public int? OtherCreditcardKey { get; set; }
        public string CardId { get; set; }
        public bool? IsDeactivated { get; set; }
        public int? OptplusPreviousProductKey { get; set; }
        public decimal? PendingCollAchAmt { get; set; }
        public DateTime? PendingCollAchSent { get; set; }
        public int? PersonId { get; set; }
        public string PanProxyNum { get; set; }
        public int? ParentOptPlusCardDetailKey { get; set; }
        public bool IsEmbossed { get; set; }
        public DateTime? ProductFlipDate { get; set; }
        public string BankAccessNumber { get; set; }

        public virtual ICollection<FormLetterOnDemand> FormLetterOnDemand { get; set; }
        public virtual ICollection<FormLetterPrinted> FormLetterPrinted { get; set; }
        public virtual ICollection<OptPlusCardRipayment> OptPlusCardRipayment { get; set; }
        public virtual ICollection<Risrept> Risrept { get; set; }
        public virtual ICollection<WebCallQueue> WebCallQueue { get; set; }
        public virtual ICollection<WebCallWorkQueue> WebCallWorkQueue { get; set; }
        public virtual CreditCards CreditCardKeyNavigation { get; set; }
        public virtual Issuer IssuerKeyNavigation { get; set; }
        public virtual OptPlusProduct OptplusProductKeyNavigation { get; set; }
        public virtual CreditCards OtherCreditcardKeyNavigation { get; set; }
        public virtual OptPlusCardDetail ParentOptPlusCardDetailKeyNavigation { get; set; }
        public virtual ICollection<OptPlusCardDetail> InverseParentOptPlusCardDetailKeyNavigation { get; set; }
    }
}
