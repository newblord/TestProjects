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
    
    public partial class BalSheet_TransDetail
    {
        public int BALSHEET_KEY { get; set; }
        public int TRANS_DETAIL_KEY { get; set; }
        public short LOCATION { get; set; }
    
        public virtual BalSheet2 BalSheet2 { get; set; }
    }
}