using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class Company
    {
        public Company()
        {
            AchbankConfigException = new HashSet<AchbankConfigException>();
            AchHistory = new HashSet<AchHistory>();
            AchHistoryCashedCheck = new HashSet<AchHistoryCashedCheck>();
            AchSent = new HashSet<AchSent>();
            CashedCheck = new HashSet<CashedCheck>();
            CcardResponses = new HashSet<CcardResponses>();
            CollectionAction = new HashSet<CollectionAction>();
            CompanyDocumentResource = new HashSet<CompanyDocumentResource>();
            CompanyExpenseType = new HashSet<CompanyExpenseType>();
            CurrencyExchangeConfig = new HashSet<CurrencyExchangeConfig>();
            CurrencyExchangeTrans = new HashSet<CurrencyExchangeTrans>();
            CustomerDocument = new HashSet<CustomerDocument>();
            CustomerFeedback = new HashSet<CustomerFeedback>();
            CustomerLeadLocation = new HashSet<CustomerLeadLocation>();
            DepositBag = new HashSet<DepositBag>();
            DepositChk = new HashSet<DepositChk>();
            DiscountLocations = new HashSet<DiscountLocations>();
            ExcludeFromCapsHistory = new HashSet<ExcludeFromCapsHistory>();
            FormLetterLocation = new HashSet<FormLetterLocation>();
            GiftCard = new HashSet<GiftCard>();
            GoldConfig = new HashSet<GoldConfig>();
            GoldTrans = new HashSet<GoldTrans>();
            ImageCashLetterDetail = new HashSet<ImageCashLetterDetail>();
            IncomeTypeLocation = new HashSet<IncomeTypeLocation>();
            IncomeVerifyMethodLocation = new HashSet<IncomeVerifyMethodLocation>();
            IssuerLocationNavigation = new HashSet<Issuer>();
            IssuerTlocNavigation = new HashSet<Issuer>();
            LoanCreditedLocationNavigation = new HashSet<Loan>();
            LoanLocationNavigation = new HashSet<Loan>();
            LoanDueDateChange = new HashSet<LoanDueDateChange>();
            LoanPayment = new HashSet<LoanPayment>();
            LoanProductBlocked = new HashSet<LoanProductBlocked>();
            LoanProductConfigLoanStats = new HashSet<LoanProductConfigLoanStats>();
            LoanProductEnableNewLoanLienAddressLocationNavigation = new HashSet<LoanProductEnableNewLoan>();
            LoanProductEnableNewLoanLocationNavigation = new HashSet<LoanProductEnableNewLoan>();
            LoanProductRollover = new HashSet<LoanProductRollover>();
            LocationUsZipcodesXref = new HashSet<LocationUsZipcodesXref>();
            PhoneSkillsCall = new HashSet<PhoneSkillsCall>();
            PrepaidCardBinCompany = new HashSet<PrepaidCardBinCompany>();
            PrepaidCardTrans = new HashSet<PrepaidCardTrans>();
            ProductOpenLoanMatrix = new HashSet<ProductOpenLoanMatrix>();
            Risrept = new HashSet<Risrept>();
            SkipTraceStepLocation = new HashSet<SkipTraceStepLocation>();
            TitleLoan = new HashSet<TitleLoan>();
            VaultMgrAssignment = new HashSet<VaultMgrAssignment>();
            VaultMgrAuthorization = new HashSet<VaultMgrAuthorization>();
            Vehicle = new HashSet<Vehicle>();
            WebLoanCreditFraud = new HashSet<WebLoanCreditFraud>();
        }

        public short Location { get; set; }
        public string Company1 { get; set; }
        public string Phone { get; set; }
        public string AreaCode { get; set; }
        public short MarketKey { get; set; }
        public bool IsCollections { get; set; }
        public bool IsInternet { get; set; }
        public bool IsAutoprintMo { get; set; }
        public bool IsAutoprintReceipt { get; set; }
        public bool IsAutoprintCtr { get; set; }
        public bool EnableDialer { get; set; }
        public bool EnableVaultMgr { get; set; }
        public bool EnableCcard { get; set; }
        public bool EnableRita { get; set; }
        public bool EnableEpp { get; set; }
        public bool EnableNpaReferral { get; set; }
        public string AchUsername { get; set; }
        public string AchPassword { get; set; }
        public string AchAdAstraUsername { get; set; }
        public string AchAdAstraPassword { get; set; }
        public string RitaVnum { get; set; }
        public string EppKey { get; set; }
        public string MerchantId { get; set; }
        public string EmailAddr { get; set; }
        public string EmailSmtp { get; set; }
        public decimal DefSurcharge { get; set; }
        public string AcctgTeller { get; set; }
        public short PasswordExpDays { get; set; }
        public short AuthCustDayLimit { get; set; }
        public short AuthIssDayLimit { get; set; }
        public short AppRenewalDays { get; set; }
        public byte ReqFieldsDaysLastLoan { get; set; }
        public bool PrintChkFeeNotice { get; set; }
        public DateTime? ChkFeeLastUpdate { get; set; }
        public byte ReceiptCopies { get; set; }
        public string ReceiptDunningMsg { get; set; }
        public string CurrVaultMgr { get; set; }
        public string SolomonId { get; set; }
        public bool SolomonTitleExists { get; set; }
        public string SolomonTitleId { get; set; }
        public bool IsSdnCustomer { get; set; }
        public bool IsSdnIssuer { get; set; }
        public string EmailTemplatePath { get; set; }
        public DateTime DateEntered { get; set; }
        public decimal Longitude { get; set; }
        public decimal Latitude { get; set; }
        public string StoreHours { get; set; }
        public bool IsSendEmail { get; set; }
        public bool EnableVerepay { get; set; }
        public string VerepayTerminalId { get; set; }
        public string VerepayStoreKey { get; set; }
        public bool IsCorporate { get; set; }
        public bool EnableStateDbReporting { get; set; }
        public bool SolomonNoncashExists { get; set; }
        public string SolomonNoncashId { get; set; }
        public string CountryCode { get; set; }
        public string BusinessState { get; set; }
        public short? DistrictKey { get; set; }
        public byte OptplusPayoutAsCash { get; set; }
        public bool EnableOptplus { get; set; }
        public string Address1 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string County { get; set; }
        public string Country { get; set; }
        public bool EnableCommidea { get; set; }
        public int? CommideaOciusAccount { get; set; }
        public bool EnableLaborModel { get; set; }
        public bool EnableAddressDr { get; set; }
        public string AddressFormat { get; set; }
        public string AddrStreet { get; set; }
        public string FlatNum { get; set; }
        public string BuildingNum { get; set; }
        public string BuildingName { get; set; }
        public string AddressLine { get; set; }
        public string AddressCsz { get; set; }
        public string AddressLine3 { get; set; }
        public short? CommideaLocationOverride { get; set; }
        public string AchUrl { get; set; }
        public byte YearsGoodAddress { get; set; }
        public byte ReqdPreviousAddressCount { get; set; }
        public bool EnableCurrencyExchange { get; set; }
        public string CrTeller { get; set; }
        public bool EnablePictures { get; set; }
        public short? RetakePictureDays { get; set; }
        public int BaseCurrencyKey { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public short IncomeVerificationDays { get; set; }
        public bool EnableIncomeCalculator { get; set; }
        public bool VerificationDocsRequired { get; set; }
        public int OptplusVersionWsconfigKey { get; set; }
        public string HpiUsername { get; set; }
        public string HpiPassword { get; set; }
        public bool EnableExperianDebitCardVerification { get; set; }
        public bool EnableDcardPaymentFee { get; set; }
        public decimal DcardPaymentFeeAmt { get; set; }
        public bool EnableEasypayWarehouse { get; set; }
        public decimal SalesTaxPercent { get; set; }
        public int AlternateLenderKey { get; set; }
        public bool EnableSelex { get; set; }
        public byte SelexPayout { get; set; }
        public bool EnableDcardFraudCheck { get; set; }
        public bool EnableCheckImaging { get; set; }
        public decimal GrossToNetIncomePct { get; set; }
        public string WesternUnionBillpayConnectorid { get; set; }
        public bool UseMoneygramMo { get; set; }
        public bool UseBlackbook { get; set; }
        public bool StoreIsOpen { get; set; }
        public int? CabLenderKey { get; set; }
        public bool EnableCapWithdrawal { get; set; }
        public bool EnableCurrencyExchangeRateChange { get; set; }
        public bool EnableTellerPwdSelfReset { get; set; }
        public string UtcOffset { get; set; }
        public string UtcDstOffset { get; set; }
        public string TimeZone { get; set; }
        public bool EnableCheckAmtVerify { get; set; }
        public bool EnableEsign { get; set; }
        public short AchCoolingOffPeriodDays { get; set; }
        public bool EnableRequiresJobType { get; set; }
        public bool IsAutoEod { get; set; }
        public bool IsSundayAutoSod { get; set; }
        public bool EnableCheckCashing { get; set; }
        public bool EnableMatchDuecycle { get; set; }
        public int AchGroupKey { get; set; }
        public int BoaClientId { get; set; }
        public short DaysBeforeCheckShred { get; set; }
        public bool EnablePrintCreditAvailable { get; set; }
        public string RepresentativeApr { get; set; }
        public bool EnablePhoneDeposits { get; set; }
        public bool EnableEpdq { get; set; }
        public bool EnableAdjustCustomerDueDateForHolidaysAndWeekends { get; set; }
        public bool CheckCashingGovtIdRequired { get; set; }
        public bool EnableOptplusLoanFunding { get; set; }
        public bool EnableMoneris { get; set; }
        public string MonerisStoreId { get; set; }
        public string MonerisApiToken { get; set; }
        public bool EnableMobileAppMsg { get; set; }
        public bool? EnableAvsValidationDeclines { get; set; }
        public string StoreNickname { get; set; }
        public bool EnableInternalAudit { get; set; }
        public DateTime? StoreOpenedDate { get; set; }
        public short CurrencyExchangeNonCustomerLimit { get; set; }
        public int? InterStoreArAcct { get; set; }
        public int? InterStoreApAcct { get; set; }
        public int? InterCoNoncashArAcct { get; set; }
        public int? InterCoNoncashApAcct { get; set; }
        public int? InterCoTitleArAcct { get; set; }
        public int? InterCoTitleApAcct { get; set; }
        public int? GlAcctGroupKey { get; set; }
        public bool ShowTitlePaidAtOtherLocations { get; set; }
        public bool EnableStoreCreditForInternetLoans { get; set; }
        public string BusinessEntity { get; set; }
        public bool EnableLoanPaymentPro { get; set; }
        public string LoanPaymentProSourceId { get; set; }
        public string LoanPaymentProSourceKey { get; set; }
        public string LoanPaymentProPin { get; set; }
        public bool EnableRepay { get; set; }
        public string RepayStoreId { get; set; }
        public string RepayUsername { get; set; }
        public string RepayPassword { get; set; }
        public short AimMinLoanRecords { get; set; }
        public short AimMinDmRecords { get; set; }
        public bool EnableCashedCheckBarcodePagePrint { get; set; }
        public short? LienAddressLocation { get; set; }
        public bool EnableTellerCashCount { get; set; }
        public bool UpdateOpenLoansWithNewCard { get; set; }
        public bool EnableStateNewAppRequired { get; set; }
        public bool EnableWireTransferMatching { get; set; }
        public short DaysToRerequestExpenses { get; set; }
        public bool EnableForeignAddresses { get; set; }
        public bool EnableServiceBox { get; set; }
        public bool EnableDecisionLogic { get; set; }
        public bool MaxCollectionsAttemptsPerRepresentmentEnabled { get; set; }
        public int MaxCollectionsAttemptsSpay { get; set; }
        public int MaxCollectionsAttemptsMpay { get; set; }
        public int MaxCollectionsAttemptsOend { get; set; }

        public virtual ICollection<AchbankConfigException> AchbankConfigException { get; set; }
        public virtual ICollection<AchHistory> AchHistory { get; set; }
        public virtual ICollection<AchHistoryCashedCheck> AchHistoryCashedCheck { get; set; }
        public virtual ICollection<AchSent> AchSent { get; set; }
        public virtual ICollection<CashedCheck> CashedCheck { get; set; }
        public virtual ICollection<CcardResponses> CcardResponses { get; set; }
        public virtual ICollection<CollectionAction> CollectionAction { get; set; }
        public virtual CompanyDetail CompanyDetail { get; set; }
        public virtual ICollection<CompanyDocumentResource> CompanyDocumentResource { get; set; }
        public virtual ICollection<CompanyExpenseType> CompanyExpenseType { get; set; }
        public virtual ICollection<CurrencyExchangeConfig> CurrencyExchangeConfig { get; set; }
        public virtual ICollection<CurrencyExchangeTrans> CurrencyExchangeTrans { get; set; }
        public virtual ICollection<CustomerDocument> CustomerDocument { get; set; }
        public virtual ICollection<CustomerFeedback> CustomerFeedback { get; set; }
        public virtual ICollection<CustomerLeadLocation> CustomerLeadLocation { get; set; }
        public virtual ICollection<DepositBag> DepositBag { get; set; }
        public virtual ICollection<DepositChk> DepositChk { get; set; }
        public virtual ICollection<DiscountLocations> DiscountLocations { get; set; }
        public virtual ICollection<ExcludeFromCapsHistory> ExcludeFromCapsHistory { get; set; }
        public virtual ICollection<FormLetterLocation> FormLetterLocation { get; set; }
        public virtual ICollection<GiftCard> GiftCard { get; set; }
        public virtual ICollection<GoldConfig> GoldConfig { get; set; }
        public virtual ICollection<GoldTrans> GoldTrans { get; set; }
        public virtual ICollection<ImageCashLetterDetail> ImageCashLetterDetail { get; set; }
        public virtual ICollection<IncomeTypeLocation> IncomeTypeLocation { get; set; }
        public virtual ICollection<IncomeVerifyMethodLocation> IncomeVerifyMethodLocation { get; set; }
        public virtual ICollection<Issuer> IssuerLocationNavigation { get; set; }
        public virtual ICollection<Issuer> IssuerTlocNavigation { get; set; }
        public virtual ICollection<Loan> LoanCreditedLocationNavigation { get; set; }
        public virtual ICollection<Loan> LoanLocationNavigation { get; set; }
        public virtual ICollection<LoanDueDateChange> LoanDueDateChange { get; set; }
        public virtual ICollection<LoanPayment> LoanPayment { get; set; }
        public virtual ICollection<LoanProductBlocked> LoanProductBlocked { get; set; }
        public virtual ICollection<LoanProductConfigLoanStats> LoanProductConfigLoanStats { get; set; }
        public virtual ICollection<LoanProductEnableNewLoan> LoanProductEnableNewLoanLienAddressLocationNavigation { get; set; }
        public virtual ICollection<LoanProductEnableNewLoan> LoanProductEnableNewLoanLocationNavigation { get; set; }
        public virtual ICollection<LoanProductRollover> LoanProductRollover { get; set; }
        public virtual ICollection<LocationUsZipcodesXref> LocationUsZipcodesXref { get; set; }
        public virtual ICollection<PhoneSkillsCall> PhoneSkillsCall { get; set; }
        public virtual ICollection<PrepaidCardBinCompany> PrepaidCardBinCompany { get; set; }
        public virtual ICollection<PrepaidCardTrans> PrepaidCardTrans { get; set; }
        public virtual ICollection<ProductOpenLoanMatrix> ProductOpenLoanMatrix { get; set; }
        public virtual ICollection<Risrept> Risrept { get; set; }
        public virtual ICollection<SkipTraceStepLocation> SkipTraceStepLocation { get; set; }
        public virtual ICollection<TitleLoan> TitleLoan { get; set; }
        public virtual ICollection<VaultMgrAssignment> VaultMgrAssignment { get; set; }
        public virtual ICollection<VaultMgrAuthorization> VaultMgrAuthorization { get; set; }
        public virtual ICollection<Vehicle> Vehicle { get; set; }
        public virtual ICollection<WebLoanCreditFraud> WebLoanCreditFraud { get; set; }
        public virtual AlternateLender AlternateLenderKeyNavigation { get; set; }
        public virtual Currency BaseCurrencyKeyNavigation { get; set; }
        public virtual UsStates BusinessStateNavigation { get; set; }
        public virtual GlobalStates BusinessState1 { get; set; }
        public virtual Cablender CabLenderKeyNavigation { get; set; }
        public virtual GlacctGroup GlAcctGroupKeyNavigation { get; set; }
        public virtual Glacct InterCoNoncashApAcctNavigation { get; set; }
        public virtual Glacct InterCoNoncashArAcctNavigation { get; set; }
        public virtual Glacct InterCoTitleApAcctNavigation { get; set; }
        public virtual Glacct InterCoTitleArAcctNavigation { get; set; }
        public virtual Glacct InterStoreApAcctNavigation { get; set; }
        public virtual Glacct InterStoreArAcctNavigation { get; set; }
        public virtual Markets MarketKeyNavigation { get; set; }
    }
}
