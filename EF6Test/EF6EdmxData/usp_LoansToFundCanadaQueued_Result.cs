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
    
    public partial class usp_LoansToFundCanadaQueued_Result
    {
        public Nullable<int> ACH_SENT_KEY { get; set; }
        public int ACH_BANK_KEY { get; set; }
        public string ACH_BANK_NAME { get; set; }
        public bool IS_INTERNET { get; set; }
        public bool IS_ADASTRA { get; set; }
        public string DEBIT_OR_CREDIT { get; set; }
        public int ISSUER_KEY { get; set; }
        public string BANK_ID { get; set; }
        public string ACCT_NO { get; set; }
        public int CUSTOMER_KEY { get; set; }
        public string FIRSTNAME { get; set; }
        public string LASTNAME { get; set; }
        public int ACH_HISTORY_KEY { get; set; }
        public Nullable<decimal> ACH_AMOUNT { get; set; }
        public short LOCATION { get; set; }
        public Nullable<int> LOAN_KEY { get; set; }
        public Nullable<int> ACH_GROUP_KEY { get; set; }
        public string ACH_NUMBER { get; set; }
    }
}