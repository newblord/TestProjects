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
    
    public partial class AutoBankingReport
    {
        public int AUTOBANKINGREPORT_KEY { get; set; }
        public int EXTERNAL_APPS_KEY { get; set; }
        public System.DateTime START_DATE { get; set; }
        public string REFERENCE { get; set; }
        public string ISSUER { get; set; }
        public Nullable<short> LOCATION { get; set; }
        public string ACCT { get; set; }
        public string BANK_ABA { get; set; }
        public string CHECK_NO { get; set; }
        public Nullable<decimal> AMOUNT { get; set; }
        public Nullable<decimal> BALANCE { get; set; }
        public string AUDIT_CAT { get; set; }
        public string RESULTS { get; set; }
        public Nullable<System.DateTime> RI_DATE { get; set; }
    }
}
