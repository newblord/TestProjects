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
    
    public partial class CustomerLeadActivity
    {
        public int CUSTOMER_LEAD_ACTIVITY_KEY { get; set; }
        public int CUSTOMER_LEAD_KEY { get; set; }
        public System.DateTime DATE_ENTERED { get; set; }
        public string TELLER { get; set; }
        public int CUSTOMER_LEAD_ACTION_KEY { get; set; }
        public int CUSTOMER_LEAD_STATUS_KEY { get; set; }
        public Nullable<int> CUSTOMER_LEAD_REASON_KEY { get; set; }
    
        public virtual CustomerLead CustomerLead { get; set; }
        public virtual CustomerLeadAction CustomerLeadAction { get; set; }
        public virtual CustomerLeadStatu CustomerLeadStatu { get; set; }
    }
}