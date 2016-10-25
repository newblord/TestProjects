using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class IdentificationTypeRule
    {
        public int IdentificationTypeRuleKey { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }
        public bool IsActive { get; set; }
        public short SortOrder { get; set; }
        public string RuleDefinition { get; set; }
        public string RuleDescription { get; set; }
        public string RuleMessage { get; set; }
        public string RuleDirectives { get; set; }
    }
}
