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
    
    public partial class RuleDefSetDetailEdit
    {
        public int RULE_DEF_SET_DETAIL_EDIT_KEY { get; set; }
        public int RULE_DEF_SET_KEY { get; set; }
        public string TELLER { get; set; }
        public System.DateTime DATE_ENTERED { get; set; }
        public string ACTION_TYPE { get; set; }
        public string FIELD_NAME { get; set; }
        public string OLD_VALUE { get; set; }
        public string NEW_VALUE { get; set; }
    
        public virtual RuleDefSet RuleDefSet { get; set; }
    }
}
