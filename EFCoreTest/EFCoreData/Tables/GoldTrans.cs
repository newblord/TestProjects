using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class GoldTrans
    {
        public GoldTrans()
        {
            GoldTransCustomer = new HashSet<GoldTransCustomer>();
            GoldTransDetail = new HashSet<GoldTransDetail>();
        }

        public int GoldTransKey { get; set; }
        public int CustomerKey { get; set; }
        public short Location { get; set; }
        public string Teller { get; set; }
        public int DrawerKey { get; set; }
        public DateTime DateEntered { get; set; }
        public int TransDetailKey { get; set; }
        public int TransPosKey { get; set; }
        public byte TotalStones { get; set; }
        public byte TotalDiamonds { get; set; }
        public decimal TotalGoldWeight { get; set; }
        public decimal TotalOfferAmt { get; set; }
        public decimal TotalAcceptedAmt { get; set; }
        public decimal OfferGoldAmt { get; set; }
        public decimal OfferDiamondAmt { get; set; }
        public string ModOverride { get; set; }
        public decimal GoldPrice { get; set; }
        public int BagNum { get; set; }
        public int LocationTransNum { get; set; }
        public DateTime MaturityDate { get; set; }
        public bool Reversed { get; set; }
        public int ReversedTransDetailKey { get; set; }
        public decimal TotalBaseModOffer { get; set; }
        public decimal TotalMidModOffer { get; set; }
        public decimal TotalHighModOffer { get; set; }
        public decimal TotalOverrideModOffer { get; set; }
        public decimal TotalTellerOffer { get; set; }
        public byte AcceptedOfferLevel { get; set; }
        public decimal GoldWeight10k { get; set; }
        public decimal GoldWeight14k { get; set; }
        public decimal GoldWeight18k { get; set; }
        public decimal GoldWeight22k { get; set; }
        public decimal GoldWeight24k { get; set; }
        public decimal TransHandlingFee { get; set; }
        public decimal GoldLoss10k { get; set; }
        public decimal GoldLoss14k { get; set; }
        public decimal GoldLoss18k { get; set; }
        public decimal GoldLoss22k { get; set; }
        public decimal GoldLoss24k { get; set; }
        public decimal GoldPrice10k { get; set; }
        public decimal GoldPrice14k { get; set; }
        public decimal GoldPrice18k { get; set; }
        public decimal GoldPrice22k { get; set; }
        public decimal GoldPrice24k { get; set; }
        public byte OfferLevelCode { get; set; }
        public decimal PlatinumWeight { get; set; }
        public decimal PlatinumLoss { get; set; }
        public decimal PlatinumPrice { get; set; }
        public decimal GoldWeight09k { get; set; }
        public decimal GoldLoss09k { get; set; }
        public decimal GoldPrice09k { get; set; }

        public virtual ICollection<GoldTransCustomer> GoldTransCustomer { get; set; }
        public virtual ICollection<GoldTransDetail> GoldTransDetail { get; set; }
        public virtual Company LocationNavigation { get; set; }
    }
}
