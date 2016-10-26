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
    
    public partial class Xrr
    {
        public int rrkey { get; set; }
        public int ckey { get; set; }
        public int ikey { get; set; }
        public Nullable<int> lkey { get; set; }
        public Nullable<int> cckey { get; set; }
        public Nullable<System.DateTime> DATE_no_time { get; set; }
        public Nullable<System.DateTime> ad_astra_date { get; set; }
        public string product_type { get; set; }
        public System.DateTime DATE { get; set; }
        public string TLR { get; set; }
        public short LOCATION { get; set; }
        public Nullable<decimal> AMOUNT { get; set; }
        public decimal SURCHG { get; set; }
        public Nullable<System.DateTime> FOLLOWUP { get; set; }
        public int CUSTOMER_KEY { get; set; }
        public int ISSUER_KEY { get; set; }
        public Nullable<System.DateTime> MANUAL_ACH_DATE { get; set; }
        public string MANUAL_TELLER { get; set; }
        public int RISREPT_KEY { get; set; }
        public Nullable<int> LOAN_KEY { get; set; }
        public decimal RI_BALANCE { get; set; }
        public byte PRA { get; set; }
        public int ris_type_id { get; set; }
        public Nullable<int> Ris_Audit_ID { get; set; }
        public bool STOP_PAYMENT { get; set; }
        public bool reversed { get; set; }
        public Nullable<System.DateTime> reversed_date { get; set; }
        public Nullable<int> CASHED_CHECK_KEY { get; set; }
        public Nullable<int> DOS_REFNO { get; set; }
        public string DOS_MIGRATED_ID { get; set; }
        public Nullable<decimal> MANUAL_ACH_AMOUNT { get; set; }
        public Nullable<int> MANUAL_ACH_PTP { get; set; }
        public Nullable<System.DateTime> LAST_CALL_DATE { get; set; }
        public Nullable<short> LAST_CALL_HOST_CODE { get; set; }
        public bool DO_NOT_CALL_HOME { get; set; }
        public bool DO_NOT_CALL_WORK { get; set; }
        public bool DO_NOT_CALL_CELL { get; set; }
        public bool DO_NOT_SEND_LETTERS { get; set; }
        public Nullable<bool> DO_NOT_CALL_VERBAL_DNC { get; set; }
        public Nullable<int> OPTPLUS_CARD_DETAIL_KEY { get; set; }
        public string REFERENCE { get; set; }
        public byte RISK_ASSESSMENT { get; set; }
        public int COLLECTION_AGENCY_KEY { get; set; }
        public int ASSIGNMENT_NUMBER { get; set; }
        public string CR_TELLER { get; set; }
        public int REASON_FOR_ARREARS_KEY { get; set; }
        public Nullable<System.DateTime> LAST_DCARD_ATTEMPT_DATE { get; set; }
        public int RI_URGENT_NOTE_KEY { get; set; }
        public bool KEEP_WITH_AGENCY { get; set; }
        public Nullable<System.DateTime> AD_ASTRA_ASSIGNED_DATE { get; set; }
        public string X1 { get; set; }
        public string ra_AUDIT { get; set; }
        public string ra_DESC { get; set; }
        public string ra_SHORT { get; set; }
        public Nullable<bool> ra_DISPLAYED { get; set; }
        public Nullable<bool> ra_IS_AD_ASTRA { get; set; }
        public Nullable<bool> ra_IS_IN_LEGAL_STATUS { get; set; }
        public string X2 { get; set; }
        public string rt_TYPE { get; set; }
        public string rt_DESC { get; set; }
        public string X3 { get; set; }
        public string c_LASTNAME { get; set; }
        public string c_FIRSTNAME { get; set; }
    }
}