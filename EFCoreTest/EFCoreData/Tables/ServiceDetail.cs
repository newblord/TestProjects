using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class ServiceDetail
    {
        public ServiceDetail()
        {
            DrawerService = new HashSet<DrawerService>();
            DrawerXservice = new HashSet<DrawerXservice>();
            DrawerZservice = new HashSet<DrawerZservice>();
            GiftCard = new HashSet<GiftCard>();
            LoanService = new HashSet<LoanService>();
            OverShort = new HashSet<OverShort>();
            ServiceTrans = new HashSet<ServiceTrans>();
            TransDetailService = new HashSet<TransDetailService>();
            VaultCountService = new HashSet<VaultCountService>();
            VaultService = new HashSet<VaultService>();
        }

        public int ServiceDetailKey { get; set; }
        public int ServiceMasterKey { get; set; }
        public short Location { get; set; }
        public bool Enabled { get; set; }
        public decimal ServiceCost { get; set; }
        public decimal ServiceFee { get; set; }
        public decimal MaxCharge { get; set; }
        public int? GlAcctFee { get; set; }
        public int? GlAcctAmt { get; set; }
        public int? GlAcctCost { get; set; }
        public int? GlAcctProfit { get; set; }
        public DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? LastUpdated { get; set; }
        public string UpdatedBy { get; set; }
        public decimal MinCharge { get; set; }
        public bool GovtIdRequired { get; set; }

        public virtual ICollection<DrawerService> DrawerService { get; set; }
        public virtual ICollection<DrawerXservice> DrawerXservice { get; set; }
        public virtual ICollection<DrawerZservice> DrawerZservice { get; set; }
        public virtual ICollection<GiftCard> GiftCard { get; set; }
        public virtual ICollection<LoanService> LoanService { get; set; }
        public virtual ICollection<OverShort> OverShort { get; set; }
        public virtual ICollection<ServiceTrans> ServiceTrans { get; set; }
        public virtual ICollection<TransDetailService> TransDetailService { get; set; }
        public virtual ICollection<VaultCountService> VaultCountService { get; set; }
        public virtual ICollection<VaultService> VaultService { get; set; }
        public virtual ServiceMaster ServiceMasterKeyNavigation { get; set; }
    }
}
