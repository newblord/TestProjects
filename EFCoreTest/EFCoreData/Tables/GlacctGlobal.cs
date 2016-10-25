using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class GlacctGlobal
    {
        public int GlAcctGlobalKey { get; set; }
        public int? CashInStoreAcct { get; set; }
        public int? DepositBagsAcct { get; set; }
        public int? GoldInvestmentAcct { get; set; }
        public int? GoldTransitAcct { get; set; }
        public int? GoldRevenueAcct { get; set; }
        public int? GoldProcessFeeAcct { get; set; }
        public int? GoldFeesPaidAcct { get; set; }
        public int? GoldLossesAcct { get; set; }
        public int? CurrencyExchangeOnCheckAcct { get; set; }
        public int? CurrencyExchangeFeeAcct { get; set; }
        public int? CurrencyExchangeGainlossAcct { get; set; }
        public int? OverShortAcct { get; set; }
        public int? CheckRiAcct { get; set; }
        public int? CheckCollAcct { get; set; }
        public int? CourtesyPayoutAcct { get; set; }
        public int? OptplusReturnsAcct { get; set; }
        public int? OptplusCollAcct { get; set; }
        public int? AdastraCommissionsArAcct { get; set; }
        public int? AdastraCommissionsApAcct { get; set; }
        public int? AdastraCommissionsFeesAcct { get; set; }
        public int? AdastraCommissionsExpenseAcct { get; set; }
        public int? AdastraCentralTrustAcct { get; set; }
        public int? AdastraTrustProceedsApAcct { get; set; }
        public int? AdastraCollectionAgencyReceivableAcct { get; set; }
        public int? AdastraCashAndChecksAcct { get; set; }
        public int? AdastraBadDebtCheckAcct { get; set; }
        public int? CashedCheckDiscountAcct { get; set; }
        public int? CashedCheckFlatFeesAcct { get; set; }
        public int? CashedCheckPctFeesAcct { get; set; }
        public int? CashedCheckPostDatedAcct { get; set; }
        public int? CcardFeeAcct { get; set; }
        public int? SalesTaxAcct { get; set; }
        public int? SpayInternetRevenueAcct { get; set; }
        public int? MpayInternetRevenueAcct { get; set; }
        public int? OendInternetRevenueAcct { get; set; }
        public int? SpayInternetReturnsAcct { get; set; }
        public int? MpayInternetReturnsAcct { get; set; }
        public int? OendInternetReturnsAcct { get; set; }
        public int? SpayInternetCollectionsAcct { get; set; }
        public int? MpayInternetCollectionsAcct { get; set; }
        public int? OendInternetCollectionsAcct { get; set; }
        public int? SpayInternetCreditClearingAcct { get; set; }
        public int? MpayInternetCreditClearingAcct { get; set; }
        public int? OendInternetCreditClearingAcct { get; set; }
        public int? InternalShortAcct { get; set; }

        public virtual Glacct AdastraBadDebtCheckAcctNavigation { get; set; }
        public virtual Glacct AdastraCashAndChecksAcctNavigation { get; set; }
        public virtual Glacct AdastraCentralTrustAcctNavigation { get; set; }
        public virtual Glacct AdastraCollectionAgencyReceivableAcctNavigation { get; set; }
        public virtual Glacct AdastraCommissionsApAcctNavigation { get; set; }
        public virtual Glacct AdastraCommissionsArAcctNavigation { get; set; }
        public virtual Glacct AdastraCommissionsExpenseAcctNavigation { get; set; }
        public virtual Glacct AdastraCommissionsFeesAcctNavigation { get; set; }
        public virtual Glacct AdastraTrustProceedsApAcctNavigation { get; set; }
        public virtual Glacct CashInStoreAcctNavigation { get; set; }
        public virtual Glacct CashedCheckDiscountAcctNavigation { get; set; }
        public virtual Glacct CashedCheckFlatFeesAcctNavigation { get; set; }
        public virtual Glacct CashedCheckPctFeesAcctNavigation { get; set; }
        public virtual Glacct CashedCheckPostDatedAcctNavigation { get; set; }
        public virtual Glacct CcardFeeAcctNavigation { get; set; }
        public virtual Glacct CheckCollAcctNavigation { get; set; }
        public virtual Glacct CheckRiAcctNavigation { get; set; }
        public virtual Glacct CourtesyPayoutAcctNavigation { get; set; }
        public virtual Glacct CurrencyExchangeFeeAcctNavigation { get; set; }
        public virtual Glacct CurrencyExchangeGainlossAcctNavigation { get; set; }
        public virtual Glacct CurrencyExchangeOnCheckAcctNavigation { get; set; }
        public virtual Glacct DepositBagsAcctNavigation { get; set; }
        public virtual Glacct GoldFeesPaidAcctNavigation { get; set; }
        public virtual Glacct GoldInvestmentAcctNavigation { get; set; }
        public virtual Glacct GoldLossesAcctNavigation { get; set; }
        public virtual Glacct GoldProcessFeeAcctNavigation { get; set; }
        public virtual Glacct GoldRevenueAcctNavigation { get; set; }
        public virtual Glacct GoldTransitAcctNavigation { get; set; }
        public virtual Glacct InternalShortAcctNavigation { get; set; }
        public virtual Glacct MpayInternetCollectionsAcctNavigation { get; set; }
        public virtual Glacct MpayInternetCreditClearingAcctNavigation { get; set; }
        public virtual Glacct MpayInternetReturnsAcctNavigation { get; set; }
        public virtual Glacct MpayInternetRevenueAcctNavigation { get; set; }
        public virtual Glacct OendInternetCollectionsAcctNavigation { get; set; }
        public virtual Glacct OendInternetCreditClearingAcctNavigation { get; set; }
        public virtual Glacct OendInternetReturnsAcctNavigation { get; set; }
        public virtual Glacct OendInternetRevenueAcctNavigation { get; set; }
        public virtual Glacct OptplusCollAcctNavigation { get; set; }
        public virtual Glacct OptplusReturnsAcctNavigation { get; set; }
        public virtual Glacct OverShortAcctNavigation { get; set; }
        public virtual Glacct SalesTaxAcctNavigation { get; set; }
        public virtual Glacct SpayInternetCollectionsAcctNavigation { get; set; }
        public virtual Glacct SpayInternetCreditClearingAcctNavigation { get; set; }
        public virtual Glacct SpayInternetReturnsAcctNavigation { get; set; }
        public virtual Glacct SpayInternetRevenueAcctNavigation { get; set; }
    }
}
