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
    
    public partial class TellerSecurity
    {
        public int TELLER_SECURITY_KEY { get; set; }
        public int TELLER_ID_KEY { get; set; }
        public Nullable<System.DateTime> START_DATE { get; set; }
        public Nullable<System.DateTime> END_DATE { get; set; }
        public Nullable<System.DateTime> ENDED_ON_DATE { get; set; }
        public bool IS_TEMPORARY { get; set; }
        public string SG_VALUES { get; set; }
        public System.DateTime DATE_ENTERED { get; set; }
        public string ENTERED_BY { get; set; }
        public Nullable<System.DateTime> DATE_UPDATED { get; set; }
        public string UPDATED_BY { get; set; }
    
        public virtual TELLERID TELLERID { get; set; }
    }
}
