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
    
    public partial class CustomerSDNCert
    {
        public int SDNCERT_KEY { get; set; }
        public int CUSTOMER_KEY { get; set; }
        public bool DIFF_DOB { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public bool DIFF_ADDRESS { get; set; }
        public bool DIFF_NUMBER { get; set; }
        public bool OTHER { get; set; }
        public string OTHER_DESC { get; set; }
        public string TELLER { get; set; }
        public System.DateTime DATE_ENTERED { get; set; }
    }
}