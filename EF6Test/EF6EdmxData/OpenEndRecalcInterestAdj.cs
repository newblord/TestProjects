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
    
    public partial class OpenEndRecalcInterestAdj
    {
        public int OPEN_END_RECALC_INTEREST_ADJ_KEY { get; set; }
        public int OPEN_END_INTEREST_KEY { get; set; }
        public int LOAN_KEY { get; set; }
        public string ENTERED_BY { get; set; }
        public System.DateTime DATE_ENTERED { get; set; }
        public Nullable<System.DateTime> INTEREST_DATE { get; set; }
        public System.DateTime C_INTEREST_DATE { get; set; }
        public decimal INTEREST_ADDED { get; set; }
        public decimal C_INTEREST_ADDED { get; set; }
        public decimal CAB_INTEREST_ADDED { get; set; }
        public decimal C_CAB_INTEREST_ADDED { get; set; }
        public decimal PRINC_DUE { get; set; }
        public decimal C_PRINC_DUE { get; set; }
        public decimal LOAN_BALANCE { get; set; }
        public decimal C_LOAN_BALANCE { get; set; }
        public decimal CAB_FEE_BALANCE { get; set; }
        public decimal C_CAB_FEE_BALANCE { get; set; }
        public decimal COLLECTIONS_AMT { get; set; }
        public decimal C_COLLECTIONS_AMT { get; set; }
    }
}