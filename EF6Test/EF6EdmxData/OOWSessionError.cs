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
    
    public partial class OOWSessionError
    {
        public int OOW_SESSION_ERROR_KEY { get; set; }
        public int OOW_SESSION_KEY { get; set; }
        public string ERROR_CODE { get; set; }
        public string ERROR_TEXT { get; set; }
        public System.DateTime DATE_ENTERED { get; set; }
    
        public virtual OOWSession OOWSession { get; set; }
    }
}
