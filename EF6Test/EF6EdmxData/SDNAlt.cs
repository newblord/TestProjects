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
    
    public partial class SDNAlt
    {
        public Nullable<int> ENT_NUM { get; set; }
        public int ALT_NUM { get; set; }
        public string ALT_TYPE { get; set; }
        public string ALT_NAME { get; set; }
        public string ALT_REMARKS { get; set; }
    
        public virtual SDNMain SDNMain { get; set; }
    }
}