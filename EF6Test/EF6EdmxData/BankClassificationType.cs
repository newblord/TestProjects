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
    
    public partial class BankClassificationType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BankClassificationType()
        {
            this.BankClassifications = new HashSet<BankClassification>();
        }
    
        public int BANK_CLASSIFICATION_TYPE_KEY { get; set; }
        public int BANK_CLASSIFICATION_TYPE { get; set; }
        public string BANK_CLASSIFICATION_DESC { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BankClassification> BankClassifications { get; set; }
    }
}
