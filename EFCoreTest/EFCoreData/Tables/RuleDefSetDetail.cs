using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class RuleDefSetDetail
    {
        public int RuleDefSetDetailKey { get; set; }
        public int RuleDefSetKey { get; set; }
        public int RuleDefKey { get; set; }
        public int Priority { get; set; }
        public DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }

        public virtual RuleDef RuleDefKeyNavigation { get; set; }
        public virtual RuleDefSet RuleDefSetKeyNavigation { get; set; }
    }
}
