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
    
    public partial class ReturnCheckFile
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ReturnCheckFile()
        {
            this.ReturnCheckDetails = new HashSet<ReturnCheckDetail>();
        }
    
        public int RETURN_CHECK_FILE_KEY { get; set; }
        public System.DateTime DATE_ENTERED { get; set; }
        public int CURRENCY_KEY { get; set; }
        public int FILE_CREATION_NUMBER { get; set; }
        public System.DateTime FILE_CREATION_DATE { get; set; }
        public int TOTAL_RECORDS { get; set; }
        public decimal TOTAL_CHARGEBACKS { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReturnCheckDetail> ReturnCheckDetails { get; set; }
    }
}