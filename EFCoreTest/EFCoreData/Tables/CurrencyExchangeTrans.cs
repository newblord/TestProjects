using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CurrencyExchangeTrans
    {
        public int CurrencyExchangeTransKey { get; set; }
        public int TransDetailKey { get; set; }
        public int TransPosKey { get; set; }
        public short Location { get; set; }
        public string Teller { get; set; }
        public int? CustomerKey { get; set; }
        public string FromCurrencyCode { get; set; }
        public decimal FromCurrencyRate { get; set; }
        public string ToCurrencyCode { get; set; }
        public decimal ToCurrencyRate { get; set; }
        public string BaseCurrencyCode { get; set; }
        public decimal BaseCurrencyRate { get; set; }
        public decimal? ConversionRate { get; set; }
        public decimal AmountReceived { get; set; }
        public decimal Fee { get; set; }
        public decimal ExchangeAmount { get; set; }
        public decimal AmountDue { get; set; }
        public decimal ChangeDue { get; set; }
        public decimal PayBill { get; set; }
        public decimal PayChange { get; set; }
        public DateTime DateEntered { get; set; }
        public decimal? CalculatedConversionRate { get; set; }
        public decimal? FeeInBase { get; set; }
        public decimal? ExchangeRatePercent { get; set; }
        public decimal? XeConversionRate { get; set; }
        public bool Reversed { get; set; }
        public decimal? GainLoss { get; set; }

        public virtual Company LocationNavigation { get; set; }
        public virtual TransDetail TransDetailKeyNavigation { get; set; }
        public virtual TransPos TransPosKeyNavigation { get; set; }
    }
}
