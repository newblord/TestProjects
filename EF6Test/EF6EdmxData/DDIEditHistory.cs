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
    
    public partial class DDIEditHistory
    {
        public int DDI_EDIT_HISTORY_KEY { get; set; }
        public int DDI_KEY { get; set; }
        public string FIELD_NAME { get; set; }
        public string OLD_VALUE { get; set; }
        public string NEW_VALUE { get; set; }
        public System.DateTime ENTERED_DATE { get; set; }
    
        public virtual DDI DDI { get; set; }
    }
}