using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class OptPlusRdfauthorizedTransactions
    {
        public string UniqueProgramId { get; set; }
        public string GalileoAccountId { get; set; }
        public string CardId { get; set; }
        public string TransactionDate { get; set; }
        public string TransactionCurrencyCode { get; set; }
        public string AddressVerificationResponse { get; set; }
        public string AuthorizationResponse { get; set; }
        public string AuthorizationAmount { get; set; }
        public string AuthorizationAmountSign { get; set; }
        public string AuthorizationCode { get; set; }
        public string NetworkCode { get; set; }
        public string MerchantNumber { get; set; }
        public string MerchantName { get; set; }
        public string MerchantCategoryCode { get; set; }
        public string TransactionCode { get; set; }
        public string MerchantCountryCode { get; set; }
        public int? CustomerKey { get; set; }
        public DateTime? DateUpdated { get; set; }
        public int AuthorizedTransactionsKey { get; set; }

        public virtual Customer CustomerKeyNavigation { get; set; }
    }
}
