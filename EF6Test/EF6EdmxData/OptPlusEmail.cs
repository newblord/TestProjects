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
    
    public partial class OptPlusEmail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OptPlusEmail()
        {
            this.OptPlusEmailLocations = new HashSet<OptPlusEmailLocation>();
        }
    
        public int OPTPLUS_EMAIL_KEY { get; set; }
        public string EMAIL_ADDRESS { get; set; }
        public System.DateTime DATE_ENTERED { get; set; }
        public string TELLER { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OptPlusEmailLocation> OptPlusEmailLocations { get; set; }
    }
}