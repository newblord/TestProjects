using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class Visitor
    {
        public Visitor()
        {
            Amloccupation = new HashSet<Amloccupation>();
            LoanApplication = new HashSet<LoanApplication>();
            LoanApplicationAffordSurveyToBeDeleted = new HashSet<LoanApplicationAffordSurveyToBeDeleted>();
            LoanApplicationExpense = new HashSet<LoanApplicationExpense>();
            Oowsession = new HashSet<Oowsession>();
            OptInOut = new HashSet<OptInOut>();
            PayStub = new HashSet<PayStub>();
            Smsinbound = new HashSet<Smsinbound>();
            Smsoutbound = new HashSet<Smsoutbound>();
            VisitorApiAuthorization = new HashSet<VisitorApiAuthorization>();
            VisitorDevice = new HashSet<VisitorDevice>();
            VisitorEdit = new HashSet<VisitorEdit>();
            VisitorEmail = new HashSet<VisitorEmail>();
            VisitorHistory = new HashSet<VisitorHistory>();
            WebCallAuthorizedVisitorContact = new HashSet<WebCallAuthorizedVisitorContact>();
            WebCallQueue = new HashSet<WebCallQueue>();
            WebCallWorkQueue = new HashSet<WebCallWorkQueue>();
            WebErrorLog = new HashSet<WebErrorLog>();
            WebVisit = new HashSet<WebVisit>();
            WebVisitSource = new HashSet<WebVisitSource>();
            ZeroDollarAuth = new HashSet<ZeroDollarAuth>();
        }

        public int VisitorKey { get; set; }
        public byte LenderKey { get; set; }
        public string EmailAddr { get; set; }
        public string Password { get; set; }
        public bool IsPasswordSysGen { get; set; }
        public int SigninCount { get; set; }
        public string VStatusId { get; set; }
        public DateTime DateEntered { get; set; }
        public DateTime? LastUpdated { get; set; }
        public byte FailedLoginCount { get; set; }
        public DateTime? LastLogin { get; set; }
        public DateTime? LastFailedLogin { get; set; }
        public int? VisitorSecurityQuestionKey { get; set; }
        public string SecurityAnswer { get; set; }
        public int EmailDeliveryFailureCount { get; set; }
        public DateTime EmailDeliveryFailureDate { get; set; }
        public bool InvalidEmail { get; set; }
        public bool EmailDeleted { get; set; }
        public DateTime? EmailDeletedDate { get; set; }
        public string EmailDeletedBy { get; set; }
        public bool Blocked { get; set; }
        public string Teller { get; set; }
        public string AccessId { get; set; }
        public string AccessPassword { get; set; }
        public int? BlockReasonKey { get; set; }
        public byte PasswordType { get; set; }
        public string Salt { get; set; }
        public byte OowStatus { get; set; }
        public DateTime? OowDate { get; set; }

        public virtual ICollection<Amloccupation> Amloccupation { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<LoanApplication> LoanApplication { get; set; }
        public virtual ICollection<LoanApplicationAffordSurveyToBeDeleted> LoanApplicationAffordSurveyToBeDeleted { get; set; }
        public virtual ICollection<LoanApplicationExpense> LoanApplicationExpense { get; set; }
        public virtual ICollection<Oowsession> Oowsession { get; set; }
        public virtual ICollection<OptInOut> OptInOut { get; set; }
        public virtual ICollection<PayStub> PayStub { get; set; }
        public virtual ICollection<Smsinbound> Smsinbound { get; set; }
        public virtual ICollection<Smsoutbound> Smsoutbound { get; set; }
        public virtual ICollection<VisitorApiAuthorization> VisitorApiAuthorization { get; set; }
        public virtual ICollection<VisitorDevice> VisitorDevice { get; set; }
        public virtual ICollection<VisitorEdit> VisitorEdit { get; set; }
        public virtual ICollection<VisitorEmail> VisitorEmail { get; set; }
        public virtual ICollection<VisitorHistory> VisitorHistory { get; set; }
        public virtual ICollection<WebCallAuthorizedVisitorContact> WebCallAuthorizedVisitorContact { get; set; }
        public virtual ICollection<WebCallQueue> WebCallQueue { get; set; }
        public virtual ICollection<WebCallWorkQueue> WebCallWorkQueue { get; set; }
        public virtual ICollection<WebErrorLog> WebErrorLog { get; set; }
        public virtual ICollection<WebVisit> WebVisit { get; set; }
        public virtual ICollection<WebVisitSource> WebVisitSource { get; set; }
        public virtual ICollection<ZeroDollarAuth> ZeroDollarAuth { get; set; }
        public virtual BlockReason BlockReasonKeyNavigation { get; set; }
        public virtual Lender LenderKeyNavigation { get; set; }
        public virtual VisitorSecurityQuestion VisitorSecurityQuestionKeyNavigation { get; set; }
    }
}
