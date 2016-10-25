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
    
    public partial class SecurityGroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SecurityGroup()
        {
            this.DiscountSecurities = new HashSet<DiscountSecurity>();
            this.ProcessConfigInstanceGroups = new HashSet<ProcessConfigInstanceGroup>();
            this.TELLERIDs = new HashSet<TELLERID>();
            this.TELLERIDs1 = new HashSet<TELLERID>();
        }
    
        public int SECURITYGROUP_KEY { get; set; }
        public string SG_NAME { get; set; }
        public string SG_VALUES { get; set; }
        public bool IS_COLLECTOR { get; set; }
        public bool IS_AD_ASTRA { get; set; }
        public bool IS_ACTIVE { get; set; }
        public bool IS_MANAGER { get; set; }
        public bool IS_CORPORATE { get; set; }
        public bool IS_ACCOUNTANT { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiscountSecurity> DiscountSecurities { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProcessConfigInstanceGroup> ProcessConfigInstanceGroups { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TELLERID> TELLERIDs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TELLERID> TELLERIDs1 { get; set; }
    }
}
