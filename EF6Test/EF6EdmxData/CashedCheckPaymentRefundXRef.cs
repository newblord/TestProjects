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
    
    public partial class CashedCheckPaymentRefundXRef
    {
        public int CASHED_CHECK_PAYMENT_REFUND_XREF_KEY { get; set; }
        public int REFUND_CASHED_CHECK_PAYMENT_KEY { get; set; }
        public int REFUNDED_CASHED_CHECK_PAYMENT_KEY { get; set; }
        public decimal REFUND_AMOUNT { get; set; }
    
        public virtual CashedCheckPayment CashedCheckPayment { get; set; }
        public virtual CashedCheckPayment CashedCheckPayment1 { get; set; }
    }
}