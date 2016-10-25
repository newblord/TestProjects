using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class AmlthresholdRule
    {
        public AmlthresholdRule()
        {
            AmlthresholdRuleTransXref = new HashSet<AmlthresholdRuleTransXref>();
        }

        public int AmlThresholdRuleKey { get; set; }
        public string Description { get; set; }
        public bool IsEnabled { get; set; }
        public decimal MinDollarAmt { get; set; }
        public decimal MaxDollarAmt { get; set; }
        public int ThresholdType { get; set; }
        public bool IsAggregated { get; set; }
        public bool IncludeFees { get; set; }
        public bool ReqAmlPrimary { get; set; }
        public bool ReqAmlSecondary { get; set; }
        public bool ReqAmlCtr { get; set; }
        public bool ExpiredAccepted { get; set; }
        public bool InquireOccupation { get; set; }
        public bool PromptOtherParty { get; set; }
        public bool PromptPurpose { get; set; }
        public bool RequireCustomer { get; set; }
        public DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string UpdatedBy { get; set; }
        public bool PromptOccupationEveryday { get; set; }
        public bool PromptOccupationEverytrans { get; set; }

        public virtual ICollection<AmlthresholdRuleTransXref> AmlthresholdRuleTransXref { get; set; }
    }
}
