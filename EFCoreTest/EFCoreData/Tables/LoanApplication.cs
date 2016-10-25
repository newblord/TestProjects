using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LoanApplication
    {
        public LoanApplication()
        {
            CustomerLead = new HashSet<CustomerLead>();
            ErrorLog = new HashSet<ErrorLog>();
            ExperianCardValidation = new HashSet<ExperianCardValidation>();
            FurtherFinanceExecutionLog = new HashSet<FurtherFinanceExecutionLog>();
            FurtherFinanceResult = new HashSet<FurtherFinanceResult>();
            LoanApplicationAddress = new HashSet<LoanApplicationAddress>();
            LoanApplicationIncome = new HashSet<LoanApplicationIncome>();
            LoanApplicationProduct = new HashSet<LoanApplicationProduct>();
            LoanApplicationVehicleInformation = new HashSet<LoanApplicationVehicleInformation>();
            PayStub = new HashSet<PayStub>();
            Smsinbound = new HashSet<Smsinbound>();
            Smsoutbound = new HashSet<Smsoutbound>();
            VisitorEmail = new HashSet<VisitorEmail>();
            WebBlobLoanApplicationXref = new HashSet<WebBlobLoanApplicationXref>();
            WebCallQueue = new HashSet<WebCallQueue>();
            WebCallWorkQueue = new HashSet<WebCallWorkQueue>();
            WebErrorLog = new HashSet<WebErrorLog>();
            WebImage = new HashSet<WebImage>();
            WebPixelVendorData = new HashSet<WebPixelVendorData>();
            WebVisit = new HashSet<WebVisit>();
            WebVisitSource = new HashSet<WebVisitSource>();
        }

        public int LoanApplicationKey { get; set; }
        public byte LenderKey { get; set; }
        public short Location { get; set; }
        public int? CustomerKey { get; set; }
        public int? VisitorKey { get; set; }
        public int? LoanKey { get; set; }
        public string FirstName { get; set; }
        public string MidName { get; set; }
        public string LastName { get; set; }
        public string HomePhone { get; set; }
        public string CellPhone { get; set; }
        public string Ssn { get; set; }
        public string AbaNum { get; set; }
        public string AcctNum { get; set; }
        public decimal ReqCashAmt { get; set; }
        public string CcardNum { get; set; }
        public string CcardCvv { get; set; }
        public byte CcardExpMonth { get; set; }
        public short CcardExpYear { get; set; }
        public bool CcardIsDebit { get; set; }
        public string CcardNameOnCard { get; set; }
        public string Language { get; set; }
        public int Status { get; set; }
        public string ReasonDenied { get; set; }
        public DateTime? NextPayDate { get; set; }
        public string Teller { get; set; }
        public string IdNo { get; set; }
        public string SpouseFirstName { get; set; }
        public string SpouseMidName { get; set; }
        public string SpouseLastName { get; set; }
        public string SpouseSsn { get; set; }
        public string SpouseHomePhone { get; set; }
        public string SpouseCellPhone { get; set; }
        public string SpouseWorkName { get; set; }
        public string SpouseWorkPhone { get; set; }
        public string SpouseWorkPhoneExt { get; set; }
        public string Gender { get; set; }
        public bool? Bounced { get; set; }
        public string HowRefObsolete { get; set; }
        public string Email { get; set; }
        public string Ref1FirstName { get; set; }
        public string Ref1LastName { get; set; }
        public string Ref1Phone { get; set; }
        public string Ref1Relationship { get; set; }
        public string Ref2FirstName { get; set; }
        public string Ref2LastName { get; set; }
        public string Ref2Phone { get; set; }
        public string Ref2Relationship { get; set; }
        public decimal? RiBalance { get; set; }
        public DateTime? RiFollowup { get; set; }
        public byte? OwnRentOther { get; set; }
        public DateTime? ResidenceSince { get; set; }
        public string LegalNumber { get; set; }
        public string CourtesyCallNum { get; set; }
        public string CustIdNum { get; set; }
        public string CustIdSource { get; set; }
        public string CustIdVerifyOther { get; set; }
        public bool? ActiveMilitary { get; set; }
        public bool? MilitaryMember { get; set; }
        public bool? MilitaryActiveDuty { get; set; }
        public bool? MilitaryCombatDuty { get; set; }
        public bool? MilitaryReserveNotActive { get; set; }
        public bool? MilitaryReserveActive { get; set; }
        public decimal? MonthlyHousing { get; set; }
        public bool? InetApproved { get; set; }
        public bool? CcBlock { get; set; }
        public DateTime? Dob { get; set; }
        public string SourceApp { get; set; }
        public DateTime DateEntered { get; set; }
        public string SourceDb { get; set; }
        public int WebReferralMethodKeyObsolete { get; set; }
        public byte CcCount { get; set; }
        public string IpAddress { get; set; }
        public byte MaritalStatus { get; set; }
        public bool? JointLoan { get; set; }
        public short ReferralMethodKey { get; set; }
        public int? PennyAuthKey { get; set; }
        public string VehMake { get; set; }
        public string VehModel { get; set; }
        public short? VehYear { get; set; }
        public string VehVin { get; set; }
        public string VehLienHolderName { get; set; }
        public decimal? VehLienBalance { get; set; }
        public bool? VehLeased { get; set; }
        public bool? ArbitrationOptIn { get; set; }
        public decimal? CcardGuaranteeAmt { get; set; }
        public string CcardToken { get; set; }
        public string FundingType { get; set; }
        public DateTime? CcardFromDate { get; set; }
        public byte? CcardIssueNum { get; set; }
        public byte CcardBrand { get; set; }
        public byte CcardType { get; set; }
        public bool IsEpdqOnly { get; set; }
        public int Title { get; set; }
        public int? CustIdTypeKey { get; set; }
        public DateTime? CustIdExpDate { get; set; }
        public string CustIdCountry { get; set; }
        public string CustIdState { get; set; }
        public int? CustIdVerifyKey { get; set; }
        public short? Dependents { get; set; }
        public DateTime? CancelInsuranceRequestDate { get; set; }
        public string CancelInsuranceRequestBy { get; set; }

        public virtual ICollection<CustomerLead> CustomerLead { get; set; }
        public virtual DocumentSigningStatus DocumentSigningStatus { get; set; }
        public virtual ICollection<ErrorLog> ErrorLog { get; set; }
        public virtual ICollection<ExperianCardValidation> ExperianCardValidation { get; set; }
        public virtual ICollection<FurtherFinanceExecutionLog> FurtherFinanceExecutionLog { get; set; }
        public virtual ICollection<FurtherFinanceResult> FurtherFinanceResult { get; set; }
        public virtual ICollection<LoanApplicationAddress> LoanApplicationAddress { get; set; }
        public virtual LoanApplicationAffordSurveyToBeDeleted LoanApplicationAffordSurveyToBeDeleted { get; set; }
        public virtual LoanApplicationExpense LoanApplicationExpense { get; set; }
        public virtual ICollection<LoanApplicationIncome> LoanApplicationIncome { get; set; }
        public virtual ICollection<LoanApplicationProduct> LoanApplicationProduct { get; set; }
        public virtual ICollection<LoanApplicationVehicleInformation> LoanApplicationVehicleInformation { get; set; }
        public virtual ICollection<PayStub> PayStub { get; set; }
        public virtual ICollection<Smsinbound> Smsinbound { get; set; }
        public virtual ICollection<Smsoutbound> Smsoutbound { get; set; }
        public virtual ICollection<VisitorEmail> VisitorEmail { get; set; }
        public virtual ICollection<WebBlobLoanApplicationXref> WebBlobLoanApplicationXref { get; set; }
        public virtual ICollection<WebCallQueue> WebCallQueue { get; set; }
        public virtual ICollection<WebCallWorkQueue> WebCallWorkQueue { get; set; }
        public virtual ICollection<WebErrorLog> WebErrorLog { get; set; }
        public virtual ICollection<WebImage> WebImage { get; set; }
        public virtual ICollection<WebPixelVendorData> WebPixelVendorData { get; set; }
        public virtual ICollection<WebVisit> WebVisit { get; set; }
        public virtual ICollection<WebVisitSource> WebVisitSource { get; set; }
        public virtual IdentificationTypeVerify CustIdVerifyKeyNavigation { get; set; }
        public virtual Customer CustomerKeyNavigation { get; set; }
        public virtual Lender LenderKeyNavigation { get; set; }
        public virtual Loan LoanKeyNavigation { get; set; }
        public virtual CreditCardTrans PennyAuthKeyNavigation { get; set; }
        public virtual ReferralMethod ReferralMethodKeyNavigation { get; set; }
        public virtual PersonTitle TitleNavigation { get; set; }
        public virtual Visitor VisitorKeyNavigation { get; set; }
    }
}
