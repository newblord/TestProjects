using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class GoldConfig
    {
        public GoldConfig()
        {
            GoldConfigItem = new HashSet<GoldConfigItem>();
        }

        public short GoldConfigKey { get; set; }
        public short Location { get; set; }
        public bool EnableGold { get; set; }
        public bool EnableDiamond { get; set; }
        public bool EnableReceiptDetails { get; set; }
        public bool EnableAdditionalForms { get; set; }
        public byte MaturityLengthDays { get; set; }
        public decimal MinDiamondSize { get; set; }
        public decimal MaxDiamondSize { get; set; }
        public byte MaxDiamondsPerTrans { get; set; }
        public byte MaxDiamondsPerItem { get; set; }
        public decimal DiamondOfferMax { get; set; }
        public byte GoldTellerPct { get; set; }
        public byte GoldModBasePct { get; set; }
        public byte GoldModMidPct { get; set; }
        public byte GoldModHighPct { get; set; }
        public byte GoldModOverridePct { get; set; }
        public decimal Gold10kLossPct { get; set; }
        public decimal Gold14kLossPct { get; set; }
        public decimal Gold18kLossPct { get; set; }
        public decimal Gold22kLossPct { get; set; }
        public decimal Gold24kLossPct { get; set; }
        public decimal RequireAuthTransAmt { get; set; }
        public bool RequireItemSize { get; set; }
        public bool RequireGender { get; set; }
        public bool RequireHeight { get; set; }
        public bool RequireWeight { get; set; }
        public bool RequireRace { get; set; }
        public bool RequireEyeColor { get; set; }
        public bool RequireHairColor { get; set; }
        public bool RequireMinAge { get; set; }
        public byte RequireAgeValue { get; set; }
        public bool RequireHomePhone { get; set; }
        public bool RequireEmployerName { get; set; }
        public bool RequirePlateNumber { get; set; }
        public bool RequirePlateState { get; set; }
        public decimal TransFeeAmt { get; set; }
        public bool EnableSpanishDocs { get; set; }
        public bool RequireMidName { get; set; }
        public decimal PlatinumLossPct { get; set; }
        public bool EnableQuickQuote { get; set; }
        public string PoliceStoreId { get; set; }
        public decimal Gold09kLossPct { get; set; }
        public bool GovtIdRequired { get; set; }
        public string CompanyName { get; set; }

        public virtual ICollection<GoldConfigItem> GoldConfigItem { get; set; }
        public virtual Company LocationNavigation { get; set; }
    }
}
