using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class ExchangeRate
    {
        public int ExchangeRateKey { get; set; }
        public string CurrencyBaseCode { get; set; }
        public string CurrencyCode { get; set; }
        public string CurrencyName { get; set; }
        public decimal CurrencyRate { get; set; }
        public decimal CurrencyInverseRate { get; set; }
        public DateTime UtcTimeStamp { get; set; }
        public short AccessesRemaining { get; set; }
        public short AccessesSoFar { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
