using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class ExchangeRateDaily
    {
        public int ExchangeRateDailyKey { get; set; }
        public DateTime ExchangeRateDate { get; set; }
        public string CurrencyCode { get; set; }
        public string BaseCurrencyCode { get; set; }
        public decimal Rate { get; set; }
    }
}
