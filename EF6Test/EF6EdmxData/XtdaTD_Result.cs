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
    
    public partial class XtdaTD_Result
    {
        public int tdkey { get; set; }
        public int tdakey { get; set; }
        public Nullable<int> tpkey { get; set; }
        public int TRANS_DETAIL_ACCT_KEY { get; set; }
        public int TRANS_DETAIL_KEY { get; set; }
        public short LOCATION { get; set; }
        public byte ACCT_TYPE { get; set; }
        public decimal AMOUNT { get; set; }
        public int GL_ACCT { get; set; }
        public Nullable<decimal> DEBIT { get; set; }
        public Nullable<decimal> CREDIT { get; set; }
        public string Spell_ACCT_TYPE { get; set; }
        public string GL { get; set; }
        public string gl_DESCRIPTON { get; set; }
        public Nullable<bool> gl_IS_ADASTRA { get; set; }
        public Nullable<bool> gl_IS_TITLE_TYPE { get; set; }
        public Nullable<bool> gl_IS_NON_CASH_ACCT { get; set; }
        public string TD { get; set; }
        public System.DateTime td_DATE_ENTERED { get; set; }
        public short td_LOCATION { get; set; }
        public byte td_TRANS_CODE { get; set; }
        public string Spell_td_TRANS_CODE { get; set; }
        public string td_PRODUCT_TYPE { get; set; }
        public string td_LOAN_TYPE { get; set; }
        public string TP { get; set; }
        public Nullable<decimal> tp_CASH_RECV { get; set; }
        public Nullable<decimal> tp_CASH_PAID { get; set; }
        public Nullable<decimal> tp_CCARD_RECV { get; set; }
        public Nullable<decimal> tp_CCARD_PAID { get; set; }
    }
}
