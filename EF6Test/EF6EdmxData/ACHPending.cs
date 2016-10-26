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
    
    public partial class ACHPending
    {
        public int ACH_PENDING_KEY { get; set; }
        public System.DateTime DATE_ENTERED { get; set; }
        public int CUSTOMER_KEY { get; set; }
        public int LOCATION { get; set; }
        public int RISREPT_KEY { get; set; }
        public decimal RI_BALANCE { get; set; }
        public decimal ACH_AMOUNT { get; set; }
        public Nullable<int> LOAN_KEY { get; set; }
        public Nullable<int> CASHED_CHECK_KEY { get; set; }
        public Nullable<int> PTP_DETAIL_KEY { get; set; }
        public System.DateTime PROJ_SEND_DATE { get; set; }
        public Nullable<int> PROCESS_CONFIG_INSTANCE_KEY { get; set; }
        public bool IS_MARKED_ACH_BLOCK { get; set; }
        public bool IS_MARKED_STOP_PAYMENT { get; set; }
        public bool IS_DIRECT_DEPOSIT { get; set; }
        public bool IS_PAY_INFO_COMPLETE { get; set; }
        public Nullable<int> RI_AGE { get; set; }
        public string AUDIT_CODE { get; set; }
        public string BANK_ABA { get; set; }
        public string ACCT_NO { get; set; }
        public bool IS_MANUAL_ACH { get; set; }
        public bool HAS_CC { get; set; }
        public bool IS_AD_ASTRA { get; set; }
        public Nullable<System.DateTime> CALC_PAY_DATE { get; set; }
        public string STATEMENT_ID { get; set; }
        public int ACH_PRESENTMENT_KEY { get; set; }
        public int BP_STEP_DATA_KEY { get; set; }
    
        public virtual Customer Customer { get; set; }
    }
}