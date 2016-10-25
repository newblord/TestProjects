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
    
    public partial class OptPlusRDFPostedTran
    {
        public string PROGRAM_ID { get; set; }
        public string ACCOUNT_ID { get; set; }
        public string CARD_ID { get; set; }
        public string TRANS_DATE { get; set; }
        public string TRANS_CODE { get; set; }
        public Nullable<decimal> TRANS_AMT { get; set; }
        public string TRANS_SIGN { get; set; }
        public string CURRENCY_CODE { get; set; }
        public string AUTH_CODE { get; set; }
        public string POST_DATE { get; set; }
        public string NETWORK_CODE { get; set; }
        public string MERCHANT_NUM { get; set; }
        public string MERCHANT_NAME { get; set; }
        public string MERCHANT_CATEGORY { get; set; }
        public string MERCHANT_COUNTRY { get; set; }
        public Nullable<decimal> INTER_FEE_AMT { get; set; }
        public string EXT_TRANS_ID { get; set; }
        public string USER_DATA1 { get; set; }
        public string USER_DATA2 { get; set; }
        public Nullable<int> CUSTOMER_KEY { get; set; }
        public Nullable<int> OPTPLUS_MERCHANT_KEY { get; set; }
        public int POSTED_TRANS_KEY { get; set; }
        public Nullable<System.DateTime> DATE_UPDATED { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual OptPlusMerchant OptPlusMerchant { get; set; }
    }
}
