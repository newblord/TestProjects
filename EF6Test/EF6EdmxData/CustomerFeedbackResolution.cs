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
    
    public partial class CustomerFeedbackResolution
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CustomerFeedbackResolution()
        {
            this.CustomerFeedbacks = new HashSet<CustomerFeedback>();
        }
    
        public int CUSTOMER_FEEDBACK_RESOLUTION_KEY { get; set; }
        public string DESCRIPTION { get; set; }
        public bool IS_ACTIVE { get; set; }
        public bool IS_CLOSED { get; set; }
        public System.DateTime DATE_ENTERED { get; set; }
        public string ENTERED_BY { get; set; }
        public System.DateTime LAST_UPDATE_DATE { get; set; }
        public string LAST_UPDATED_BY { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerFeedback> CustomerFeedbacks { get; set; }
    }
}
