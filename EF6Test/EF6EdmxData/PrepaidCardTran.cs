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
    
    public partial class PrepaidCardTran
    {
        public int PREPAID_CARD_TRANS_KEY { get; set; }
        public Nullable<int> TRANS_DETAIL_KEY { get; set; }
        public int WS_OPERATION_KEY { get; set; }
        public int WS_RESPONSE_KEY { get; set; }
        public string OPERATION_PARMS { get; set; }
        public string OPERATION_RESULTS { get; set; }
        public System.DateTime DATE_ENTERED { get; set; }
        public string TELLER { get; set; }
        public Nullable<int> CUSTOMER_KEY { get; set; }
        public Nullable<int> CreditCard_Key { get; set; }
        public string COMPUTER_NAME { get; set; }
        public string SERVER_NAME { get; set; }
        public Nullable<decimal> AMOUNT { get; set; }
        public Nullable<int> PREPAID_CARD_TRANS_ACTION_KEY { get; set; }
        public Nullable<short> LOCATION { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual PrepaidCardTransAction PrepaidCardTransAction { get; set; }
        public virtual WSOperation WSOperation { get; set; }
        public virtual WSResponse WSResponse { get; set; }
    }
}
