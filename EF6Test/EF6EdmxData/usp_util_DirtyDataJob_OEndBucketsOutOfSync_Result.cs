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
    
    public partial class usp_util_DirtyDataJob_OEndBucketsOutOfSync_Result
    {
        public int LOAN_KEY { get; set; }
        public short LOCATION { get; set; }
        public int CUSTOMER_KEY { get; set; }
        public string LOAN_STATUS { get; set; }
        public bool DEFAULTED { get; set; }
        public bool IS_IN_LEGAL_STATUS { get; set; }
        public string RA_DESC { get; set; }
        public decimal LOAN_BALANCE { get; set; }
        public Nullable<decimal> BUCKET_BALANCE { get; set; }
        public Nullable<decimal> BALANCE_DIFFERENCE { get; set; }
    }
}