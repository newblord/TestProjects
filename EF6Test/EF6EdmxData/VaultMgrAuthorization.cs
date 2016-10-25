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
    
    public partial class VaultMgrAuthorization
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VaultMgrAuthorization()
        {
            this.VaultMgrAuthorizationNotes = new HashSet<VaultMgrAuthorizationNote>();
            this.VaultMgrAuthorizationDetails = new HashSet<VaultMgrAuthorizationDetail>();
        }
    
        public int VM_AUTH_KEY { get; set; }
        public short LOCATION { get; set; }
        public string LOGGED_ON_INITS { get; set; }
        public string CURRENT_VM_INITS { get; set; }
        public string OTHER_AUTH_INITS { get; set; }
        public System.DateTime TIME_AUTHORIZED { get; set; }
        public decimal TRANS_AMT { get; set; }
        public int TRANS_RIGHTS_KEY { get; set; }
        public int VMA_TRANS_TYPE_KEY { get; set; }
    
        public virtual Company Company { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VaultMgrAuthorizationNote> VaultMgrAuthorizationNotes { get; set; }
        public virtual VMATransType VMATransType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VaultMgrAuthorizationDetail> VaultMgrAuthorizationDetails { get; set; }
    }
}
