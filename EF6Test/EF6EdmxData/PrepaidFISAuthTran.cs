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
    
    public partial class PrepaidFISAuthTran
    {
        public int AUTH_TRANS_KEY { get; set; }
        public Nullable<int> CUSTOMER_KEY { get; set; }
        public Nullable<short> PROCESS_STATUS { get; set; }
        public Nullable<System.DateTime> DATE_UPDATED { get; set; }
        public Nullable<int> ISSUER_CLIENT_ID { get; set; }
        public string ISSUER_CLIENT_NAME { get; set; }
        public Nullable<int> SUBPROGRAM_ID { get; set; }
        public string SUBPROGRAM_NAME { get; set; }
        public Nullable<int> BIN_NUM { get; set; }
        public string BIN_CURR_ALPHA { get; set; }
        public string BIN_CURR_CODE { get; set; }
        public string BANK_NAME { get; set; }
        public string PRIME_ACCT_NUM { get; set; }
        public string CARD_ACCT_NUM { get; set; }
        public string TXN_UID { get; set; }
        public Nullable<int> TXN_TYPE_CODE { get; set; }
        public string TXN_TYPE_NAME { get; set; }
        public Nullable<int> PURSE_NUM { get; set; }
        public string PURSE_NAME { get; set; }
        public Nullable<System.DateTime> TRANS_DATETIME { get; set; }
        public string AUTHORIZE_CODE { get; set; }
        public Nullable<int> REQUEST_CODE { get; set; }
        public string REQUEST_DESC { get; set; }
        public Nullable<int> RESPONSE_CODE { get; set; }
        public string RESPONSE_DESC { get; set; }
        public Nullable<int> REASON_CODE { get; set; }
        public string REASON_DESC { get; set; }
        public Nullable<int> SOURCE_CODE { get; set; }
        public string SOURCE_DESC { get; set; }
        public Nullable<decimal> AUTHORIZE_AMT { get; set; }
        public Nullable<decimal> TXN_LOCAL_AMT { get; set; }
        public Nullable<short> TRANS_SIGN { get; set; }
        public Nullable<int> TRANS_CURR_CODE { get; set; }
        public string TRANS_CURR_ALPHA { get; set; }
        public string RETRIEVAL_REFNO { get; set; }
        public Nullable<short> REVERSED { get; set; }
        public string AVS_INFO { get; set; }
        public string AVS_RESP_CODE { get; set; }
        public Nullable<short> PIN { get; set; }
        public string POS_DATA { get; set; }
        public Nullable<int> POS_ENTRY_CODE { get; set; }
        public string POS_ENTRY_DESC { get; set; }
        public string MERC_MCC_CODE { get; set; }
        public string MCC_DESCRIPTION { get; set; }
        public string MERC_CURR_ALPHA { get; set; }
        public string MERC_CURR_CODE { get; set; }
        public string MERC_NAME { get; set; }
        public string MERC_NUM { get; set; }
        public string MERC_STREET { get; set; }
        public string MERC_CITY { get; set; }
        public string MERC_PROV { get; set; }
        public string MERC_STATE { get; set; }
        public string MERC_ZIP { get; set; }
        public string MERC_CTRY_CODE { get; set; }
        public string MERC_CTRY_NAME { get; set; }
        public string TERM_NUM { get; set; }
        public string ACQ_ID { get; set; }
        public string CAN_PROXY_NUM { get; set; }
        public string CLIENT_UNIQUE_ID { get; set; }
        public Nullable<decimal> AUTH_BAL { get; set; }
        public Nullable<decimal> SETTLE_BAL { get; set; }
        public Nullable<decimal> TOLERANCE_AMT { get; set; }
        public string CARD_VERIFY_METHOD { get; set; }
        public string CVC_RESPONSE { get; set; }
        public string PAN_PROXY_NUM { get; set; }
    
        public virtual Customer Customer { get; set; }
    }
}
