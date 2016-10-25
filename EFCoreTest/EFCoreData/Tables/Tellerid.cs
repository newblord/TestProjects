using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class Tellerid
    {
        public Tellerid()
        {
            Achqueue = new HashSet<Achqueue>();
            AmlfileLog = new HashSet<AmlfileLog>();
            BalSheet2 = new HashSet<BalSheet2>();
            CcardResponses = new HashSet<CcardResponses>();
            CpiuMaster = new HashSet<CpiuMaster>();
            CreditCardTrans = new HashSet<CreditCardTrans>();
            CustomerFlashResponse = new HashSet<CustomerFlashResponse>();
            DocumentResourceCreatedByNavigation = new HashSet<DocumentResource>();
            DocumentResourceUpdatedByNavigation = new HashSet<DocumentResource>();
            EoscarBatch = new HashSet<EoscarBatch>();
            ExcludeFromCapsHistory = new HashSet<ExcludeFromCapsHistory>();
            IssuerTlrNavigation = new HashSet<Issuer>();
            IssuerTuptNavigation = new HashSet<Issuer>();
            ProcessConfigInstanceTeller = new HashSet<ProcessConfigInstanceTeller>();
            PurchaseService = new HashSet<PurchaseService>();
            ReasonForArrears = new HashSet<ReasonForArrears>();
            RiagingHistory = new HashSet<RiagingHistory>();
            Ris = new HashSet<Ris>();
            RisreptManualTellerNavigation = new HashSet<Risrept>();
            RisreptTlrNavigation = new HashSet<Risrept>();
            RiUrgentNote = new HashSet<RiUrgentNote>();
            SecurityAnswer = new HashSet<SecurityAnswer>();
            SpecialMessage = new HashSet<SpecialMessage>();
            TellerComputer = new HashSet<TellerComputer>();
            TellerPwdHistory = new HashSet<TellerPwdHistory>();
            TellerSecurity = new HashSet<TellerSecurity>();
            TransDetail = new HashSet<TransDetail>();
            TransferFunds = new HashSet<TransferFunds>();
            TransPos = new HashSet<TransPos>();
            VaultCount = new HashSet<VaultCount>();
        }

        public string Teller { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Lstname { get; set; }
        public DateTime? LastLogin { get; set; }
        public short Location { get; set; }
        public int SecuritygroupKey { get; set; }
        public DateTime? LastPwchg { get; set; }
        public string Rsapassword { get; set; }
        public string SwipeId { get; set; }
        public bool DisplayReleaseInfo { get; set; }
        public string Ssn { get; set; }
        public string AdpId { get; set; }
        public bool AuditRequired { get; set; }
        public DateTime? HireDate { get; set; }
        public DateTime? CertDate { get; set; }
        public string CertBy { get; set; }
        public short LastLocation { get; set; }
        public bool AccountLocked { get; set; }
        public byte Attempts { get; set; }
        public int TellerIdKey { get; set; }
        public int? LastSelectedCustomerKey { get; set; }
        public int? LastSelectedLoanKey { get; set; }
        public string LocationListviewColumns { get; set; }
        public string LocationListviewColumnWidths { get; set; }
        public string LocationListviewSort { get; set; }
        public bool ShowOpsNews { get; set; }
        public byte QuestionAttempts { get; set; }
        public byte TellerType { get; set; }
        public int? TitleKey { get; set; }
        public string SamAccountName { get; set; }
        public DateTime? CashcountStartDate { get; set; }
        public DateTime? CashcountEndDate { get; set; }

        public virtual ICollection<Achqueue> Achqueue { get; set; }
        public virtual ICollection<AmlfileLog> AmlfileLog { get; set; }
        public virtual ICollection<BalSheet2> BalSheet2 { get; set; }
        public virtual ICollection<CcardResponses> CcardResponses { get; set; }
        public virtual ICollection<CpiuMaster> CpiuMaster { get; set; }
        public virtual ICollection<CreditCardTrans> CreditCardTrans { get; set; }
        public virtual ICollection<CustomerFlashResponse> CustomerFlashResponse { get; set; }
        public virtual ICollection<DocumentResource> DocumentResourceCreatedByNavigation { get; set; }
        public virtual ICollection<DocumentResource> DocumentResourceUpdatedByNavigation { get; set; }
        public virtual ICollection<EoscarBatch> EoscarBatch { get; set; }
        public virtual ICollection<ExcludeFromCapsHistory> ExcludeFromCapsHistory { get; set; }
        public virtual ICollection<Issuer> IssuerTlrNavigation { get; set; }
        public virtual ICollection<Issuer> IssuerTuptNavigation { get; set; }
        public virtual ICollection<ProcessConfigInstanceTeller> ProcessConfigInstanceTeller { get; set; }
        public virtual ICollection<PurchaseService> PurchaseService { get; set; }
        public virtual ICollection<ReasonForArrears> ReasonForArrears { get; set; }
        public virtual ICollection<RiagingHistory> RiagingHistory { get; set; }
        public virtual ICollection<Ris> Ris { get; set; }
        public virtual ICollection<Risrept> RisreptManualTellerNavigation { get; set; }
        public virtual ICollection<Risrept> RisreptTlrNavigation { get; set; }
        public virtual ICollection<RiUrgentNote> RiUrgentNote { get; set; }
        public virtual ICollection<SecurityAnswer> SecurityAnswer { get; set; }
        public virtual ICollection<SpecialMessage> SpecialMessage { get; set; }
        public virtual ICollection<TellerComputer> TellerComputer { get; set; }
        public virtual ICollection<TellerPwdHistory> TellerPwdHistory { get; set; }
        public virtual ICollection<TellerSecurity> TellerSecurity { get; set; }
        public virtual ICollection<TransDetail> TransDetail { get; set; }
        public virtual ICollection<TransferFunds> TransferFunds { get; set; }
        public virtual ICollection<TransPos> TransPos { get; set; }
        public virtual ICollection<VaultCount> VaultCount { get; set; }
        public virtual SecurityGroup SecuritygroupKeyNavigation { get; set; }
        public virtual TellerType TellerTypeNavigation { get; set; }
        public virtual TellerTitle TitleKeyNavigation { get; set; }
    }
}
