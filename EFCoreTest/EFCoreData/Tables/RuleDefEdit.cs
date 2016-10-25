using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class RuleDefEdit
    {
        public int RuleDefEditKey { get; set; }
        public int RuleDefKey { get; set; }
        public string Teller { get; set; }
        public DateTime DateEntered { get; set; }
        public string FieldName { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }

        public virtual RuleDef RuleDefKeyNavigation { get; set; }
    }
}
