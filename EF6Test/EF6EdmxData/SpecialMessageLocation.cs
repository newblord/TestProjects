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
    
    public partial class SpecialMessageLocation
    {
        public int SPECIAL_MESSAGE_LOCATION_KEY { get; set; }
        public Nullable<int> SPECIAL_MESSAGE_KEY { get; set; }
        public Nullable<short> LOCATION { get; set; }
    
        public virtual SpecialMessage SpecialMessage { get; set; }
    }
}
