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
    
    public partial class DiscountLocation
    {
        public int DISCOUNT_LOCATIONS_KEY { get; set; }
        public int DISCOUNTS_KEY { get; set; }
        public short LOCATION { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual DiscountMaster DiscountMaster { get; set; }
    }
}