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
    
    public partial class LoanProductFeature
    {
        public int LOAN_PRODUCT_FEATURE_KEY { get; set; }
        public int LOAN_PRODUCT_KEY { get; set; }
        public int LOAN_PRODUCT_FEATURE_TYPE_KEY { get; set; }
        public string DESCRIPTION { get; set; }
        public Nullable<int> DISPLAY_COLOR { get; set; }
        public System.DateTime DATE_ENTERED { get; set; }
        public string ENTERED_BY { get; set; }
        public System.DateTime LAST_UPDATE_DATE { get; set; }
        public string LAST_UPDATED_BY { get; set; }
    
        public virtual LoanProduct LoanProduct { get; set; }
        public virtual LoanProductFeatureType LoanProductFeatureType { get; set; }
    }
}