using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class InsuranceClaimEdit
    {
        public int InsuranceClaimEditKey { get; set; }
        public int InsuranceClaimKey { get; set; }
        public int? InsuranceClaimStatusKey { get; set; }
        public string FieldName { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }

        public virtual InsuranceClaim InsuranceClaimKeyNavigation { get; set; }
        public virtual InsuranceClaimStatus InsuranceClaimStatusKeyNavigation { get; set; }
    }
}
