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
    
    public partial class DocuwareCabinet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DocuwareCabinet()
        {
            this.DocuwareLoanLkups = new HashSet<DocuwareLoanLkup>();
        }
    
        public int DOCUWARE_CABINET_KEY { get; set; }
        public short SERVER_ID { get; set; }
        public string CABINET_DB_TABLE { get; set; }
        public string DW_REFERENCE_LOOKUP { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocuwareLoanLkup> DocuwareLoanLkups { get; set; }
    }
}