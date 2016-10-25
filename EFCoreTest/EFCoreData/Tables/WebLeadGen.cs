using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebLeadGen
    {
        public WebLeadGen()
        {
            WebLead = new HashSet<WebLead>();
            WebLeadGenAddress = new HashSet<WebLeadGenAddress>();
            WebLeadGenFields = new HashSet<WebLeadGenFields>();
            WebLeadGenStatistics = new HashSet<WebLeadGenStatistics>();
            WebLeadGenTiers = new HashSet<WebLeadGenTiers>();
            WebLeadGenTranslations = new HashSet<WebLeadGenTranslations>();
        }

        public int WebLeadGenKey { get; set; }
        public string Name { get; set; }
        public int? Attributes { get; set; }
        public string ScoringModel { get; set; }
        public int? ColorCode { get; set; }
        public int? HourlyLimit { get; set; }
        public int? DailyLimit { get; set; }
        public string WebsiteUrl { get; set; }
        public DateTime DateEntered { get; set; }
        public DateTime DateUpdated { get; set; }
        public int? LeadPostDays { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<WebLead> WebLead { get; set; }
        public virtual ICollection<WebLeadGenAddress> WebLeadGenAddress { get; set; }
        public virtual ICollection<WebLeadGenFields> WebLeadGenFields { get; set; }
        public virtual ICollection<WebLeadGenStatistics> WebLeadGenStatistics { get; set; }
        public virtual ICollection<WebLeadGenTiers> WebLeadGenTiers { get; set; }
        public virtual ICollection<WebLeadGenTranslations> WebLeadGenTranslations { get; set; }
    }
}
