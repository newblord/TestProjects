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
    
    public partial class VaultCountService
    {
        public int VAULT_COUNT_SERVICE_KEY { get; set; }
        public int VAULT_COUNT_KEY { get; set; }
        public int SERVICE_DETAIL_KEY { get; set; }
        public int SERVICE_CNT { get; set; }
        public int SERVICE_CALC { get; set; }
    
        public virtual ServiceDetail ServiceDetail { get; set; }
        public virtual VaultCount VaultCount { get; set; }
    }
}
