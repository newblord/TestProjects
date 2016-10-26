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
    
    public partial class WebBlob
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WebBlob()
        {
            this.WebBlobLoanApplicationXrefs = new HashSet<WebBlobLoanApplicationXref>();
            this.WebBlobLoanXrefs = new HashSet<WebBlobLoanXref>();
            this.WebBlobVisitorEmailXrefs = new HashSet<WebBlobVisitorEmailXref>();
        }
    
        public int WEB_BLOB_KEY { get; set; }
        public byte[] DATA { get; set; }
        public short WEB_BLOB_TYPE_KEY { get; set; }
        public System.DateTime DATE_ENTERED { get; set; }
    
        public virtual WebBlobType WebBlobType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebBlobLoanApplicationXref> WebBlobLoanApplicationXrefs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebBlobLoanXref> WebBlobLoanXrefs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebBlobVisitorEmailXref> WebBlobVisitorEmailXrefs { get; set; }
    }
}