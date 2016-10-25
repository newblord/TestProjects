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
    
    public partial class SpecialMessage
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SpecialMessage()
        {
            this.SpecialMessageLoanProducts = new HashSet<SpecialMessageLoanProduct>();
            this.SpecialMessageLocations = new HashSet<SpecialMessageLocation>();
        }
    
        public int SPECIAL_MESSAGE_KEY { get; set; }
        public System.DateTime DATE_ENTERED { get; set; }
        public string TELLER { get; set; }
        public Nullable<System.DateTime> START_DATE { get; set; }
        public Nullable<System.DateTime> END_DATE { get; set; }
        public string MESSAGE_FILE { get; set; }
        public string MESSAGE_NAME { get; set; }
        public string PROCEDURE_NAME { get; set; }
        public bool FOR_CASHED_CHECKS { get; set; }
        public bool FOR_SERVICES_NOTICE { get; set; }
        public bool FOR_CUSTOMER_NOTICE { get; set; }
        public bool FOR_GOLD { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SpecialMessageLoanProduct> SpecialMessageLoanProducts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SpecialMessageLocation> SpecialMessageLocations { get; set; }
    }
}
