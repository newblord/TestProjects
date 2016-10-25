using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class RuleDefSetDetailEdit
    {
        public int RuleDefSetDetailEditKey { get; set; }
        public int RuleDefSetKey { get; set; }
        public string Teller { get; set; }
        public DateTime DateEntered { get; set; }
        public string ActionType { get; set; }
        public string FieldName { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }

        public virtual RuleDefSet RuleDefSetKeyNavigation { get; set; }
    }
}
