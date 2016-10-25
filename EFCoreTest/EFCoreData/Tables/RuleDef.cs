using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class RuleDef
    {
        public RuleDef()
        {
            LoanDepositOrderHistory = new HashSet<LoanDepositOrderHistory>();
            RuleDefEdit = new HashSet<RuleDefEdit>();
            RuleDefSetDetail = new HashSet<RuleDefSetDetail>();
        }

        public int RuleDefKey { get; set; }
        public int RuleDefTypeKey { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DateDeleted { get; set; }
        public string DeletedBy { get; set; }
        public DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<LoanDepositOrderHistory> LoanDepositOrderHistory { get; set; }
        public virtual ICollection<RuleDefEdit> RuleDefEdit { get; set; }
        public virtual ICollection<RuleDefSetDetail> RuleDefSetDetail { get; set; }
        public virtual RuleDefType RuleDefTypeKeyNavigation { get; set; }
    }
}
