using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class GlacctGroup
    {
        public GlacctGroup()
        {
            Company = new HashSet<Company>();
        }

        public int GlAcctGroupKey { get; set; }
        public string GroupName { get; set; }
        public int? CcardSuspenseAcct { get; set; }
        public int? CcardCollAcct { get; set; }
        public int? CashedCheckCanUsdAcct { get; set; }
        public int? LoansPrimaryBankAcct { get; set; }
        public int? ChecksPrimaryBankAcct { get; set; }
        public int? SpayPaydayChecksInventoryAcct { get; set; }
        public int? SpayPaydayChecksFeesAcct { get; set; }
        public int? SpayPaydayChecksRiAcct { get; set; }
        public int? SpayPaydayChecksCollAcct { get; set; }
        public int? SpayPaydayChecksCabFeeRecvAcct { get; set; }
        public int? SpayPaydayChecksCabRiAcct { get; set; }
        public int? SpayPaydayChecksCabCollAcct { get; set; }
        public int? SpayPaydayChecksRebateAcct { get; set; }
        public int? SpayPaydayChecksDiscountAcct { get; set; }
        public int? SpayPaydayChecksLegalFeeAcct { get; set; }
        public int? SpayPaydayChecksNsfFeeAcct { get; set; }
        public int? SpayPaydayChecksInterestAcct { get; set; }
        public int? SpayPaydayChecksRolloverFeeAcct { get; set; }
        public int? SpayPaydayChecksFasterPaymentsFeeAcct { get; set; }
        public int? SpayPaydayDebitCardsInventoryAcct { get; set; }
        public int? SpayPaydayDebitCardsFeesAcct { get; set; }
        public int? SpayPaydayDebitCardsRiAcct { get; set; }
        public int? SpayPaydayDebitCardsCollAcct { get; set; }
        public int? SpayPaydayDebitCardsCabFeeRecvAcct { get; set; }
        public int? SpayPaydayDebitCardsCabRiAcct { get; set; }
        public int? SpayPaydayDebitCardsCabCollAcct { get; set; }
        public int? SpayPaydayDebitCardsFundingSuspenseAcct { get; set; }
        public int? SpayPaydayDebitCardsRebateAcct { get; set; }
        public int? SpayPaydayDebitCardsDiscountAcct { get; set; }
        public int? SpayPaydayDebitCardsLegalFeeAcct { get; set; }
        public int? SpayPaydayDebitCardsNsfFeeAcct { get; set; }
        public int? SpayPaydayDebitCardsInterestAcct { get; set; }
        public int? SpayPaydayDebitCardsRolloverFeeAcct { get; set; }
        public int? SpayPaydayDebitCardsFasterPaymentsFeeAcct { get; set; }
        public int? SpayPaydayPadBankClearingAcct { get; set; }
        public int? SpayPaydayEftCollectionsClearingAcct { get; set; }
        public int? SpayPaydayBadDebtAcct { get; set; }
        public int? SpayPaydayRolloverSuspenseAcct { get; set; }
        public int? SpayPaydayAdastraBadDebtAcct { get; set; }
        public int? SpayTitleInventoryAcct { get; set; }
        public int? SpayTitleFeesAcct { get; set; }
        public int? SpayTitleLienAcct { get; set; }
        public int? SpayTitleTransAcct { get; set; }
        public int? SpayTitleDefAcct { get; set; }
        public int? SpayTitleCollAcct { get; set; }
        public int? SpayTitleCabFeeRecvAcct { get; set; }
        public int? SpayTitleCabDefAcct { get; set; }
        public int? SpayTitleCabCollAcct { get; set; }
        public int? SpayTitleSurchAcct { get; set; }
        public int? SpayTitleLegalFeeAcct { get; set; }
        public int? SpayTitleNsfFeeAcct { get; set; }
        public int? SpayTitleInterestAcct { get; set; }
        public int? SpayTitleFasterPaymentsFeeAcct { get; set; }
        public int? SpayTitleRolloverFeeAcct { get; set; }
        public int? SpayTitleAdastraBadDebtAcct { get; set; }
        public int? SpayTitle2ndInventoryAcct { get; set; }
        public int? SpayTitle2ndFeesAcct { get; set; }
        public int? SpayTitle2ndLienAcct { get; set; }
        public int? SpayTitle2ndTransAcct { get; set; }
        public int? SpayTitle2ndDefAcct { get; set; }
        public int? SpayTitle2ndCollAcct { get; set; }
        public int? SpayTitle2ndCabFeeRecvAcct { get; set; }
        public int? SpayTitle2ndCabDefAcct { get; set; }
        public int? SpayTitle2ndCabCollAcct { get; set; }
        public int? SpayTitle2ndSurchAcct { get; set; }
        public int? SpayTitle2ndLegalFeeAcct { get; set; }
        public int? SpayTitle2ndNsfFeeAcct { get; set; }
        public int? SpayTitle2ndInterestAcct { get; set; }
        public int? SpayTitle2ndFasterPaymentsFeeAcct { get; set; }
        public int? SpayTitle2ndRolloverFeeAcct { get; set; }
        public int? SpaySigInventoryAcct { get; set; }
        public int? SpaySigFeesAcct { get; set; }
        public int? SpaySigTransAcct { get; set; }
        public int? SpaySigDefAcct { get; set; }
        public int? SpaySigCollAcct { get; set; }
        public int? SpaySigCabFeeRecvAcct { get; set; }
        public int? SpaySigCabDefAcct { get; set; }
        public int? SpaySigCabCollAcct { get; set; }
        public int? SpaySigLegalFeeAcct { get; set; }
        public int? SpaySigNsfFeeAcct { get; set; }
        public int? SpaySigInterestAcct { get; set; }
        public int? SpaySigFasterPaymentsFeeAcct { get; set; }
        public int? SpaySigRolloverFeeAcct { get; set; }
        public int? SpaySigAdastraBadDebtAcct { get; set; }
        public int? MpayBlTaxPrepInvAcct { get; set; }
        public int? MpayBlTaxPrepRevAcct { get; set; }
        public int? MpayBlInventoryAcct { get; set; }
        public int? MpayBlFeesAcct { get; set; }
        public int? MpayBlRiAcct { get; set; }
        public int? MpayBlCollAcct { get; set; }
        public int? MpayBlFundingSuspenseAcct { get; set; }
        public int? MpayBlLegalFeesAcct { get; set; }
        public int? MpayBlCabDueToLenderSuspenseAcct { get; set; }
        public int? MpayBlCabUncollectedAccruedInterestAcct { get; set; }
        public int? MpayBlCabCollectedAccruedInterestAcct { get; set; }
        public int? MpayBlCabDefAcct { get; set; }
        public int? MpayBlCabCollAcct { get; set; }
        public int? MpayBlNsfFeeAcct { get; set; }
        public int? MpayBlInterestAcct { get; set; }
        public int? MpayBlFasterPaymentsFeeAcct { get; set; }
        public int? MpayBlCabLenderInterestAcct { get; set; }
        public int? MpayBlCabLenderRiFeeAcct { get; set; }
        public int? MpayBlAdastraBadDebtAcct { get; set; }
        public int? MpayTitleInventoryAcct { get; set; }
        public int? MpayTitleFeesAcct { get; set; }
        public int? MpayTitleLienAcct { get; set; }
        public int? MpayTitleTransAcct { get; set; }
        public int? MpayTitleDefAcct { get; set; }
        public int? MpayTitleCollAcct { get; set; }
        public int? MpayTitleFundingSuspenseAcct { get; set; }
        public int? MpayTitleLegalFeesAcct { get; set; }
        public int? MpayTitleCabDueToLenderSuspenseAcct { get; set; }
        public int? MpayTitleCabUncollectedAccruedInterestAcct { get; set; }
        public int? MpayTitleCabCollectedAccruedInterestAcct { get; set; }
        public int? MpayTitleCabDefAcct { get; set; }
        public int? MpayTitleCabCollAcct { get; set; }
        public int? MpayTitleCabLenderInterestAcct { get; set; }
        public int? MpayTitleCabLenderRiFeeAcct { get; set; }
        public int? MpayTitleNsfFeeAcct { get; set; }
        public int? MpayTitleInterestAcct { get; set; }
        public int? MpayTitleFasterPaymentsFeeAcct { get; set; }
        public int? MpayTitleAdastraBadDebtAcct { get; set; }
        public int? MpayTitle2ndInventoryAcct { get; set; }
        public int? MpayTitle2ndFeesAcct { get; set; }
        public int? MpayTitle2ndLienAcct { get; set; }
        public int? MpayTitle2ndTransAcct { get; set; }
        public int? MpayTitle2ndDefAcct { get; set; }
        public int? MpayTitle2ndCollAcct { get; set; }
        public int? MpayTitle2ndNsfFeeAcct { get; set; }
        public int? MpayTitle2ndInterestAcct { get; set; }
        public int? MpayTitle2ndFasterPaymentsFeeAcct { get; set; }
        public int? MpaySigInventoryAcct { get; set; }
        public int? MpaySigFeesAcct { get; set; }
        public int? MpaySigTransAcct { get; set; }
        public int? MpaySigDefAcct { get; set; }
        public int? MpaySigCollAcct { get; set; }
        public int? MpaySigLegalFeesAcct { get; set; }
        public int? MpaySigTaxAcct { get; set; }
        public int? MpaySigCabDueToLenderSuspenseAcct { get; set; }
        public int? MpaySigCabUncollectedAccruedInterestAcct { get; set; }
        public int? MpaySigCabCollectedAccruedInterestAcct { get; set; }
        public int? MpaySigCabDefAcct { get; set; }
        public int? MpaySigCabCollAcct { get; set; }
        public int? MpaySigNsfFeeAcct { get; set; }
        public int? MpaySigInterestAcct { get; set; }
        public int? MpaySigFasterPaymentsFeeAcct { get; set; }
        public int? MpaySigAdastraBadDebtAcct { get; set; }
        public int? OendBlInventoryAcct { get; set; }
        public int? OendBlTransFeeAcct { get; set; }
        public int? OendBlActivityFeeAcct { get; set; }
        public int? OendBlInterestAcct { get; set; }
        public int? OendBlRiAcct { get; set; }
        public int? OendBlCollAcct { get; set; }
        public int? OendBlCabRiAcct { get; set; }
        public int? OendBlCabCollAcct { get; set; }
        public int? OendBlCabDueToLenderSuspenseAcct { get; set; }
        public int? OendBlCabUncollectedAccruedInterestAcct { get; set; }
        public int? OendBlCabCollectedAccruedInterestAcct { get; set; }
        public int? OendBlCabFeeReceivableAcct { get; set; }
        public int? OendBlCabLenderInterestAcct { get; set; }
        public int? OendBlCabLenderRiFeeAcct { get; set; }
        public int? OendBlDiscountAcct { get; set; }
        public int? OendBlAdastraBadDebtAcct { get; set; }
        public int? OendTitleInventoryAcct { get; set; }
        public int? OendTitleFeesAcct { get; set; }
        public int? OendTitleLienAcct { get; set; }
        public int? OendTitleTransAcct { get; set; }
        public int? OendTitleDefAcct { get; set; }
        public int? OendTitleCollAcct { get; set; }
        public int? OendTitleCabDefAcct { get; set; }
        public int? OendTitleCabCollAcct { get; set; }
        public int? OendTitleCabDueToLenderSuspenseAcct { get; set; }
        public int? OendTitleCabUncollectedAccruedInterestAcct { get; set; }
        public int? OendTitleCabCollectedAccruedInterestAcct { get; set; }
        public int? OendTitleCabFeeReceivableAcct { get; set; }
        public int? OendTitleCabLenderInterestAcct { get; set; }
        public int? OendTitleCabLenderRiFeeAcct { get; set; }
        public int? OendTitleDiscountAcct { get; set; }
        public int? OendTitleAdastraBadDebtAcct { get; set; }
        public int? OendTitle2ndInventoryAcct { get; set; }
        public int? OendTitle2ndFeesAcct { get; set; }
        public int? OendTitle2ndLienAcct { get; set; }
        public int? OendTitle2ndTransAcct { get; set; }
        public int? OendTitle2ndDefAcct { get; set; }
        public int? OendTitle2ndCollAcct { get; set; }
        public int? OendTitle2ndCabDefAcct { get; set; }
        public int? OendTitle2ndCabCollAcct { get; set; }
        public int? OendTitle2ndCabDueToLenderSuspenseAcct { get; set; }
        public int? OendTitle2ndCabUncollectedAccruedInterestAcct { get; set; }
        public int? OendTitle2ndCabCollectedAccruedInterestAcct { get; set; }
        public int? OendTitle2ndCabFeeReceivableAcct { get; set; }
        public int? OendTitle2ndDiscountAcct { get; set; }
        public int? ReturnCheckPaydayChecksAcct { get; set; }
        public int? ReturnCheckCashedChecksAcct { get; set; }
        public int? SpayPaydayDecreaseAcct { get; set; }
        public int? SpayTitleDecreaseAcct { get; set; }
        public int? MpayBlDecreaseAcct { get; set; }
        public int? MpaySigDecreaseAcct { get; set; }
        public int? MpayTitleDecreaseAcct { get; set; }
        public int? OendBlDecreaseAcct { get; set; }
        public int? OendTitleDecreaseAcct { get; set; }
        public int? AchSuspenseAcct { get; set; }
        public int? AchCollAcct { get; set; }
        public int? MpayBlInsuranceRevenueAcct { get; set; }
        public int? MpayBlInsuranceCogsAcct { get; set; }
        public int? MpayBlInsuranceApAcct { get; set; }
        public int? SpayPaydayDebitCardsCabLenderInterestAcct { get; set; }
        public int? SpayPaydayChecksCabLenderInterestAcct { get; set; }
        public int? SpayTitleCabLenderInterestAcct { get; set; }
        public int? SpayTitle2ndCabLenderInterestAcct { get; set; }
        public int? SpaySigCabLenderInterestAcct { get; set; }
        public int? MpayBlDueDatePaymentQueueSuspenseAcct { get; set; }
        public int? MpayBlInsuranceTaxAcct { get; set; }

        public virtual ICollection<Company> Company { get; set; }
        public virtual Glacct AchCollAcctNavigation { get; set; }
        public virtual Glacct AchSuspenseAcctNavigation { get; set; }
        public virtual Glacct CashedCheckCanUsdAcctNavigation { get; set; }
        public virtual Glacct CcardCollAcctNavigation { get; set; }
        public virtual Glacct CcardSuspenseAcctNavigation { get; set; }
        public virtual Glacct ChecksPrimaryBankAcctNavigation { get; set; }
        public virtual Glacct LoansPrimaryBankAcctNavigation { get; set; }
        public virtual Glacct MpayBlAdastraBadDebtAcctNavigation { get; set; }
        public virtual Glacct MpayBlCabCollAcctNavigation { get; set; }
        public virtual Glacct MpayBlCabCollectedAccruedInterestAcctNavigation { get; set; }
        public virtual Glacct MpayBlCabDefAcctNavigation { get; set; }
        public virtual Glacct MpayBlCabDueToLenderSuspenseAcctNavigation { get; set; }
        public virtual Glacct MpayBlCabLenderInterestAcctNavigation { get; set; }
        public virtual Glacct MpayBlCabLenderRiFeeAcctNavigation { get; set; }
        public virtual Glacct MpayBlCabUncollectedAccruedInterestAcctNavigation { get; set; }
        public virtual Glacct MpayBlCollAcctNavigation { get; set; }
        public virtual Glacct MpayBlDecreaseAcctNavigation { get; set; }
        public virtual Glacct MpayBlDueDatePaymentQueueSuspenseAcctNavigation { get; set; }
        public virtual Glacct MpayBlFasterPaymentsFeeAcctNavigation { get; set; }
        public virtual Glacct MpayBlFeesAcctNavigation { get; set; }
        public virtual Glacct MpayBlFundingSuspenseAcctNavigation { get; set; }
        public virtual Glacct MpayBlInsuranceApAcctNavigation { get; set; }
        public virtual Glacct MpayBlInsuranceCogsAcctNavigation { get; set; }
        public virtual Glacct MpayBlInsuranceRevenueAcctNavigation { get; set; }
        public virtual Glacct MpayBlInsuranceTaxAcctNavigation { get; set; }
        public virtual Glacct MpayBlInterestAcctNavigation { get; set; }
        public virtual Glacct MpayBlInventoryAcctNavigation { get; set; }
        public virtual Glacct MpayBlLegalFeesAcctNavigation { get; set; }
        public virtual Glacct MpayBlNsfFeeAcctNavigation { get; set; }
        public virtual Glacct MpayBlRiAcctNavigation { get; set; }
        public virtual Glacct MpayBlTaxPrepInvAcctNavigation { get; set; }
        public virtual Glacct MpayBlTaxPrepRevAcctNavigation { get; set; }
        public virtual Glacct MpaySigAdastraBadDebtAcctNavigation { get; set; }
        public virtual Glacct MpaySigCabCollAcctNavigation { get; set; }
        public virtual Glacct MpaySigCabCollectedAccruedInterestAcctNavigation { get; set; }
        public virtual Glacct MpaySigCabDefAcctNavigation { get; set; }
        public virtual Glacct MpaySigCabDueToLenderSuspenseAcctNavigation { get; set; }
        public virtual Glacct MpaySigCabUncollectedAccruedInterestAcctNavigation { get; set; }
        public virtual Glacct MpaySigCollAcctNavigation { get; set; }
        public virtual Glacct MpaySigDecreaseAcctNavigation { get; set; }
        public virtual Glacct MpaySigDefAcctNavigation { get; set; }
        public virtual Glacct MpaySigFasterPaymentsFeeAcctNavigation { get; set; }
        public virtual Glacct MpaySigFeesAcctNavigation { get; set; }
        public virtual Glacct MpaySigInterestAcctNavigation { get; set; }
        public virtual Glacct MpaySigInventoryAcctNavigation { get; set; }
        public virtual Glacct MpaySigLegalFeesAcctNavigation { get; set; }
        public virtual Glacct MpaySigNsfFeeAcctNavigation { get; set; }
        public virtual Glacct MpaySigTaxAcctNavigation { get; set; }
        public virtual Glacct MpaySigTransAcctNavigation { get; set; }
        public virtual Glacct MpayTitle2ndCollAcctNavigation { get; set; }
        public virtual Glacct MpayTitle2ndDefAcctNavigation { get; set; }
        public virtual Glacct MpayTitle2ndFasterPaymentsFeeAcctNavigation { get; set; }
        public virtual Glacct MpayTitle2ndFeesAcctNavigation { get; set; }
        public virtual Glacct MpayTitle2ndInterestAcctNavigation { get; set; }
        public virtual Glacct MpayTitle2ndInventoryAcctNavigation { get; set; }
        public virtual Glacct MpayTitle2ndLienAcctNavigation { get; set; }
        public virtual Glacct MpayTitle2ndNsfFeeAcctNavigation { get; set; }
        public virtual Glacct MpayTitle2ndTransAcctNavigation { get; set; }
        public virtual Glacct MpayTitleAdastraBadDebtAcctNavigation { get; set; }
        public virtual Glacct MpayTitleCabCollAcctNavigation { get; set; }
        public virtual Glacct MpayTitleCabCollectedAccruedInterestAcctNavigation { get; set; }
        public virtual Glacct MpayTitleCabDefAcctNavigation { get; set; }
        public virtual Glacct MpayTitleCabDueToLenderSuspenseAcctNavigation { get; set; }
        public virtual Glacct MpayTitleCabLenderInterestAcctNavigation { get; set; }
        public virtual Glacct MpayTitleCabLenderRiFeeAcctNavigation { get; set; }
        public virtual Glacct MpayTitleCabUncollectedAccruedInterestAcctNavigation { get; set; }
        public virtual Glacct MpayTitleCollAcctNavigation { get; set; }
        public virtual Glacct MpayTitleDecreaseAcctNavigation { get; set; }
        public virtual Glacct MpayTitleDefAcctNavigation { get; set; }
        public virtual Glacct MpayTitleFasterPaymentsFeeAcctNavigation { get; set; }
        public virtual Glacct MpayTitleFeesAcctNavigation { get; set; }
        public virtual Glacct MpayTitleFundingSuspenseAcctNavigation { get; set; }
        public virtual Glacct MpayTitleInterestAcctNavigation { get; set; }
        public virtual Glacct MpayTitleInventoryAcctNavigation { get; set; }
        public virtual Glacct MpayTitleLegalFeesAcctNavigation { get; set; }
        public virtual Glacct MpayTitleLienAcctNavigation { get; set; }
        public virtual Glacct MpayTitleNsfFeeAcctNavigation { get; set; }
        public virtual Glacct MpayTitleTransAcctNavigation { get; set; }
        public virtual Glacct OendBlActivityFeeAcctNavigation { get; set; }
        public virtual Glacct OendBlAdastraBadDebtAcctNavigation { get; set; }
        public virtual Glacct OendBlCabCollAcctNavigation { get; set; }
        public virtual Glacct OendBlCabCollectedAccruedInterestAcctNavigation { get; set; }
        public virtual Glacct OendBlCabDueToLenderSuspenseAcctNavigation { get; set; }
        public virtual Glacct OendBlCabFeeReceivableAcctNavigation { get; set; }
        public virtual Glacct OendBlCabLenderInterestAcctNavigation { get; set; }
        public virtual Glacct OendBlCabLenderRiFeeAcctNavigation { get; set; }
        public virtual Glacct OendBlCabRiAcctNavigation { get; set; }
        public virtual Glacct OendBlCabUncollectedAccruedInterestAcctNavigation { get; set; }
        public virtual Glacct OendBlCollAcctNavigation { get; set; }
        public virtual Glacct OendBlDecreaseAcctNavigation { get; set; }
        public virtual Glacct OendBlDiscountAcctNavigation { get; set; }
        public virtual Glacct OendBlInterestAcctNavigation { get; set; }
        public virtual Glacct OendBlInventoryAcctNavigation { get; set; }
        public virtual Glacct OendBlRiAcctNavigation { get; set; }
        public virtual Glacct OendBlTransFeeAcctNavigation { get; set; }
        public virtual Glacct OendTitle2ndCabCollAcctNavigation { get; set; }
        public virtual Glacct OendTitle2ndCabCollectedAccruedInterestAcctNavigation { get; set; }
        public virtual Glacct OendTitle2ndCabDefAcctNavigation { get; set; }
        public virtual Glacct OendTitle2ndCabDueToLenderSuspenseAcctNavigation { get; set; }
        public virtual Glacct OendTitle2ndCabFeeReceivableAcctNavigation { get; set; }
        public virtual Glacct OendTitle2ndCabUncollectedAccruedInterestAcctNavigation { get; set; }
        public virtual Glacct OendTitle2ndCollAcctNavigation { get; set; }
        public virtual Glacct OendTitle2ndDefAcctNavigation { get; set; }
        public virtual Glacct OendTitle2ndDiscountAcctNavigation { get; set; }
        public virtual Glacct OendTitle2ndFeesAcctNavigation { get; set; }
        public virtual Glacct OendTitle2ndInventoryAcctNavigation { get; set; }
        public virtual Glacct OendTitle2ndLienAcctNavigation { get; set; }
        public virtual Glacct OendTitle2ndTransAcctNavigation { get; set; }
        public virtual Glacct OendTitleAdastraBadDebtAcctNavigation { get; set; }
        public virtual Glacct OendTitleCabCollAcctNavigation { get; set; }
        public virtual Glacct OendTitleCabCollectedAccruedInterestAcctNavigation { get; set; }
        public virtual Glacct OendTitleCabDefAcctNavigation { get; set; }
        public virtual Glacct OendTitleCabDueToLenderSuspenseAcctNavigation { get; set; }
        public virtual Glacct OendTitleCabFeeReceivableAcctNavigation { get; set; }
        public virtual Glacct OendTitleCabLenderInterestAcctNavigation { get; set; }
        public virtual Glacct OendTitleCabLenderRiFeeAcctNavigation { get; set; }
        public virtual Glacct OendTitleCabUncollectedAccruedInterestAcctNavigation { get; set; }
        public virtual Glacct OendTitleCollAcctNavigation { get; set; }
        public virtual Glacct OendTitleDecreaseAcctNavigation { get; set; }
        public virtual Glacct OendTitleDefAcctNavigation { get; set; }
        public virtual Glacct OendTitleDiscountAcctNavigation { get; set; }
        public virtual Glacct OendTitleFeesAcctNavigation { get; set; }
        public virtual Glacct OendTitleInventoryAcctNavigation { get; set; }
        public virtual Glacct OendTitleLienAcctNavigation { get; set; }
        public virtual Glacct OendTitleTransAcctNavigation { get; set; }
        public virtual Glacct ReturnCheckCashedChecksAcctNavigation { get; set; }
        public virtual Glacct ReturnCheckPaydayChecksAcctNavigation { get; set; }
        public virtual Glacct SpayPaydayAdastraBadDebtAcctNavigation { get; set; }
        public virtual Glacct SpayPaydayBadDebtAcctNavigation { get; set; }
        public virtual Glacct SpayPaydayChecksCabCollAcctNavigation { get; set; }
        public virtual Glacct SpayPaydayChecksCabFeeRecvAcctNavigation { get; set; }
        public virtual Glacct SpayPaydayChecksCabLenderInterestAcctNavigation { get; set; }
        public virtual Glacct SpayPaydayChecksCabRiAcctNavigation { get; set; }
        public virtual Glacct SpayPaydayChecksCollAcctNavigation { get; set; }
        public virtual Glacct SpayPaydayChecksDiscountAcctNavigation { get; set; }
        public virtual Glacct SpayPaydayChecksFasterPaymentsFeeAcctNavigation { get; set; }
        public virtual Glacct SpayPaydayChecksFeesAcctNavigation { get; set; }
        public virtual Glacct SpayPaydayChecksInterestAcctNavigation { get; set; }
        public virtual Glacct SpayPaydayChecksInventoryAcctNavigation { get; set; }
        public virtual Glacct SpayPaydayChecksLegalFeeAcctNavigation { get; set; }
        public virtual Glacct SpayPaydayChecksNsfFeeAcctNavigation { get; set; }
        public virtual Glacct SpayPaydayChecksRebateAcctNavigation { get; set; }
        public virtual Glacct SpayPaydayChecksRiAcctNavigation { get; set; }
        public virtual Glacct SpayPaydayChecksRolloverFeeAcctNavigation { get; set; }
        public virtual Glacct SpayPaydayDebitCardsCabCollAcctNavigation { get; set; }
        public virtual Glacct SpayPaydayDebitCardsCabFeeRecvAcctNavigation { get; set; }
        public virtual Glacct SpayPaydayDebitCardsCabLenderInterestAcctNavigation { get; set; }
        public virtual Glacct SpayPaydayDebitCardsCabRiAcctNavigation { get; set; }
        public virtual Glacct SpayPaydayDebitCardsCollAcctNavigation { get; set; }
        public virtual Glacct SpayPaydayDebitCardsDiscountAcctNavigation { get; set; }
        public virtual Glacct SpayPaydayDebitCardsFasterPaymentsFeeAcctNavigation { get; set; }
        public virtual Glacct SpayPaydayDebitCardsFeesAcctNavigation { get; set; }
        public virtual Glacct SpayPaydayDebitCardsFundingSuspenseAcctNavigation { get; set; }
        public virtual Glacct SpayPaydayDebitCardsInterestAcctNavigation { get; set; }
        public virtual Glacct SpayPaydayDebitCardsInventoryAcctNavigation { get; set; }
        public virtual Glacct SpayPaydayDebitCardsLegalFeeAcctNavigation { get; set; }
        public virtual Glacct SpayPaydayDebitCardsNsfFeeAcctNavigation { get; set; }
        public virtual Glacct SpayPaydayDebitCardsRebateAcctNavigation { get; set; }
        public virtual Glacct SpayPaydayDebitCardsRiAcctNavigation { get; set; }
        public virtual Glacct SpayPaydayDebitCardsRolloverFeeAcctNavigation { get; set; }
        public virtual Glacct SpayPaydayDecreaseAcctNavigation { get; set; }
        public virtual Glacct SpayPaydayEftCollectionsClearingAcctNavigation { get; set; }
        public virtual Glacct SpayPaydayPadBankClearingAcctNavigation { get; set; }
        public virtual Glacct SpayPaydayRolloverSuspenseAcctNavigation { get; set; }
        public virtual Glacct SpaySigAdastraBadDebtAcctNavigation { get; set; }
        public virtual Glacct SpaySigCabCollAcctNavigation { get; set; }
        public virtual Glacct SpaySigCabDefAcctNavigation { get; set; }
        public virtual Glacct SpaySigCabFeeRecvAcctNavigation { get; set; }
        public virtual Glacct SpaySigCabLenderInterestAcctNavigation { get; set; }
        public virtual Glacct SpaySigCollAcctNavigation { get; set; }
        public virtual Glacct SpaySigDefAcctNavigation { get; set; }
        public virtual Glacct SpaySigFasterPaymentsFeeAcctNavigation { get; set; }
        public virtual Glacct SpaySigFeesAcctNavigation { get; set; }
        public virtual Glacct SpaySigInterestAcctNavigation { get; set; }
        public virtual Glacct SpaySigInventoryAcctNavigation { get; set; }
        public virtual Glacct SpaySigLegalFeeAcctNavigation { get; set; }
        public virtual Glacct SpaySigNsfFeeAcctNavigation { get; set; }
        public virtual Glacct SpaySigRolloverFeeAcctNavigation { get; set; }
        public virtual Glacct SpaySigTransAcctNavigation { get; set; }
        public virtual Glacct SpayTitle2ndCabCollAcctNavigation { get; set; }
        public virtual Glacct SpayTitle2ndCabDefAcctNavigation { get; set; }
        public virtual Glacct SpayTitle2ndCabFeeRecvAcctNavigation { get; set; }
        public virtual Glacct SpayTitle2ndCabLenderInterestAcctNavigation { get; set; }
        public virtual Glacct SpayTitle2ndCollAcctNavigation { get; set; }
        public virtual Glacct SpayTitle2ndDefAcctNavigation { get; set; }
        public virtual Glacct SpayTitle2ndFasterPaymentsFeeAcctNavigation { get; set; }
        public virtual Glacct SpayTitle2ndFeesAcctNavigation { get; set; }
        public virtual Glacct SpayTitle2ndInterestAcctNavigation { get; set; }
        public virtual Glacct SpayTitle2ndInventoryAcctNavigation { get; set; }
        public virtual Glacct SpayTitle2ndLegalFeeAcctNavigation { get; set; }
        public virtual Glacct SpayTitle2ndLienAcctNavigation { get; set; }
        public virtual Glacct SpayTitle2ndNsfFeeAcctNavigation { get; set; }
        public virtual Glacct SpayTitle2ndRolloverFeeAcctNavigation { get; set; }
        public virtual Glacct SpayTitle2ndSurchAcctNavigation { get; set; }
        public virtual Glacct SpayTitle2ndTransAcctNavigation { get; set; }
        public virtual Glacct SpayTitleAdastraBadDebtAcctNavigation { get; set; }
        public virtual Glacct SpayTitleCabCollAcctNavigation { get; set; }
        public virtual Glacct SpayTitleCabDefAcctNavigation { get; set; }
        public virtual Glacct SpayTitleCabFeeRecvAcctNavigation { get; set; }
        public virtual Glacct SpayTitleCabLenderInterestAcctNavigation { get; set; }
        public virtual Glacct SpayTitleCollAcctNavigation { get; set; }
        public virtual Glacct SpayTitleDecreaseAcctNavigation { get; set; }
        public virtual Glacct SpayTitleDefAcctNavigation { get; set; }
        public virtual Glacct SpayTitleFasterPaymentsFeeAcctNavigation { get; set; }
        public virtual Glacct SpayTitleFeesAcctNavigation { get; set; }
        public virtual Glacct SpayTitleInterestAcctNavigation { get; set; }
        public virtual Glacct SpayTitleInventoryAcctNavigation { get; set; }
        public virtual Glacct SpayTitleLegalFeeAcctNavigation { get; set; }
        public virtual Glacct SpayTitleLienAcctNavigation { get; set; }
        public virtual Glacct SpayTitleNsfFeeAcctNavigation { get; set; }
        public virtual Glacct SpayTitleRolloverFeeAcctNavigation { get; set; }
        public virtual Glacct SpayTitleSurchAcctNavigation { get; set; }
        public virtual Glacct SpayTitleTransAcctNavigation { get; set; }
    }
}
