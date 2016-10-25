using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class AmlthresholdRuleTransXref
    {
        public int AmlThresholdRuleTransXrefKey { get; set; }
        public int AmlThresholdRuleKey { get; set; }
        public int FcrmAmlTransCodeKey { get; set; }
        public DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }

        public virtual AmlthresholdRule AmlThresholdRuleKeyNavigation { get; set; }
        public virtual FcrmAmlTransCode FcrmAmlTransCodeKeyNavigation { get; set; }
    }
}
