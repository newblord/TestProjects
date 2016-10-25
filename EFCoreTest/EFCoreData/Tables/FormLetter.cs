using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class FormLetter
    {
        public FormLetter()
        {
            FormLetterAfterLetterXrefAfterFormLetterKeyNavigation = new HashSet<FormLetterAfterLetterXref>();
            FormLetterAfterLetterXrefFormLetterKeyNavigation = new HashSet<FormLetterAfterLetterXref>();
            FormLetterAuditCode = new HashSet<FormLetterAuditCode>();
            FormLetterLocation = new HashSet<FormLetterLocation>();
            FormLetterOnDemand = new HashSet<FormLetterOnDemand>();
            FormLetterPrinted = new HashSet<FormLetterPrinted>();
            FormLetterProduct = new HashSet<FormLetterProduct>();
            FormLetterReplacesXrefDeletedFormLetterKeyNavigation = new HashSet<FormLetterReplacesXref>();
            FormLetterReplacesXrefFormLetterKeyNavigation = new HashSet<FormLetterReplacesXref>();
        }

        public int FormLetterKey { get; set; }
        public string FormLetterName { get; set; }
        public string FormLetterDescription { get; set; }
        public string FormLetterBody { get; set; }
        public string Language { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsAdAstra { get; set; }
        public bool IsInitialLetter { get; set; }
        public bool IsAdAstraAchLetter { get; set; }
        public short AfterDays { get; set; }
        public bool IsAfterCreditReport { get; set; }
        public DateTime PrintAfterCollDate { get; set; }
        public decimal MinimumBalance { get; set; }
        public int? SetAuditCodeKey { get; set; }
        public string OnDemandPrompt1 { get; set; }
        public string OnDemandPrompt2 { get; set; }
        public string OnDemandPrompt3 { get; set; }
        public string OnDemandPrompt4 { get; set; }
        public string OnDemandPrompt5 { get; set; }
        public DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public DateTime DateUpdated { get; set; }
        public string UpdatedBy { get; set; }
        public int MinimumRiAge { get; set; }
        public int MaximumRiAge { get; set; }
        public byte AddDaysToFollowupDate { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public bool UseLastKnownAddress { get; set; }
        public bool IsLoanMatured { get; set; }
        public bool IsLoanInactive { get; set; }
        public string RiskAssessment { get; set; }
        public int MinimumAaAge { get; set; }
        public int MaximumAaAge { get; set; }
        public bool IsLoanNotMatured { get; set; }
        public bool IsLoanNotInactive { get; set; }
        public bool IsLoanMaturedOrInactive { get; set; }
        public bool IsLoanNotMaturedOrNotInactive { get; set; }
        public bool IncludePayments { get; set; }
        public byte LetterOrder { get; set; }
        public bool KeepAddressWhenMailReturned { get; set; }
        public decimal MinimumRiAmount { get; set; }
        public decimal MaximumRiAmount { get; set; }
        public bool SetToPrevAuditId { get; set; }
        public bool ExcludeSecondLienLoans { get; set; }
        public bool IsActive { get; set; }
        public short MinimumCyclesPastDue { get; set; }
        public short MaximumCyclesPastDue { get; set; }
        public bool IsUkArrearsNotice { get; set; }
        public bool UseAdastraSdsUploadPath { get; set; }
        public bool IncludeLoanHistory { get; set; }

        public virtual ICollection<FormLetterAfterLetterXref> FormLetterAfterLetterXrefAfterFormLetterKeyNavigation { get; set; }
        public virtual ICollection<FormLetterAfterLetterXref> FormLetterAfterLetterXrefFormLetterKeyNavigation { get; set; }
        public virtual ICollection<FormLetterAuditCode> FormLetterAuditCode { get; set; }
        public virtual ICollection<FormLetterLocation> FormLetterLocation { get; set; }
        public virtual ICollection<FormLetterOnDemand> FormLetterOnDemand { get; set; }
        public virtual ICollection<FormLetterPrinted> FormLetterPrinted { get; set; }
        public virtual ICollection<FormLetterProduct> FormLetterProduct { get; set; }
        public virtual ICollection<FormLetterReplacesXref> FormLetterReplacesXrefDeletedFormLetterKeyNavigation { get; set; }
        public virtual ICollection<FormLetterReplacesXref> FormLetterReplacesXrefFormLetterKeyNavigation { get; set; }
        public virtual Risaudit SetAuditCodeKeyNavigation { get; set; }
    }
}
