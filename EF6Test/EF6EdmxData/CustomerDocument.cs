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
    
    public partial class CustomerDocument
    {
        public int CUSTOMER_DOCUMENT_KEY { get; set; }
        public int CUSTOMER_KEY { get; set; }
        public short LOCATION { get; set; }
        public int DWDOCID { get; set; }
        public byte DOCUMENT_TYPE { get; set; }
        public System.DateTime DATE_ENTERED { get; set; }
        public string IGNORE_TELLER { get; set; }
        public Nullable<System.DateTime> IGNORE_DATE { get; set; }
        public string IGNORE_TYPE { get; set; }
        public string TELLER { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual Customer Customer { get; set; }
    }
}