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
    
    public partial class TransDetailLoan
    {
        public int TRANS_DETAIL_LOAN_KEY { get; set; }
        public int TRANS_DETAIL_KEY { get; set; }
        public short LOCATION { get; set; }
        public string LOAN_FROM { get; set; }
        public string LOAN_TO { get; set; }
        public string LOAN_TYPE { get; set; }
        public decimal LOAN_AMT { get; set; }
        public byte LOAN_CNT { get; set; }
        public string PRODUCT_TYPE { get; set; }
    
        public virtual TransDetail TransDetail { get; set; }
    }
}