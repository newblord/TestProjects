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
    
    public partial class ACHBank
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ACHBank()
        {
            this.BanksParents = new HashSet<BanksParent>();
            this.CompanyACHBanks = new HashSet<CompanyACHBank>();
            this.CompanyACHBanks1 = new HashSet<CompanyACHBank>();
        }
    
        public int ACH_BANK_KEY { get; set; }
        public string NAME { get; set; }
        public bool IS_INTERNET { get; set; }
        public bool IS_ADASTRA { get; set; }
        public string DEBIT_OR_CREDIT { get; set; }
        public bool IS_ACTIVE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BanksParent> BanksParents { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompanyACHBank> CompanyACHBanks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompanyACHBank> CompanyACHBanks1 { get; set; }
    }
}
