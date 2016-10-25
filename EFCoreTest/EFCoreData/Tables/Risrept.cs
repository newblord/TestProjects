using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class Risrept
    {
        public Risrept()
        {
            CollectionAction = new HashSet<CollectionAction>();
            CollectionMovement = new HashSet<CollectionMovement>();
            CollectionNote = new HashSet<CollectionNote>();
            CpiuDetail = new HashSet<CpiuDetail>();
            FormLetterPrinted = new HashSet<FormLetterPrinted>();
            LegalVerification = new HashSet<LegalVerification>();
            OptPlusCardRipayment = new HashSet<OptPlusCardRipayment>();
            PromiseToPay = new HashSet<PromiseToPay>();
            RepoCaseHistory = new HashSet<RepoCaseHistory>();
            RiagingHistory = new HashSet<RiagingHistory>();
            RiBalanceHistory = new HashSet<RiBalanceHistory>();
            RiccAutoRoll = new HashSet<RiccAutoRoll>();
            Ris = new HashSet<Ris>();
            SkipTraceThread = new HashSet<SkipTraceThread>();
        }

        public DateTime Date { get; set; }
        public string Tlr { get; set; }
        public short Location { get; set; }
        public decimal? Amount { get; set; }
        public decimal Surchg { get; set; }
        public DateTime? Followup { get; set; }
        public int CustomerKey { get; set; }
        public int IssuerKey { get; set; }
        public DateTime? ManualAchDate { get; set; }
        public string ManualTeller { get; set; }
        public int RisreptKey { get; set; }
        public int? LoanKey { get; set; }
        public decimal RiBalance { get; set; }
        public byte Pra { get; set; }
        public int RisTypeId { get; set; }
        public int? RisAuditId { get; set; }
        public bool StopPayment { get; set; }
        public bool Reversed { get; set; }
        public DateTime? ReversedDate { get; set; }
        public int? CashedCheckKey { get; set; }
        public int? DosRefno { get; set; }
        public string DosMigratedId { get; set; }
        public decimal? ManualAchAmount { get; set; }
        public int? ManualAchPtp { get; set; }
        public DateTime? LastCallDate { get; set; }
        public short? LastCallHostCode { get; set; }
        public bool DoNotCallHome { get; set; }
        public bool DoNotCallWork { get; set; }
        public bool DoNotCallCell { get; set; }
        public bool DoNotSendLetters { get; set; }
        public bool? DoNotCallVerbalDnc { get; set; }
        public int? OptplusCardDetailKey { get; set; }
        public string Reference { get; set; }
        public byte RiskAssessment { get; set; }
        public int CollectionAgencyKey { get; set; }
        public int AssignmentNumber { get; set; }
        public string CrTeller { get; set; }
        public int ReasonForArrearsKey { get; set; }
        public DateTime? LastDcardAttemptDate { get; set; }
        public int RiUrgentNoteKey { get; set; }
        public bool KeepWithAgency { get; set; }
        public DateTime? AdAstraAssignedDate { get; set; }

        public virtual ICollection<CollectionAction> CollectionAction { get; set; }
        public virtual ICollection<CollectionMovement> CollectionMovement { get; set; }
        public virtual ICollection<CollectionNote> CollectionNote { get; set; }
        public virtual ICollection<CpiuDetail> CpiuDetail { get; set; }
        public virtual ICollection<FormLetterPrinted> FormLetterPrinted { get; set; }
        public virtual ICollection<LegalVerification> LegalVerification { get; set; }
        public virtual ICollection<OptPlusCardRipayment> OptPlusCardRipayment { get; set; }
        public virtual ICollection<PromiseToPay> PromiseToPay { get; set; }
        public virtual ICollection<RepoCaseHistory> RepoCaseHistory { get; set; }
        public virtual ICollection<RiagingHistory> RiagingHistory { get; set; }
        public virtual ICollection<RiBalanceHistory> RiBalanceHistory { get; set; }
        public virtual ICollection<RiccAutoRoll> RiccAutoRoll { get; set; }
        public virtual ICollection<Ris> Ris { get; set; }
        public virtual ICollection<SkipTraceThread> SkipTraceThread { get; set; }
        public virtual CashedCheck CashedCheckKeyNavigation { get; set; }
        public virtual Customer CustomerKeyNavigation { get; set; }
        public virtual Issuer IssuerKeyNavigation { get; set; }
        public virtual Company LocationNavigation { get; set; }
        public virtual Tellerid ManualTellerNavigation { get; set; }
        public virtual OptPlusCardDetail OptplusCardDetailKeyNavigation { get; set; }
        public virtual Risaudit RisAudit { get; set; }
        public virtual Ristype RisType { get; set; }
        public virtual Tellerid TlrNavigation { get; set; }
    }
}
