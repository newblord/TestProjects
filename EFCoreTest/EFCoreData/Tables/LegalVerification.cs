using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LegalVerification
    {
        public int LegalVerificationKey { get; set; }
        public DateTime DateEntered { get; set; }
        public int? RisreptKey { get; set; }
        public string RiReference { get; set; }
        public string DebtorNumber { get; set; }
        public string Plaintiff1 { get; set; }
        public string Plaintiff2 { get; set; }
        public string DefendantFullname { get; set; }
        public string DefendantAddressLine { get; set; }
        public string DefendantAddressCsz { get; set; }
        public string DefendantMaskedSsn { get; set; }
        public decimal CustomerBalanceDue { get; set; }
        public decimal CourtCosts { get; set; }
        public decimal DefendantTotalDue { get; set; }
        public decimal AttorneyFees { get; set; }
        public decimal AttorneyTitleLoanBalDue { get; set; }
        public decimal AttorneyCurrentBalDue { get; set; }
        public decimal AttorneyPostJudgeDue { get; set; }
        public decimal PrincipleDue { get; set; }
        public int ExceptionReportStatus { get; set; }
        public string VerifiedTeller { get; set; }
        public DateTime? VerifiedDate { get; set; }
        public string ImportFilename { get; set; }
        public DateTime ExceptionStatusLastUpdated { get; set; }
        public byte ReportType { get; set; }

        public virtual Risrept RisreptKeyNavigation { get; set; }
    }
}
