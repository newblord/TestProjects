//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EF6EdmxData
{
    using System;
    using System.Collections.Generic;
    
    public partial class RuleDefSetDetail
    {
        public int RULE_DEF_SET_DETAIL_KEY { get; set; }
        public int RULE_DEF_SET_KEY { get; set; }
        public int RULE_DEF_KEY { get; set; }
        public int PRIORITY { get; set; }
        public System.DateTime DATE_ENTERED { get; set; }
        public string ENTERED_BY { get; set; }
    
        public virtual RuleDef RuleDef { get; set; }
        public virtual RuleDefSet RuleDefSet { get; set; }
    }
}