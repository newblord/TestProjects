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
    
    public partial class GoodCustomerStudy
    {
        public int GOOD_CUSTOMER_STUDY_KEY { get; set; }
        public int CUSTOMER_KEY { get; set; }
        public System.DateTime DATE_ENTERED { get; set; }
        public decimal INITIAL_APPROVED_AMT { get; set; }
        public decimal INCREASE_AMT { get; set; }
        public decimal STATE_MAX_AMT { get; set; }
        public decimal LOAN_TAKEN_AMT { get; set; }
    
        public virtual Customer Customer { get; set; }
    }
}
