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
    
    public partial class EOscarDetailDisputeCode
    {
        public int EOSCAR_DETAIL_DISPUTE_CODE_KEY { get; set; }
        public int EOSCAR_BATCH_DETAIL_KEY { get; set; }
        public int EOSCAR_DISPUTE_CODE_KEY { get; set; }
    
        public virtual EOscarBatchDetail EOscarBatchDetail { get; set; }
        public virtual EOscarDisputeCode EOscarDisputeCode { get; set; }
    }
}