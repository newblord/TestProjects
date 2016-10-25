using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class Customer
    {
        public Customer()
        {
            AchHistory = new HashSet<AchHistory>();
            AchHistoryCashedCheck = new HashSet<AchHistoryCashedCheck>();
            Achpending = new HashSet<Achpending>();
            AmlforeignAddress = new HashSet<AmlforeignAddress>();
            BlockMailing = new HashSet<BlockMailing>();
            CashedCheck = new HashSet<CashedCheck>();
            CashMoneyToCuroXref = new HashSet<CashMoneyToCuroXref>();
            CcardResponse = new HashSet<CcardResponse>();
            CcardResponses = new HashSet<CcardResponses>();
            CollectionNote = new HashSet<CollectionNote>();
            CourtesyPayout = new HashSet<CourtesyPayout>();
            CpiuDetail = new HashSet<CpiuDetail>();
            CreditCards = new HashSet<CreditCards>();
            CreditCardTrans = new HashSet<CreditCardTrans>();
            CreditCardXref = new HashSet<CreditCardXref>();
            CustomerActivity = new HashSet<CustomerActivity>();
            CustomerAddress = new HashSet<CustomerAddress>();
            CustomerBusiness = new HashSet<CustomerBusiness>();
            CustomerCreditRpt = new HashSet<CustomerCreditRpt>();
            CustomerDocument = new HashSet<CustomerDocument>();
            CustomerEarnedCredit = new HashSet<CustomerEarnedCredit>();
            CustomerEdit = new HashSet<CustomerEdit>();
            CustomerEmployer = new HashSet<CustomerEmployer>();
            CustomerExpense = new HashSet<CustomerExpense>();
            CustomerFeedback = new HashSet<CustomerFeedback>();
            CustomerFlashResponse = new HashSet<CustomerFlashResponse>();
            CustomerIdentification = new HashSet<CustomerIdentification>();
            CustomerIncome = new HashSet<CustomerIncome>();
            CustomerLastCreditReport = new HashSet<CustomerLastCreditReport>();
            CustomerNote = new HashSet<CustomerNote>();
            CustomerPhoneNumber = new HashSet<CustomerPhoneNumber>();
            DepositBagDetail = new HashSet<DepositBagDetail>();
            DepositChkDetail = new HashSet<DepositChkDetail>();
            Doc10000Trans = new HashSet<Doc10000Trans>();
            ErrorLog = new HashSet<ErrorLog>();
            ExperianCardValidation = new HashSet<ExperianCardValidation>();
            FormLetterPrinted = new HashSet<FormLetterPrinted>();
            FormLetterResult = new HashSet<FormLetterResult>();
            GoldTransCustomer = new HashSet<GoldTransCustomer>();
            GoodCustomerStudy = new HashSet<GoodCustomerStudy>();
            Issuer = new HashSet<Issuer>();
            Loan = new HashSet<Loan>();
            LoanApplication = new HashSet<LoanApplication>();
            LoanApplicationVehicleInformation = new HashSet<LoanApplicationVehicleInformation>();
            LoanDueDateChange = new HashSet<LoanDueDateChange>();
            LoanNote = new HashSet<LoanNote>();
            MetroIibaseSegment = new HashSet<MetroIibaseSegment>();
            OptPlusDirectDeposit = new HashSet<OptPlusDirectDeposit>();
            OptPlusEdit = new HashSet<OptPlusEdit>();
            OptPlusEmployment = new HashSet<OptPlusEmployment>();
            OptPlusRdfaccountCard = new HashSet<OptPlusRdfaccountCard>();
            OptPlusRdfauthorizedTransactions = new HashSet<OptPlusRdfauthorizedTransactions>();
            OptPlusRdfcustomerMaster = new HashSet<OptPlusRdfcustomerMaster>();
            OptPlusRdfodtransition = new HashSet<OptPlusRdfodtransition>();
            OptPlusRdfpostedTrans = new HashSet<OptPlusRdfpostedTrans>();
            PaydayLoanQualification = new HashSet<PaydayLoanQualification>();
            PrepaidCardTrans = new HashSet<PrepaidCardTrans>();
            PrepaidFisaccountBalance = new HashSet<PrepaidFisaccountBalance>();
            PrepaidFisauthTrans = new HashSet<PrepaidFisauthTrans>();
            PrepaidFiscustomerMaster = new HashSet<PrepaidFiscustomerMaster>();
            PrepaidFispostedTrans = new HashSet<PrepaidFispostedTrans>();
            PromiseToPay = new HashSet<PromiseToPay>();
            RbcEfundBatchDetail = new HashSet<RbcEfundBatchDetail>();
            RiagingHistory = new HashSet<RiagingHistory>();
            Risrept = new HashSet<Risrept>();
            ServiceTrans = new HashSet<ServiceTrans>();
            SkipTraceThread = new HashSet<SkipTraceThread>();
            SpaySchedRollover = new HashSet<SpaySchedRollover>();
            TitleLoan = new HashSet<TitleLoan>();
            TransPos = new HashSet<TransPos>();
            VaultMgrAuthorizationDetail = new HashSet<VaultMgrAuthorizationDetail>();
            VehicleHistory = new HashSet<VehicleHistory>();
            WebCallQueue = new HashSet<WebCallQueue>();
            WebCallWorkQueue = new HashSet<WebCallWorkQueue>();
            WebErrorLog = new HashSet<WebErrorLog>();
            WebLead = new HashSet<WebLead>();
            WebLoanCreditFraud = new HashSet<WebLoanCreditFraud>();
        }

        public int CustomerKey { get; set; }
        public short Location { get; set; }
        public string Teller { get; set; }
        public DateTime DateEntered { get; set; }
        public short? Tloc { get; set; }
        public string Tupt { get; set; }
        public DateTime? Tupd { get; set; }
        public string Ssn { get; set; }
        public string IdNo { get; set; }
        public string Firstname { get; set; }
        public string Midname { get; set; }
        public string Lastname { get; set; }
        public string HomeAddrNum { get; set; }
        public string HomeAddrPreDir { get; set; }
        public string HomeAddrStreet { get; set; }
        public string HomeAddrSuffix { get; set; }
        public string HomeAddrSuite { get; set; }
        public string HomeAddrSuiteNum { get; set; }
        public string County { get; set; }
        public string HomePhone { get; set; }
        public string CellPhone { get; set; }
        public string WorkPhone { get; set; }
        public string WorkPhoneExt { get; set; }
        public string SpouseFirstname { get; set; }
        public string SpouseMidname { get; set; }
        public string SpouseLastname { get; set; }
        public string SpouseSsn { get; set; }
        public string SpouseWorkName { get; set; }
        public string SpouseWorkPhone { get; set; }
        public string SpouseWorkPhoneExt { get; set; }
        public bool? SpouseDirDep { get; set; }
        public string SpousePaycycle { get; set; }
        public DateTime? Dob { get; set; }
        public string Gender { get; set; }
        public decimal Cklimit { get; set; }
        public decimal Pralimit { get; set; }
        public string Util1 { get; set; }
        public string Util2 { get; set; }
        public string Util3 { get; set; }
        public bool? Bounced { get; set; }
        public string HowRefObsolete { get; set; }
        public string EmailObsolete { get; set; }
        public string Ref1Firstname { get; set; }
        public string Ref1Lastname { get; set; }
        public string Ref1Phone { get; set; }
        public string Ref1Relationship { get; set; }
        public string Ref2Firstname { get; set; }
        public string Ref2Lastname { get; set; }
        public string Ref2Phone { get; set; }
        public string Ref2Relationship { get; set; }
        public bool? NewCustRef { get; set; }
        public int? NewCustRefId { get; set; }
        public string PayCycle { get; set; }
        public byte PayCycleDay { get; set; }
        public byte PayCycle1st { get; set; }
        public byte PayCycle2nd { get; set; }
        public DateTime? BiweekBase { get; set; }
        public string PayCycleMonthInt { get; set; }
        public DateTime? CalcPayDate { get; set; }
        public DateTime? PayCycleUpdated { get; set; }
        public string PayCycleUpdatedBy { get; set; }
        public string AchStatus { get; set; }
        public decimal RiBalance { get; set; }
        public DateTime? RiFollowup { get; set; }
        public int CreditScore { get; set; }
        public DateTime? LastScoreDate { get; set; }
        public byte OwnRentOther { get; set; }
        public DateTime? ResidenceSince { get; set; }
        public DateTime? LastAppDate { get; set; }
        public string LegalNumber { get; set; }
        public bool AcctBlocked { get; set; }
        public string CourtesyCallNum { get; set; }
        public int? LastAchResult { get; set; }
        public bool ActiveMilitary { get; set; }
        public string CustIdSource { get; set; }
        public bool? MilitaryMember { get; set; }
        public bool? MilActiveDuty { get; set; }
        public bool? MilCombatDuty { get; set; }
        public bool? MilReserveNotActive { get; set; }
        public bool? MilReserveActive { get; set; }
        public DateTime? ChkCashingFeeNoticeDate { get; set; }
        public short? ChkCashingFeeNoticeLocation { get; set; }
        public string SpouseHomePhone { get; set; }
        public string SpouseCellPhone { get; set; }
        public bool? InetApproved { get; set; }
        public bool CcBlock { get; set; }
        public byte? AcctBlockedCode { get; set; }
        public string HomeAddrPostDir { get; set; }
        public short ReferralMethodKey { get; set; }
        public DateTime EmailVerifyDate { get; set; }
        public byte EmailLastResponse { get; set; }
        public string OriginalWebVisitSource { get; set; }
        public string HomeCountry { get; set; }
        public string Nin { get; set; }
        public int? OptplusCarrierKey { get; set; }
        public string OriginalPrn { get; set; }
        public string OptplusAccountId { get; set; }
        public string HomeCity { get; set; }
        public string HomeState { get; set; }
        public string HomeZipcode { get; set; }
        public string HomeCounty { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string AddressFormat { get; set; }
        public string HomeFlatNum { get; set; }
        public string HomeBuildingNum { get; set; }
        public string HomeBuildingName { get; set; }
        public string HomeAddressLine { get; set; }
        public string HomeAddressCsz { get; set; }
        public string HomeAddressLine3 { get; set; }
        public bool? OptplusCipDenial { get; set; }
        public string HomeAddressLine1 { get; set; }
        public string HomeAddressLine2 { get; set; }
        public bool PayCycleCountDaysFromEndOfMonth { get; set; }
        public bool MismatchedDuecycleApproved { get; set; }
        public byte AdjustDueDateForHolidaysAndWeekendsMethod { get; set; }
        public int Title { get; set; }
        public string Nickname { get; set; }
        public int VisitorKey { get; set; }
        public int PayInfoComplete { get; set; }
        public string PreferredLanguage { get; set; }
        public bool IsInChain { get; set; }
        public short? Dependents { get; set; }
        public byte MaritalStatus { get; set; }

        public virtual ICollection<AchHistory> AchHistory { get; set; }
        public virtual ICollection<AchHistoryCashedCheck> AchHistoryCashedCheck { get; set; }
        public virtual ICollection<Achpending> Achpending { get; set; }
        public virtual ICollection<AmlforeignAddress> AmlforeignAddress { get; set; }
        public virtual ICollection<BlockMailing> BlockMailing { get; set; }
        public virtual ICollection<CashedCheck> CashedCheck { get; set; }
        public virtual ICollection<CashMoneyToCuroXref> CashMoneyToCuroXref { get; set; }
        public virtual ICollection<CcardResponse> CcardResponse { get; set; }
        public virtual ICollection<CcardResponses> CcardResponses { get; set; }
        public virtual ICollection<CollectionNote> CollectionNote { get; set; }
        public virtual ICollection<CourtesyPayout> CourtesyPayout { get; set; }
        public virtual ICollection<CpiuDetail> CpiuDetail { get; set; }
        public virtual ICollection<CreditCards> CreditCards { get; set; }
        public virtual ICollection<CreditCardTrans> CreditCardTrans { get; set; }
        public virtual ICollection<CreditCardXref> CreditCardXref { get; set; }
        public virtual ICollection<CustomerActivity> CustomerActivity { get; set; }
        public virtual ICollection<CustomerAddress> CustomerAddress { get; set; }
        public virtual ICollection<CustomerBusiness> CustomerBusiness { get; set; }
        public virtual ICollection<CustomerCreditRpt> CustomerCreditRpt { get; set; }
        public virtual ICollection<CustomerDocument> CustomerDocument { get; set; }
        public virtual ICollection<CustomerEarnedCredit> CustomerEarnedCredit { get; set; }
        public virtual ICollection<CustomerEdit> CustomerEdit { get; set; }
        public virtual ICollection<CustomerEmployer> CustomerEmployer { get; set; }
        public virtual ICollection<CustomerExpense> CustomerExpense { get; set; }
        public virtual ICollection<CustomerFeedback> CustomerFeedback { get; set; }
        public virtual ICollection<CustomerFlashResponse> CustomerFlashResponse { get; set; }
        public virtual ICollection<CustomerIdentification> CustomerIdentification { get; set; }
        public virtual ICollection<CustomerIncome> CustomerIncome { get; set; }
        public virtual ICollection<CustomerLastCreditReport> CustomerLastCreditReport { get; set; }
        public virtual ICollection<CustomerNote> CustomerNote { get; set; }
        public virtual ICollection<CustomerPhoneNumber> CustomerPhoneNumber { get; set; }
        public virtual ICollection<DepositBagDetail> DepositBagDetail { get; set; }
        public virtual ICollection<DepositChkDetail> DepositChkDetail { get; set; }
        public virtual ICollection<Doc10000Trans> Doc10000Trans { get; set; }
        public virtual ICollection<ErrorLog> ErrorLog { get; set; }
        public virtual ICollection<ExperianCardValidation> ExperianCardValidation { get; set; }
        public virtual ICollection<FormLetterPrinted> FormLetterPrinted { get; set; }
        public virtual ICollection<FormLetterResult> FormLetterResult { get; set; }
        public virtual FurtherFinanceResult FurtherFinanceResult { get; set; }
        public virtual ICollection<GoldTransCustomer> GoldTransCustomer { get; set; }
        public virtual ICollection<GoodCustomerStudy> GoodCustomerStudy { get; set; }
        public virtual ICollection<Issuer> Issuer { get; set; }
        public virtual ICollection<Loan> Loan { get; set; }
        public virtual ICollection<LoanApplication> LoanApplication { get; set; }
        public virtual ICollection<LoanApplicationVehicleInformation> LoanApplicationVehicleInformation { get; set; }
        public virtual ICollection<LoanDueDateChange> LoanDueDateChange { get; set; }
        public virtual ICollection<LoanNote> LoanNote { get; set; }
        public virtual ICollection<MetroIibaseSegment> MetroIibaseSegment { get; set; }
        public virtual ICollection<OptPlusDirectDeposit> OptPlusDirectDeposit { get; set; }
        public virtual ICollection<OptPlusEdit> OptPlusEdit { get; set; }
        public virtual ICollection<OptPlusEmployment> OptPlusEmployment { get; set; }
        public virtual ICollection<OptPlusRdfaccountCard> OptPlusRdfaccountCard { get; set; }
        public virtual ICollection<OptPlusRdfauthorizedTransactions> OptPlusRdfauthorizedTransactions { get; set; }
        public virtual ICollection<OptPlusRdfcustomerMaster> OptPlusRdfcustomerMaster { get; set; }
        public virtual ICollection<OptPlusRdfodtransition> OptPlusRdfodtransition { get; set; }
        public virtual ICollection<OptPlusRdfpostedTrans> OptPlusRdfpostedTrans { get; set; }
        public virtual ICollection<PaydayLoanQualification> PaydayLoanQualification { get; set; }
        public virtual ICollection<PrepaidCardTrans> PrepaidCardTrans { get; set; }
        public virtual ICollection<PrepaidFisaccountBalance> PrepaidFisaccountBalance { get; set; }
        public virtual ICollection<PrepaidFisauthTrans> PrepaidFisauthTrans { get; set; }
        public virtual ICollection<PrepaidFiscustomerMaster> PrepaidFiscustomerMaster { get; set; }
        public virtual ICollection<PrepaidFispostedTrans> PrepaidFispostedTrans { get; set; }
        public virtual ICollection<PromiseToPay> PromiseToPay { get; set; }
        public virtual ICollection<RbcEfundBatchDetail> RbcEfundBatchDetail { get; set; }
        public virtual ICollection<RiagingHistory> RiagingHistory { get; set; }
        public virtual ICollection<Risrept> Risrept { get; set; }
        public virtual ICollection<ServiceTrans> ServiceTrans { get; set; }
        public virtual ICollection<SkipTraceThread> SkipTraceThread { get; set; }
        public virtual ICollection<SpaySchedRollover> SpaySchedRollover { get; set; }
        public virtual ICollection<TitleLoan> TitleLoan { get; set; }
        public virtual ICollection<TransPos> TransPos { get; set; }
        public virtual ICollection<VaultMgrAuthorizationDetail> VaultMgrAuthorizationDetail { get; set; }
        public virtual ICollection<VehicleHistory> VehicleHistory { get; set; }
        public virtual ICollection<WebCallQueue> WebCallQueue { get; set; }
        public virtual ICollection<WebCallWorkQueue> WebCallWorkQueue { get; set; }
        public virtual ICollection<WebErrorLog> WebErrorLog { get; set; }
        public virtual ICollection<WebLead> WebLead { get; set; }
        public virtual ICollection<WebLoanCreditFraud> WebLoanCreditFraud { get; set; }
        public virtual UsStates HomeStateNavigation { get; set; }
        public virtual OptPlusCarrier OptplusCarrierKeyNavigation { get; set; }
        public virtual WebVisitSource OriginalWebVisitSourceNavigation { get; set; }
        public virtual ReferralMethod ReferralMethodKeyNavigation { get; set; }
        public virtual PersonTitle TitleNavigation { get; set; }
        public virtual Visitor VisitorKeyNavigation { get; set; }
    }
}
