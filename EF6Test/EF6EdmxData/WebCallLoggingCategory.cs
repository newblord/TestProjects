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
    
    public partial class WebCallLoggingCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WebCallLoggingCategory()
        {
            this.WebCallLoggingCategoryLogs = new HashSet<WebCallLoggingCategoryLog>();
        }
    
        public int WEB_CALL_LOGGING_CATEGORY_KEY { get; set; }
        public string CATEGORY_NAME { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebCallLoggingCategoryLog> WebCallLoggingCategoryLogs { get; set; }
    }
}
