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
    
    public partial class InsuranceClaimEdit
    {
        public int INSURANCE_CLAIM_EDIT_KEY { get; set; }
        public int INSURANCE_CLAIM_KEY { get; set; }
        public Nullable<int> INSURANCE_CLAIM_STATUS_KEY { get; set; }
        public string FIELD_NAME { get; set; }
        public string OLD_VALUE { get; set; }
        public string NEW_VALUE { get; set; }
        public System.DateTime DATE_ENTERED { get; set; }
        public string ENTERED_BY { get; set; }
    
        public virtual InsuranceClaim InsuranceClaim { get; set; }
        public virtual InsuranceClaimStatu InsuranceClaimStatu { get; set; }
    }
}
