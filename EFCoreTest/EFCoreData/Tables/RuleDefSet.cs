using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class RuleDefSet
    {
        public RuleDefSet()
        {
            LoanProductConfig = new HashSet<LoanProductConfig>();
            RuleDefSetDetail = new HashSet<RuleDefSetDetail>();
            RuleDefSetDetailEdit = new HashSet<RuleDefSetDetailEdit>();
        }

        public int RuleDefSetKey { get; set; }
        public int RuleDefTypeKey { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<LoanProductConfig> LoanProductConfig { get; set; }
        public virtual ICollection<RuleDefSetDetail> RuleDefSetDetail { get; set; }
        public virtual ICollection<RuleDefSetDetailEdit> RuleDefSetDetailEdit { get; set; }
        public virtual RuleDefType RuleDefTypeKeyNavigation { get; set; }
    }
}
