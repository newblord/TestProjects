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
    
    public partial class ZeroDollarAuth
    {
        public int CREDIT_CARD_TRANS_KEY { get; set; }
        public int VISITOR_KEY { get; set; }
        public bool CREDITCARD_COOLING_OFF { get; set; }
        public bool VISITOR_COOLING_OFF { get; set; }
        public bool IS_ACCT_VERIFY_ONLY { get; set; }
    
        public virtual CreditCardTran CreditCardTran { get; set; }
        public virtual Visitor Visitor { get; set; }
    }
}
