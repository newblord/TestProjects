using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CurrencyExchangeConfig
    {
        public int CurrencyExchangeConfigKey { get; set; }
        public int CurrencyKey { get; set; }
        public short Location { get; set; }
        public bool ManualFeeOverride { get; set; }
        public decimal MinExchangeFee { get; set; }
        public decimal MaxExchangeFee { get; set; }
        public DateTime? DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public decimal ExchangeFee { get; set; }
        public bool ExchangeRateOverride { get; set; }
        public decimal MaxExchangeRate { get; set; }
        public decimal MinExchangeRate { get; set; }
        public bool DualAuthorization { get; set; }
        public bool GovtIdRequired { get; set; }
        public decimal BuyExchangeRatePercent { get; set; }
        public decimal SellExchangeRatePercent { get; set; }

        public virtual Currency CurrencyKeyNavigation { get; set; }
        public virtual Company LocationNavigation { get; set; }
    }
}
