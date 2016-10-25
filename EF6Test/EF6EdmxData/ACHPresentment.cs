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
    
    public partial class ACHPresentment
    {
        public int ACH_PRESENTMENT_KEY { get; set; }
        public Nullable<int> ACH_PARENT_PRESENTMENT_ID_KEY { get; set; }
        public int ACH_PRESENTMENT_TYPE_KEY { get; set; }
        public Nullable<int> LOAN_KEY { get; set; }
        public Nullable<int> RISREPT_KEY { get; set; }
        public Nullable<int> REFERENCE_KEY { get; set; }
        public decimal AMT { get; set; }
        public bool IS_DONE { get; set; }
        public int SCHEDULED_PAYMENT_NUMBER { get; set; }
        public int COLLECTION_PAYMENT_NUMBER { get; set; }
        public int FEE_PAYMENT_NUMBER { get; set; }
        public string STATEMENT_ID { get; set; }
        public System.DateTime DATE_ENTERED { get; set; }
        public string ENTERED_BY { get; set; }
    
        public virtual ACHPresentmentType ACHPresentmentType { get; set; }
    }
}
