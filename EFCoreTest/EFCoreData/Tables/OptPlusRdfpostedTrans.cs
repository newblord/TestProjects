using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class OptPlusRdfpostedTrans
    {
        public string ProgramId { get; set; }
        public string AccountId { get; set; }
        public string CardId { get; set; }
        public string TransDate { get; set; }
        public string TransCode { get; set; }
        public decimal? TransAmt { get; set; }
        public string TransSign { get; set; }
        public string CurrencyCode { get; set; }
        public string AuthCode { get; set; }
        public string PostDate { get; set; }
        public string NetworkCode { get; set; }
        public string MerchantNum { get; set; }
        public string MerchantName { get; set; }
        public string MerchantCategory { get; set; }
        public string MerchantCountry { get; set; }
        public decimal? InterFeeAmt { get; set; }
        public string ExtTransId { get; set; }
        public string UserData1 { get; set; }
        public string UserData2 { get; set; }
        public int? CustomerKey { get; set; }
        public int? OptplusMerchantKey { get; set; }
        public int PostedTransKey { get; set; }
        public DateTime? DateUpdated { get; set; }

        public virtual Customer CustomerKeyNavigation { get; set; }
        public virtual OptPlusMerchant OptplusMerchantKeyNavigation { get; set; }
    }
}
