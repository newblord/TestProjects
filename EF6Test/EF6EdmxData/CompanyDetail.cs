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
    
    public partial class CompanyDetail
    {
        public short LOCATION { get; set; }
        public string ADDRESS { get; set; }
        public string CROSS_STREETS { get; set; }
        public string DIRECTIONS { get; set; }
        public string NEWS_FLASH { get; set; }
        public string FAX { get; set; }
        public string ALTERNATE_HOURS { get; set; }
        public string STORE_EMAIL_ADDRESS { get; set; }
    
        public virtual Company Company { get; set; }
    }
}