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
    
    public partial class ACHProcessingType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ACHProcessingType()
        {
            this.ACHProcessingQueues = new HashSet<ACHProcessingQueue>();
        }
    
        public int ACH_PROCESSING_TYPE_KEY { get; set; }
        public string ACH_PROCESSING_TYPE_DESC { get; set; }
        public string FILE_TYPE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACHProcessingQueue> ACHProcessingQueues { get; set; }
    }
}