using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class InsuranceClaimStatus
    {
        public InsuranceClaimStatus()
        {
            InsuranceClaimEdit = new HashSet<InsuranceClaimEdit>();
        }

        public int InsuranceClaimStatusKey { get; set; }
        public int InsuranceClaimKey { get; set; }
        public int InsuranceStatusKey { get; set; }
        public string ClaimStatusNote { get; set; }
        public DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? FollowUpDate { get; set; }

        public virtual ICollection<InsuranceClaimEdit> InsuranceClaimEdit { get; set; }
        public virtual InsuranceClaim InsuranceClaimKeyNavigation { get; set; }
        public virtual InsuranceStatus InsuranceStatusKeyNavigation { get; set; }
    }
}
