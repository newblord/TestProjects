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
    
    public partial class CashedCheckImage
    {
        public int CASHED_CHECK_IMAGE_KEY { get; set; }
        public int CASHED_CHECK_KEY { get; set; }
        public byte[] DATA { get; set; }
        public short IMAGE_TYPE { get; set; }
        public System.DateTime DATE_ENTERED { get; set; }
        public System.DateTime DATE_TO_DELETE { get; set; }
    
        public virtual CashedCheck CashedCheck { get; set; }
    }
}