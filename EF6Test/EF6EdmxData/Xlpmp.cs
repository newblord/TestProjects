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
    
    public partial class Xlpmp
    {
        public int lpmpkey { get; set; }
        public int lpkey { get; set; }
        public int lkey { get; set; }
        public int tdkey { get; set; }
        public int ckey { get; set; }
        public short lp_LOCATION { get; set; }
        public string lp_PRODUCT_TYPE { get; set; }
        public string lp_LOAN_TYPE { get; set; }
        public decimal lp_PAID_AMT { get; set; }
        public byte lp_TRANS_CODE { get; set; }
        public string Spell_TRANS_CODE { get; set; }
        public short lp_PAYMENT_METHOD { get; set; }
        public string Spell_PAYMENT_METHOD { get; set; }
        public bool lp_REVERSED { get; set; }
        public string lp_TELLER { get; set; }
        public Nullable<System.DateTime> lp_REVERSED_DATE { get; set; }
        public System.DateTime lp_DATE_ENTERED { get; set; }
        public Nullable<System.DateTime> lp_DATE_ENTERED_no_time { get; set; }
        public System.DateTime de { get; set; }
        public int LOAN_PAYMENT_MPAY_KEY { get; set; }
        public int LOAN_PAYMENT_KEY { get; set; }
        public bool ADD_TO_COLL { get; set; }
        public bool REM_FROM_COLL { get; set; }
        public decimal PENDING_SCHED_ACH_AMT { get; set; }
        public bool IS_CO_EARLY_PAYOFF_REBATE { get; set; }
        public decimal COLL_FEE_PAST_DUE_PAID { get; set; }
        public decimal LEGAL_FEE_PAST_DUE_PAID { get; set; }
        public decimal LOAN_FEE_DUE_PAID { get; set; }
        public decimal TRANS_FEE_DUE_PAID { get; set; }
        public decimal INTEREST_DUE_PAID { get; set; }
        public decimal PRINC_DUE_PAID { get; set; }
        public decimal PAYMENT_DUE_PAID { get; set; }
        public decimal PAYMENT_PAST_DUE_PAID { get; set; }
        public decimal CAB_COLL_FEE_PAST_DUE_PAID { get; set; }
        public decimal CAB_INTEREST_DUE_PAID { get; set; }
        public bool IS_SCHEDULED_PAYMENT { get; set; }
        public bool IS_DAY_AFTER_DUE_PAYMENT { get; set; }
        public decimal NSF_FEE_PAST_DUE_PAID { get; set; }
        public decimal INSURANCE_DUE_PAID { get; set; }
    }
}
