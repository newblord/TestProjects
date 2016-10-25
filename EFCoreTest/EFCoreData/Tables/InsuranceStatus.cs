using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class InsuranceStatus
    {
        public InsuranceStatus()
        {
            InsuranceClaim = new HashSet<InsuranceClaim>();
            InsuranceClaimStatus = new HashSet<InsuranceClaimStatus>();
        }

        public int InsuranceStatusKey { get; set; }
        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }
        public bool IsOpenClaim { get; set; }
        public DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<InsuranceClaim> InsuranceClaim { get; set; }
        public virtual ICollection<InsuranceClaimStatus> InsuranceClaimStatus { get; set; }
    }
}
