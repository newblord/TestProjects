using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class InsuranceClaim
    {
        public InsuranceClaim()
        {
            InsuranceClaimEdit = new HashSet<InsuranceClaimEdit>();
            InsuranceClaimStatus = new HashSet<InsuranceClaimStatus>();
            InsurancePayment = new HashSet<InsurancePayment>();
            LoanPaymentInsuranceClaimXref = new HashSet<LoanPaymentInsuranceClaimXref>();
        }

        public int InsuranceClaimKey { get; set; }
        public int LoanKey { get; set; }
        public int InsuranceStatusKey { get; set; }
        public string ClaimNum { get; set; }
        public string ClaimNote { get; set; }
        public DateTime? FollowUpDate { get; set; }
        public DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string UpdatedBy { get; set; }
        public short ClaimReasonId { get; set; }
        public DateTime SubmittedDate { get; set; }

        public virtual ICollection<InsuranceClaimEdit> InsuranceClaimEdit { get; set; }
        public virtual ICollection<InsuranceClaimStatus> InsuranceClaimStatus { get; set; }
        public virtual ICollection<InsurancePayment> InsurancePayment { get; set; }
        public virtual ICollection<LoanPaymentInsuranceClaimXref> LoanPaymentInsuranceClaimXref { get; set; }
        public virtual InsuranceStatus InsuranceStatusKeyNavigation { get; set; }
        public virtual Loan LoanKeyNavigation { get; set; }
    }
}
