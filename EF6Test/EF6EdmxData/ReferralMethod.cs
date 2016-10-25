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
    
    public partial class ReferralMethod
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ReferralMethod()
        {
            this.Customers = new HashSet<Customer>();
            this.LoanApplications = new HashSet<LoanApplication>();
        }
    
        public short REFERRAL_METHOD_KEY { get; set; }
        public string REFERRAL_CODE { get; set; }
        public string REFERRAL_DESC { get; set; }
        public short CURO_ORDER { get; set; }
        public short WEB_ORDER { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customer> Customers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanApplication> LoanApplications { get; set; }
    }
}
