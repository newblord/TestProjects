using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class RuleDefType
    {
        public RuleDefType()
        {
            RuleDef = new HashSet<RuleDef>();
            RuleDefSet = new HashSet<RuleDefSet>();
        }

        public int RuleDefTypeKey { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<RuleDef> RuleDef { get; set; }
        public virtual ICollection<RuleDefSet> RuleDefSet { get; set; }
    }
}
