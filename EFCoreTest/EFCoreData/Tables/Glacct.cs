using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class Glacct
    {
        public Glacct()
        {
            BalSheetColumns2 = new HashSet<BalSheetColumns2>();
            CheckReturn = new HashSet<CheckReturn>();
            CompanyInterCoNoncashApAcctNavigation = new HashSet<Company>();
            CompanyInterCoNoncashArAcctNavigation = new HashSet<Company>();
            CompanyInterCoTitleApAcctNavigation = new HashSet<Company>();
            CompanyInterCoTitleArAcctNavigation = new HashSet<Company>();
            CompanyInterStoreApAcctNavigation = new HashSet<Company>();
            CompanyInterStoreArAcctNavigation = new HashSet<Company>();
            CurrencyAcctNavigation = new HashSet<Currency>();
            CurrencyCashTransitAcctNavigation = new HashSet<Currency>();
            CurrencyOperatingAcctNavigation = new HashSet<Currency>();
            DiscountMaster = new HashSet<DiscountMaster>();
            GlacctGlobalAdastraBadDebtCheckAcctNavigation = new HashSet<GlacctGlobal>();
            GlacctGlobalAdastraCashAndChecksAcctNavigation = new HashSet<GlacctGlobal>();
            GlacctGlobalAdastraCentralTrustAcctNavigation = new HashSet<GlacctGlobal>();
            GlacctGlobalAdastraCollectionAgencyReceivableAcctNavigation = new HashSet<GlacctGlobal>();
            GlacctGlobalAdastraCommissionsApAcctNavigation = new HashSet<GlacctGlobal>();
            GlacctGlobalAdastraCommissionsArAcctNavigation = new HashSet<GlacctGlobal>();
            GlacctGlobalAdastraCommissionsExpenseAcctNavigation = new HashSet<GlacctGlobal>();
            GlacctGlobalAdastraCommissionsFeesAcctNavigation = new HashSet<GlacctGlobal>();
            GlacctGlobalAdastraTrustProceedsApAcctNavigation = new HashSet<GlacctGlobal>();
            GlacctGlobalCashInStoreAcctNavigation = new HashSet<GlacctGlobal>();
            GlacctGlobalCashedCheckDiscountAcctNavigation = new HashSet<GlacctGlobal>();
            GlacctGlobalCashedCheckFlatFeesAcctNavigation = new HashSet<GlacctGlobal>();
            GlacctGlobalCashedCheckPctFeesAcctNavigation = new HashSet<GlacctGlobal>();
            GlacctGlobalCashedCheckPostDatedAcctNavigation = new HashSet<GlacctGlobal>();
            GlacctGlobalCcardFeeAcctNavigation = new HashSet<GlacctGlobal>();
            GlacctGlobalCheckCollAcctNavigation = new HashSet<GlacctGlobal>();
            GlacctGlobalCheckRiAcctNavigation = new HashSet<GlacctGlobal>();
            GlacctGlobalCourtesyPayoutAcctNavigation = new HashSet<GlacctGlobal>();
            GlacctGlobalCurrencyExchangeFeeAcctNavigation = new HashSet<GlacctGlobal>();
            GlacctGlobalCurrencyExchangeGainlossAcctNavigation = new HashSet<GlacctGlobal>();
            GlacctGlobalCurrencyExchangeOnCheckAcctNavigation = new HashSet<GlacctGlobal>();
            GlacctGlobalDepositBagsAcctNavigation = new HashSet<GlacctGlobal>();
            GlacctGlobalGoldFeesPaidAcctNavigation = new HashSet<GlacctGlobal>();
            GlacctGlobalGoldInvestmentAcctNavigation = new HashSet<GlacctGlobal>();
            GlacctGlobalGoldLossesAcctNavigation = new HashSet<GlacctGlobal>();
            GlacctGlobalGoldProcessFeeAcctNavigation = new HashSet<GlacctGlobal>();
            GlacctGlobalGoldRevenueAcctNavigation = new HashSet<GlacctGlobal>();
            GlacctGlobalGoldTransitAcctNavigation = new HashSet<GlacctGlobal>();
            GlacctGlobalInternalShortAcctNavigation = new HashSet<GlacctGlobal>();
            GlacctGlobalMpayInternetCollectionsAcctNavigation = new HashSet<GlacctGlobal>();
            GlacctGlobalMpayInternetCreditClearingAcctNavigation = new HashSet<GlacctGlobal>();
            GlacctGlobalMpayInternetReturnsAcctNavigation = new HashSet<GlacctGlobal>();
            GlacctGlobalMpayInternetRevenueAcctNavigation = new HashSet<GlacctGlobal>();
            GlacctGlobalOendInternetCollectionsAcctNavigation = new HashSet<GlacctGlobal>();
            GlacctGlobalOendInternetCreditClearingAcctNavigation = new HashSet<GlacctGlobal>();
            GlacctGlobalOendInternetReturnsAcctNavigation = new HashSet<GlacctGlobal>();
            GlacctGlobalOendInternetRevenueAcctNavigation = new HashSet<GlacctGlobal>();
            GlacctGlobalOptplusCollAcctNavigation = new HashSet<GlacctGlobal>();
            GlacctGlobalOptplusReturnsAcctNavigation = new HashSet<GlacctGlobal>();
            GlacctGlobalOverShortAcctNavigation = new HashSet<GlacctGlobal>();
            GlacctGlobalSalesTaxAcctNavigation = new HashSet<GlacctGlobal>();
            GlacctGlobalSpayInternetCollectionsAcctNavigation = new HashSet<GlacctGlobal>();
            GlacctGlobalSpayInternetCreditClearingAcctNavigation = new HashSet<GlacctGlobal>();
            GlacctGlobalSpayInternetReturnsAcctNavigation = new HashSet<GlacctGlobal>();
            GlacctGlobalSpayInternetRevenueAcctNavigation = new HashSet<GlacctGlobal>();
            GlacctGroupAchCollAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupAchSuspenseAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupCashedCheckCanUsdAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupCcardCollAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupCcardSuspenseAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupChecksPrimaryBankAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupLoansPrimaryBankAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupMpayBlAdastraBadDebtAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupMpayBlCabCollAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupMpayBlCabCollectedAccruedInterestAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupMpayBlCabDefAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupMpayBlCabDueToLenderSuspenseAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupMpayBlCabLenderInterestAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupMpayBlCabLenderRiFeeAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupMpayBlCabUncollectedAccruedInterestAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupMpayBlCollAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupMpayBlDecreaseAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupMpayBlDueDatePaymentQueueSuspenseAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupMpayBlFasterPaymentsFeeAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupMpayBlFeesAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupMpayBlFundingSuspenseAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupMpayBlInsuranceApAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupMpayBlInsuranceCogsAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupMpayBlInsuranceRevenueAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupMpayBlInsuranceTaxAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupMpayBlInterestAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupMpayBlInventoryAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupMpayBlLegalFeesAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupMpayBlNsfFeeAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupMpayBlRiAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupMpayBlTaxPrepInvAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupMpayBlTaxPrepRevAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupMpaySigAdastraBadDebtAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupMpaySigCabCollAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupMpaySigCabCollectedAccruedInterestAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupMpaySigCabDefAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupMpaySigCabDueToLenderSuspenseAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupMpaySigCabUncollectedAccruedInterestAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupMpaySigCollAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupMpaySigDecreaseAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupMpaySigDefAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupMpaySigFasterPaymentsFeeAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupMpaySigFeesAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupMpaySigInterestAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupMpaySigInventoryAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupMpaySigLegalFeesAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupMpaySigNsfFeeAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupMpaySigTaxAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupMpaySigTransAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupMpayTitle2ndCollAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupMpayTitle2ndDefAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupMpayTitle2ndFasterPaymentsFeeAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupMpayTitle2ndFeesAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupMpayTitle2ndInterestAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupMpayTitle2ndInventoryAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupMpayTitle2ndLienAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupMpayTitle2ndNsfFeeAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupMpayTitle2ndTransAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupMpayTitleAdastraBadDebtAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupMpayTitleCabCollAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupMpayTitleCabCollectedAccruedInterestAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupMpayTitleCabDefAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupMpayTitleCabDueToLenderSuspenseAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupMpayTitleCabLenderInterestAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupMpayTitleCabLenderRiFeeAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupMpayTitleCabUncollectedAccruedInterestAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupMpayTitleCollAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupMpayTitleDecreaseAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupMpayTitleDefAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupMpayTitleFasterPaymentsFeeAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupMpayTitleFeesAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupMpayTitleFundingSuspenseAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupMpayTitleInterestAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupMpayTitleInventoryAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupMpayTitleLegalFeesAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupMpayTitleLienAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupMpayTitleNsfFeeAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupMpayTitleTransAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupOendBlActivityFeeAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupOendBlAdastraBadDebtAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupOendBlCabCollAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupOendBlCabCollectedAccruedInterestAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupOendBlCabDueToLenderSuspenseAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupOendBlCabFeeReceivableAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupOendBlCabLenderInterestAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupOendBlCabLenderRiFeeAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupOendBlCabRiAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupOendBlCabUncollectedAccruedInterestAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupOendBlCollAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupOendBlDecreaseAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupOendBlDiscountAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupOendBlInterestAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupOendBlInventoryAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupOendBlRiAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupOendBlTransFeeAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupOendTitle2ndCabCollAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupOendTitle2ndCabCollectedAccruedInterestAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupOendTitle2ndCabDefAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupOendTitle2ndCabDueToLenderSuspenseAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupOendTitle2ndCabFeeReceivableAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupOendTitle2ndCabUncollectedAccruedInterestAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupOendTitle2ndCollAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupOendTitle2ndDefAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupOendTitle2ndDiscountAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupOendTitle2ndFeesAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupOendTitle2ndInventoryAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupOendTitle2ndLienAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupOendTitle2ndTransAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupOendTitleAdastraBadDebtAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupOendTitleCabCollAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupOendTitleCabCollectedAccruedInterestAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupOendTitleCabDefAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupOendTitleCabDueToLenderSuspenseAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupOendTitleCabFeeReceivableAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupOendTitleCabLenderInterestAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupOendTitleCabLenderRiFeeAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupOendTitleCabUncollectedAccruedInterestAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupOendTitleCollAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupOendTitleDecreaseAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupOendTitleDefAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupOendTitleDiscountAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupOendTitleFeesAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupOendTitleInventoryAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupOendTitleLienAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupOendTitleTransAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupReturnCheckCashedChecksAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupReturnCheckPaydayChecksAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpayPaydayAdastraBadDebtAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpayPaydayBadDebtAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpayPaydayChecksCabCollAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpayPaydayChecksCabFeeRecvAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpayPaydayChecksCabLenderInterestAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpayPaydayChecksCabRiAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpayPaydayChecksCollAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpayPaydayChecksDiscountAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpayPaydayChecksFasterPaymentsFeeAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpayPaydayChecksFeesAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpayPaydayChecksInterestAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpayPaydayChecksInventoryAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpayPaydayChecksLegalFeeAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpayPaydayChecksNsfFeeAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpayPaydayChecksRebateAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpayPaydayChecksRiAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpayPaydayChecksRolloverFeeAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpayPaydayDebitCardsCabCollAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpayPaydayDebitCardsCabFeeRecvAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpayPaydayDebitCardsCabLenderInterestAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpayPaydayDebitCardsCabRiAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpayPaydayDebitCardsCollAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpayPaydayDebitCardsDiscountAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpayPaydayDebitCardsFasterPaymentsFeeAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpayPaydayDebitCardsFeesAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpayPaydayDebitCardsFundingSuspenseAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpayPaydayDebitCardsInterestAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpayPaydayDebitCardsInventoryAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpayPaydayDebitCardsLegalFeeAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpayPaydayDebitCardsNsfFeeAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpayPaydayDebitCardsRebateAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpayPaydayDebitCardsRiAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpayPaydayDebitCardsRolloverFeeAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpayPaydayDecreaseAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpayPaydayEftCollectionsClearingAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpayPaydayPadBankClearingAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpayPaydayRolloverSuspenseAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpaySigAdastraBadDebtAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpaySigCabCollAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpaySigCabDefAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpaySigCabFeeRecvAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpaySigCabLenderInterestAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpaySigCollAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpaySigDefAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpaySigFasterPaymentsFeeAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpaySigFeesAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpaySigInterestAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpaySigInventoryAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpaySigLegalFeeAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpaySigNsfFeeAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpaySigRolloverFeeAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpaySigTransAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpayTitle2ndCabCollAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpayTitle2ndCabDefAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpayTitle2ndCabFeeRecvAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpayTitle2ndCabLenderInterestAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpayTitle2ndCollAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpayTitle2ndDefAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpayTitle2ndFasterPaymentsFeeAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpayTitle2ndFeesAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpayTitle2ndInterestAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpayTitle2ndInventoryAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpayTitle2ndLegalFeeAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpayTitle2ndLienAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpayTitle2ndNsfFeeAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpayTitle2ndRolloverFeeAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpayTitle2ndSurchAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpayTitle2ndTransAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpayTitleAdastraBadDebtAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpayTitleCabCollAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpayTitleCabDefAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpayTitleCabFeeRecvAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpayTitleCabLenderInterestAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpayTitleCollAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpayTitleDecreaseAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpayTitleDefAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpayTitleFasterPaymentsFeeAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpayTitleFeesAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpayTitleInterestAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpayTitleInventoryAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpayTitleLegalFeeAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpayTitleLienAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpayTitleNsfFeeAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpayTitleRolloverFeeAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpayTitleSurchAcctNavigation = new HashSet<GlacctGroup>();
            GlacctGroupSpayTitleTransAcctNavigation = new HashSet<GlacctGroup>();
            GoldDailyBag = new HashSet<GoldDailyBag>();
            InitGllist = new HashSet<InitGllist>();
            ServiceTransGlAcctAmtNavigation = new HashSet<ServiceTrans>();
            ServiceTransGlAcctFeeNavigation = new HashSet<ServiceTrans>();
            TransDetailAcct = new HashSet<TransDetailAcct>();
            TransferFunds = new HashSet<TransferFunds>();
        }

        public int GlAcctKey { get; set; }
        public int GlAcctNum { get; set; }
        public string Description { get; set; }
        public bool IsAdastra { get; set; }
        public bool IsTitleAcct { get; set; }
        public bool IsNoncashAcct { get; set; }
        public bool IsTrecsCashAcct { get; set; }

        public virtual ICollection<BalSheetColumns2> BalSheetColumns2 { get; set; }
        public virtual ICollection<CheckReturn> CheckReturn { get; set; }
        public virtual ICollection<Company> CompanyInterCoNoncashApAcctNavigation { get; set; }
        public virtual ICollection<Company> CompanyInterCoNoncashArAcctNavigation { get; set; }
        public virtual ICollection<Company> CompanyInterCoTitleApAcctNavigation { get; set; }
        public virtual ICollection<Company> CompanyInterCoTitleArAcctNavigation { get; set; }
        public virtual ICollection<Company> CompanyInterStoreApAcctNavigation { get; set; }
        public virtual ICollection<Company> CompanyInterStoreArAcctNavigation { get; set; }
        public virtual ICollection<Currency> CurrencyAcctNavigation { get; set; }
        public virtual ICollection<Currency> CurrencyCashTransitAcctNavigation { get; set; }
        public virtual ICollection<Currency> CurrencyOperatingAcctNavigation { get; set; }
        public virtual ICollection<DiscountMaster> DiscountMaster { get; set; }
        public virtual ICollection<GlacctGlobal> GlacctGlobalAdastraBadDebtCheckAcctNavigation { get; set; }
        public virtual ICollection<GlacctGlobal> GlacctGlobalAdastraCashAndChecksAcctNavigation { get; set; }
        public virtual ICollection<GlacctGlobal> GlacctGlobalAdastraCentralTrustAcctNavigation { get; set; }
        public virtual ICollection<GlacctGlobal> GlacctGlobalAdastraCollectionAgencyReceivableAcctNavigation { get; set; }
        public virtual ICollection<GlacctGlobal> GlacctGlobalAdastraCommissionsApAcctNavigation { get; set; }
        public virtual ICollection<GlacctGlobal> GlacctGlobalAdastraCommissionsArAcctNavigation { get; set; }
        public virtual ICollection<GlacctGlobal> GlacctGlobalAdastraCommissionsExpenseAcctNavigation { get; set; }
        public virtual ICollection<GlacctGlobal> GlacctGlobalAdastraCommissionsFeesAcctNavigation { get; set; }
        public virtual ICollection<GlacctGlobal> GlacctGlobalAdastraTrustProceedsApAcctNavigation { get; set; }
        public virtual ICollection<GlacctGlobal> GlacctGlobalCashInStoreAcctNavigation { get; set; }
        public virtual ICollection<GlacctGlobal> GlacctGlobalCashedCheckDiscountAcctNavigation { get; set; }
        public virtual ICollection<GlacctGlobal> GlacctGlobalCashedCheckFlatFeesAcctNavigation { get; set; }
        public virtual ICollection<GlacctGlobal> GlacctGlobalCashedCheckPctFeesAcctNavigation { get; set; }
        public virtual ICollection<GlacctGlobal> GlacctGlobalCashedCheckPostDatedAcctNavigation { get; set; }
        public virtual ICollection<GlacctGlobal> GlacctGlobalCcardFeeAcctNavigation { get; set; }
        public virtual ICollection<GlacctGlobal> GlacctGlobalCheckCollAcctNavigation { get; set; }
        public virtual ICollection<GlacctGlobal> GlacctGlobalCheckRiAcctNavigation { get; set; }
        public virtual ICollection<GlacctGlobal> GlacctGlobalCourtesyPayoutAcctNavigation { get; set; }
        public virtual ICollection<GlacctGlobal> GlacctGlobalCurrencyExchangeFeeAcctNavigation { get; set; }
        public virtual ICollection<GlacctGlobal> GlacctGlobalCurrencyExchangeGainlossAcctNavigation { get; set; }
        public virtual ICollection<GlacctGlobal> GlacctGlobalCurrencyExchangeOnCheckAcctNavigation { get; set; }
        public virtual ICollection<GlacctGlobal> GlacctGlobalDepositBagsAcctNavigation { get; set; }
        public virtual ICollection<GlacctGlobal> GlacctGlobalGoldFeesPaidAcctNavigation { get; set; }
        public virtual ICollection<GlacctGlobal> GlacctGlobalGoldInvestmentAcctNavigation { get; set; }
        public virtual ICollection<GlacctGlobal> GlacctGlobalGoldLossesAcctNavigation { get; set; }
        public virtual ICollection<GlacctGlobal> GlacctGlobalGoldProcessFeeAcctNavigation { get; set; }
        public virtual ICollection<GlacctGlobal> GlacctGlobalGoldRevenueAcctNavigation { get; set; }
        public virtual ICollection<GlacctGlobal> GlacctGlobalGoldTransitAcctNavigation { get; set; }
        public virtual ICollection<GlacctGlobal> GlacctGlobalInternalShortAcctNavigation { get; set; }
        public virtual ICollection<GlacctGlobal> GlacctGlobalMpayInternetCollectionsAcctNavigation { get; set; }
        public virtual ICollection<GlacctGlobal> GlacctGlobalMpayInternetCreditClearingAcctNavigation { get; set; }
        public virtual ICollection<GlacctGlobal> GlacctGlobalMpayInternetReturnsAcctNavigation { get; set; }
        public virtual ICollection<GlacctGlobal> GlacctGlobalMpayInternetRevenueAcctNavigation { get; set; }
        public virtual ICollection<GlacctGlobal> GlacctGlobalOendInternetCollectionsAcctNavigation { get; set; }
        public virtual ICollection<GlacctGlobal> GlacctGlobalOendInternetCreditClearingAcctNavigation { get; set; }
        public virtual ICollection<GlacctGlobal> GlacctGlobalOendInternetReturnsAcctNavigation { get; set; }
        public virtual ICollection<GlacctGlobal> GlacctGlobalOendInternetRevenueAcctNavigation { get; set; }
        public virtual ICollection<GlacctGlobal> GlacctGlobalOptplusCollAcctNavigation { get; set; }
        public virtual ICollection<GlacctGlobal> GlacctGlobalOptplusReturnsAcctNavigation { get; set; }
        public virtual ICollection<GlacctGlobal> GlacctGlobalOverShortAcctNavigation { get; set; }
        public virtual ICollection<GlacctGlobal> GlacctGlobalSalesTaxAcctNavigation { get; set; }
        public virtual ICollection<GlacctGlobal> GlacctGlobalSpayInternetCollectionsAcctNavigation { get; set; }
        public virtual ICollection<GlacctGlobal> GlacctGlobalSpayInternetCreditClearingAcctNavigation { get; set; }
        public virtual ICollection<GlacctGlobal> GlacctGlobalSpayInternetReturnsAcctNavigation { get; set; }
        public virtual ICollection<GlacctGlobal> GlacctGlobalSpayInternetRevenueAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupAchCollAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupAchSuspenseAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupCashedCheckCanUsdAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupCcardCollAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupCcardSuspenseAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupChecksPrimaryBankAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupLoansPrimaryBankAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupMpayBlAdastraBadDebtAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupMpayBlCabCollAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupMpayBlCabCollectedAccruedInterestAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupMpayBlCabDefAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupMpayBlCabDueToLenderSuspenseAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupMpayBlCabLenderInterestAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupMpayBlCabLenderRiFeeAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupMpayBlCabUncollectedAccruedInterestAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupMpayBlCollAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupMpayBlDecreaseAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupMpayBlDueDatePaymentQueueSuspenseAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupMpayBlFasterPaymentsFeeAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupMpayBlFeesAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupMpayBlFundingSuspenseAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupMpayBlInsuranceApAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupMpayBlInsuranceCogsAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupMpayBlInsuranceRevenueAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupMpayBlInsuranceTaxAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupMpayBlInterestAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupMpayBlInventoryAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupMpayBlLegalFeesAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupMpayBlNsfFeeAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupMpayBlRiAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupMpayBlTaxPrepInvAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupMpayBlTaxPrepRevAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupMpaySigAdastraBadDebtAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupMpaySigCabCollAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupMpaySigCabCollectedAccruedInterestAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupMpaySigCabDefAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupMpaySigCabDueToLenderSuspenseAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupMpaySigCabUncollectedAccruedInterestAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupMpaySigCollAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupMpaySigDecreaseAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupMpaySigDefAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupMpaySigFasterPaymentsFeeAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupMpaySigFeesAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupMpaySigInterestAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupMpaySigInventoryAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupMpaySigLegalFeesAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupMpaySigNsfFeeAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupMpaySigTaxAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupMpaySigTransAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupMpayTitle2ndCollAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupMpayTitle2ndDefAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupMpayTitle2ndFasterPaymentsFeeAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupMpayTitle2ndFeesAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupMpayTitle2ndInterestAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupMpayTitle2ndInventoryAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupMpayTitle2ndLienAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupMpayTitle2ndNsfFeeAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupMpayTitle2ndTransAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupMpayTitleAdastraBadDebtAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupMpayTitleCabCollAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupMpayTitleCabCollectedAccruedInterestAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupMpayTitleCabDefAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupMpayTitleCabDueToLenderSuspenseAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupMpayTitleCabLenderInterestAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupMpayTitleCabLenderRiFeeAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupMpayTitleCabUncollectedAccruedInterestAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupMpayTitleCollAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupMpayTitleDecreaseAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupMpayTitleDefAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupMpayTitleFasterPaymentsFeeAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupMpayTitleFeesAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupMpayTitleFundingSuspenseAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupMpayTitleInterestAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupMpayTitleInventoryAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupMpayTitleLegalFeesAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupMpayTitleLienAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupMpayTitleNsfFeeAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupMpayTitleTransAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupOendBlActivityFeeAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupOendBlAdastraBadDebtAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupOendBlCabCollAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupOendBlCabCollectedAccruedInterestAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupOendBlCabDueToLenderSuspenseAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupOendBlCabFeeReceivableAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupOendBlCabLenderInterestAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupOendBlCabLenderRiFeeAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupOendBlCabRiAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupOendBlCabUncollectedAccruedInterestAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupOendBlCollAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupOendBlDecreaseAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupOendBlDiscountAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupOendBlInterestAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupOendBlInventoryAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupOendBlRiAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupOendBlTransFeeAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupOendTitle2ndCabCollAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupOendTitle2ndCabCollectedAccruedInterestAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupOendTitle2ndCabDefAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupOendTitle2ndCabDueToLenderSuspenseAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupOendTitle2ndCabFeeReceivableAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupOendTitle2ndCabUncollectedAccruedInterestAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupOendTitle2ndCollAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupOendTitle2ndDefAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupOendTitle2ndDiscountAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupOendTitle2ndFeesAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupOendTitle2ndInventoryAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupOendTitle2ndLienAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupOendTitle2ndTransAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupOendTitleAdastraBadDebtAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupOendTitleCabCollAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupOendTitleCabCollectedAccruedInterestAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupOendTitleCabDefAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupOendTitleCabDueToLenderSuspenseAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupOendTitleCabFeeReceivableAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupOendTitleCabLenderInterestAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupOendTitleCabLenderRiFeeAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupOendTitleCabUncollectedAccruedInterestAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupOendTitleCollAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupOendTitleDecreaseAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupOendTitleDefAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupOendTitleDiscountAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupOendTitleFeesAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupOendTitleInventoryAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupOendTitleLienAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupOendTitleTransAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupReturnCheckCashedChecksAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupReturnCheckPaydayChecksAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpayPaydayAdastraBadDebtAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpayPaydayBadDebtAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpayPaydayChecksCabCollAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpayPaydayChecksCabFeeRecvAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpayPaydayChecksCabLenderInterestAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpayPaydayChecksCabRiAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpayPaydayChecksCollAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpayPaydayChecksDiscountAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpayPaydayChecksFasterPaymentsFeeAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpayPaydayChecksFeesAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpayPaydayChecksInterestAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpayPaydayChecksInventoryAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpayPaydayChecksLegalFeeAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpayPaydayChecksNsfFeeAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpayPaydayChecksRebateAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpayPaydayChecksRiAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpayPaydayChecksRolloverFeeAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpayPaydayDebitCardsCabCollAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpayPaydayDebitCardsCabFeeRecvAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpayPaydayDebitCardsCabLenderInterestAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpayPaydayDebitCardsCabRiAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpayPaydayDebitCardsCollAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpayPaydayDebitCardsDiscountAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpayPaydayDebitCardsFasterPaymentsFeeAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpayPaydayDebitCardsFeesAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpayPaydayDebitCardsFundingSuspenseAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpayPaydayDebitCardsInterestAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpayPaydayDebitCardsInventoryAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpayPaydayDebitCardsLegalFeeAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpayPaydayDebitCardsNsfFeeAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpayPaydayDebitCardsRebateAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpayPaydayDebitCardsRiAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpayPaydayDebitCardsRolloverFeeAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpayPaydayDecreaseAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpayPaydayEftCollectionsClearingAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpayPaydayPadBankClearingAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpayPaydayRolloverSuspenseAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpaySigAdastraBadDebtAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpaySigCabCollAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpaySigCabDefAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpaySigCabFeeRecvAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpaySigCabLenderInterestAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpaySigCollAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpaySigDefAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpaySigFasterPaymentsFeeAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpaySigFeesAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpaySigInterestAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpaySigInventoryAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpaySigLegalFeeAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpaySigNsfFeeAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpaySigRolloverFeeAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpaySigTransAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpayTitle2ndCabCollAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpayTitle2ndCabDefAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpayTitle2ndCabFeeRecvAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpayTitle2ndCabLenderInterestAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpayTitle2ndCollAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpayTitle2ndDefAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpayTitle2ndFasterPaymentsFeeAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpayTitle2ndFeesAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpayTitle2ndInterestAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpayTitle2ndInventoryAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpayTitle2ndLegalFeeAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpayTitle2ndLienAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpayTitle2ndNsfFeeAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpayTitle2ndRolloverFeeAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpayTitle2ndSurchAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpayTitle2ndTransAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpayTitleAdastraBadDebtAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpayTitleCabCollAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpayTitleCabDefAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpayTitleCabFeeRecvAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpayTitleCabLenderInterestAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpayTitleCollAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpayTitleDecreaseAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpayTitleDefAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpayTitleFasterPaymentsFeeAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpayTitleFeesAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpayTitleInterestAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpayTitleInventoryAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpayTitleLegalFeeAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpayTitleLienAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpayTitleNsfFeeAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpayTitleRolloverFeeAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpayTitleSurchAcctNavigation { get; set; }
        public virtual ICollection<GlacctGroup> GlacctGroupSpayTitleTransAcctNavigation { get; set; }
        public virtual ICollection<GoldDailyBag> GoldDailyBag { get; set; }
        public virtual ICollection<InitGllist> InitGllist { get; set; }
        public virtual ICollection<ServiceTrans> ServiceTransGlAcctAmtNavigation { get; set; }
        public virtual ICollection<ServiceTrans> ServiceTransGlAcctFeeNavigation { get; set; }
        public virtual ICollection<TransDetailAcct> TransDetailAcct { get; set; }
        public virtual ICollection<TransferFunds> TransferFunds { get; set; }
    }
}
