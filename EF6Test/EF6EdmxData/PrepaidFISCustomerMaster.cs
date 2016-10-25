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
    
    public partial class PrepaidFISCustomerMaster
    {
        public int CUSTOMER_MASTER_KEY { get; set; }
        public Nullable<int> CUSTOMER_KEY { get; set; }
        public Nullable<short> PROCESS_STATUS { get; set; }
        public Nullable<System.DateTime> DATE_UPDATED { get; set; }
        public Nullable<int> TOP_CLIENT_ID { get; set; }
        public string TOP_CLIENT_NAME { get; set; }
        public Nullable<int> ISSUER_CLIENT_ID { get; set; }
        public string CLIENT_NAME { get; set; }
        public Nullable<int> PROGRAM_ID { get; set; }
        public string PROGRAM_NAME { get; set; }
        public Nullable<int> SUBPROGRAM_ID { get; set; }
        public string SUBPROGRAM_NAME { get; set; }
        public Nullable<int> BIN_NUM { get; set; }
        public string BIN_CURR_ALPHA { get; set; }
        public string BIN_CURR_CODE { get; set; }
        public Nullable<int> PACKAGE_ID { get; set; }
        public string PACKAGE_NAME { get; set; }
        public string PRIME_ACCT_NUM { get; set; }
        public string CARD_ACCT_NUM { get; set; }
        public Nullable<System.DateTime> ACTIVATE_DATE { get; set; }
        public Nullable<int> CARD_STATUS { get; set; }
        public string CARDHOLDER_FIRSTNAME { get; set; }
        public string CARDHOLDER_LASTNAME { get; set; }
        public string CARDHOLDER_MIDDLENAME { get; set; }
        public string MAIL_ADDR_LINE1 { get; set; }
        public string MAIL_ADDR_LINE2 { get; set; }
        public string MAIL_CITY { get; set; }
        public string MAIL_STATE { get; set; }
        public string MAIL_ZIP { get; set; }
        public string MAIL_CTRY { get; set; }
        public Nullable<int> CARDHOLDER_CTRY_CODE { get; set; }
        public string CARDHOLDER_PHONE { get; set; }
        public string CARDHOLDER_PHONE_EXT { get; set; }
        public Nullable<System.DateTime> CAN_CREATE_DATE { get; set; }
        public Nullable<System.DateTime> CAN_EXPIRE_DATE { get; set; }
        public Nullable<int> MARKET_SEG_ID { get; set; }
        public string MARKET_SEG_DESC { get; set; }
        public Nullable<int> REQUEST_CODE { get; set; }
        public Nullable<int> SOURCE_CODE { get; set; }
        public Nullable<System.DateTime> WCSUTC_INSERTED { get; set; }
        public Nullable<System.DateTime> CAN_STATUS_EFFECTIVE_DATE { get; set; }
        public Nullable<System.DateTime> CARDHOLDER_DOB { get; set; }
        public string CARDHOLDER_EMAIL { get; set; }
        public string CARDHOLDER_SSN { get; set; }
        public string CARDHOLDER_SUFFIX { get; set; }
        public string CARD_STATUS_DESC { get; set; }
        public string CLIENT_MEMO { get; set; }
        public Nullable<System.DateTime> ACCOUNT_CREATE_DATE { get; set; }
        public string CAN_PROXY_NUM { get; set; }
        public string PRIVACY_OPT_OUT { get; set; }
        public string PRIMARY_RELATIONSHIP { get; set; }
        public string REQUEST_CODE_DESC { get; set; }
        public string SOURCE_CODE_DESC { get; set; }
        public Nullable<int> PERSON_ID { get; set; }
        public string CLIENT_UNIQUE_ID { get; set; }
        public string ALERTS_EMAIL { get; set; }
        public string DIRECT_ACCESS_NUMBER { get; set; }
        public string SMS_MOBILE_PHONE { get; set; }
        public string PAN_PROXY_NUM { get; set; }
        public Nullable<System.DateTime> INIT_VALUE_LOAD { get; set; }
        public Nullable<System.DateTime> PERSON_CREATE_DATE { get; set; }
    
        public virtual Customer Customer { get; set; }
    }
}
