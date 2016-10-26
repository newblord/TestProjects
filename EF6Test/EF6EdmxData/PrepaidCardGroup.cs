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
    
    public partial class PrepaidCardGroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PrepaidCardGroup()
        {
            this.PrepaidCardBinCompanies = new HashSet<PrepaidCardBinCompany>();
        }
    
        public int PREPAID_CARD_GROUP_KEY { get; set; }
        public string GROUP_NAME { get; set; }
        public string GROUP_DESCRIPTION { get; set; }
        public Nullable<int> CARD_AMOUNT_GL_ACCT { get; set; }
        public bool IS_ACTIVE { get; set; }
        public Nullable<System.DateTime> DATE_ACTIVE_CHANGED { get; set; }
        public string TELLER_ACTIVE_CHANGED { get; set; }
        public System.DateTime DATE_ENTERED { get; set; }
        public string TELLER { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrepaidCardBinCompany> PrepaidCardBinCompanies { get; set; }
    }
}