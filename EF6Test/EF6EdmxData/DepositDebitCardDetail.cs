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
    
    public partial class DepositDebitCardDetail
    {
        public int DEPOSIT_DEBIT_CARD_DETAIL_KEY { get; set; }
        public int DEPOSIT_DEBIT_CARD_KEY { get; set; }
        public int LOAN_KEY { get; set; }
        public Nullable<int> TRANS_DETAIL_KEY { get; set; }
        public bool REVERSED { get; set; }
        public string REVERSED_BY { get; set; }
        public Nullable<System.DateTime> REVERSED_DATE { get; set; }
    
        public virtual DepositDebitCard DepositDebitCard { get; set; }
    }
}
