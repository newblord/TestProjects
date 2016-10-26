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
    
    public partial class AMLThresholdRule
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AMLThresholdRule()
        {
            this.AMLThresholdRuleTransXrefs = new HashSet<AMLThresholdRuleTransXref>();
        }
    
        public int AML_THRESHOLD_RULE_KEY { get; set; }
        public string DESCRIPTION { get; set; }
        public bool IS_ENABLED { get; set; }
        public decimal MIN_DOLLAR_AMT { get; set; }
        public decimal MAX_DOLLAR_AMT { get; set; }
        public int THRESHOLD_TYPE { get; set; }
        public bool IS_AGGREGATED { get; set; }
        public bool INCLUDE_FEES { get; set; }
        public bool REQ_AML_PRIMARY { get; set; }
        public bool REQ_AML_SECONDARY { get; set; }
        public bool REQ_AML_CTR { get; set; }
        public bool EXPIRED_ACCEPTED { get; set; }
        public bool INQUIRE_OCCUPATION { get; set; }
        public bool PROMPT_OTHER_PARTY { get; set; }
        public bool PROMPT_PURPOSE { get; set; }
        public bool REQUIRE_CUSTOMER { get; set; }
        public System.DateTime DATE_ENTERED { get; set; }
        public string ENTERED_BY { get; set; }
        public Nullable<System.DateTime> DATE_UPDATED { get; set; }
        public string UPDATED_BY { get; set; }
        public bool PROMPT_OCCUPATION_EVERYDAY { get; set; }
        public bool PROMPT_OCCUPATION_EVERYTRANS { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AMLThresholdRuleTransXref> AMLThresholdRuleTransXrefs { get; set; }
    }
}