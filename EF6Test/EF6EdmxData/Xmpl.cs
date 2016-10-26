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
    
    public partial class Xmpl
    {
        public int mplkey { get; set; }
        public int lkey { get; set; }
        public int ckey { get; set; }
        public int tdkey { get; set; }
        public Nullable<int> ikey { get; set; }
        public Nullable<System.DateTime> payoff_date { get; set; }
        public string X1 { get; set; }
        public int MPAY_LOAN_KEY { get; set; }
        public int LOAN_KEY { get; set; }
        public decimal ANNUAL_RATE_PCT { get; set; }
        public decimal MONTHLY_RATE_PCT { get; set; }
        public decimal DAILY_RATE_PCT { get; set; }
        public decimal ACTUARIAL_APR { get; set; }
        public byte ODD_DAYS_INTEREST_CNT { get; set; }
        public decimal ODD_DAYS_INTEREST_AMT { get; set; }
        public byte TRANS_FEE_PCT { get; set; }
        public byte CYCLE_DAYS { get; set; }
        public byte COLLECTION_DAYS { get; set; }
        public byte AMORT_PAYMENT_CNT { get; set; }
        public decimal SCHED_LAST_PAYMENT_AMT { get; set; }
        public Nullable<System.DateTime> SCHED_LAST_PAYMENT_DATE { get; set; }
        public decimal LAST_PAYMENT_AMT { get; set; }
        public Nullable<System.DateTime> LAST_PAYMENT_DATE { get; set; }
        public decimal NEXT_DUE_AMT { get; set; }
        public Nullable<System.DateTime> NEXT_DUE_DATE { get; set; }
        public decimal EST_FINANCE_CHARGE { get; set; }
        public decimal CREDIT_LIMIT { get; set; }
        public Nullable<System.DateTime> CLOSED_DATE { get; set; }
        public bool SUSPEND_INTEREST { get; set; }
        public decimal PENDING_SCHED_ACH_AMT { get; set; }
        public decimal TRANS_FEE_AMT { get; set; }
        public Nullable<int> CREDITCARD_KEY { get; set; }
        public decimal PAYMENT_PLAN_FEE { get; set; }
        public int PAYMENT_PLAN_LOAN_KEY { get; set; }
        public bool IS_BUSINESS_LOAN { get; set; }
        public string TRANS_FEE_METHOD { get; set; }
        public decimal TRANS_FEE_COLORADO_POSTPONE_AMT { get; set; }
        public bool DECLINED_AUTO_PAY { get; set; }
        public byte SET_INACTIVE_ON_DAY { get; set; }
        public byte SET_INACTIVE_ON_MISSED_PAYMENT_COUNT { get; set; }
        public byte SET_INACTIVE_ON_DAY_AFTER_MISSED_PAYMENT_COUNT { get; set; }
        public byte SELECTED_CYCLE_WEEKS { get; set; }
        public decimal COLL_FEE_PAST_DUE_BAL { get; set; }
        public decimal LEGAL_FEE_PAST_DUE_BAL { get; set; }
        public decimal LOAN_FEE_DUE_BAL { get; set; }
        public decimal TRANS_FEE_DUE_BAL { get; set; }
        public decimal INTEREST_DUE_BAL { get; set; }
        public decimal PRINC_DUE_BAL { get; set; }
        public decimal PAYMENT_DUE_BAL { get; set; }
        public decimal PAYMENT_PAST_DUE_BAL { get; set; }
        public Nullable<decimal> COLLECTIONS_BAL { get; set; }
        public decimal CAB_ANNUAL_RATE_PCT { get; set; }
        public decimal CAB_MONTHLY_RATE_PCT { get; set; }
        public decimal CAB_DAILY_RATE_PCT { get; set; }
        public decimal CAB_COLL_FEE_PAST_DUE_BAL { get; set; }
        public decimal CAB_INTEREST_DUE_BAL { get; set; }
        public Nullable<System.DateTime> RESUME_INTEREST_DATE { get; set; }
        public bool RESUME_INTEREST_ON_PAYMENT { get; set; }
        public string APPLY_DISCOUNT_TO { get; set; }
        public Nullable<System.DateTime> INACTIVE_DATE { get; set; }
        public decimal RI_FEE_PER_DEFAULT { get; set; }
        public byte RI_FEES_PER_LOAN { get; set; }
        public decimal NSF_FEE_PAST_DUE_BAL { get; set; }
        public bool MATCH_SPAY_RATE { get; set; }
        public bool CYCLE_DAYS_FIXED { get; set; }
        public bool CYCLE_DUE_DATE_MATCH { get; set; }
        public bool IS_DAY_AFTER_DUE { get; set; }
        public byte MAX_RI_FEES_PER_LOAN_SERIES { get; set; }
        public bool RI_FEE_REQUIRES_BANK_ACCOUNT { get; set; }
        public Nullable<System.DateTime> ORIG_MATURITY_DATE { get; set; }
        public System.DateTime ADJUSTED_MATURITY_DATE { get; set; }
        public int CYCLES_PAST_DUE { get; set; }
        public Nullable<decimal> DAILY_INTEREST_AMT { get; set; }
        public decimal INSURANCE_DUE_BAL { get; set; }
        public string X2 { get; set; }
        public string LOAN_TYPE { get; set; }
        public short LOCATION { get; set; }
        public string TELLER { get; set; }
        public System.DateTime DATE_ENTERED { get; set; }
        public bool COURTESY_CALL { get; set; }
        public bool DEFAULTED { get; set; }
        public Nullable<System.DateTime> DEFAULT_DATE { get; set; }
        public string LOAN_STATUS { get; set; }
        public decimal LOAN_BALANCE { get; set; }
        public decimal LOAN_AMT { get; set; }
        public decimal CASH_AMT { get; set; }
        public decimal PRINC_AMT { get; set; }
        public string CHECK_NO { get; set; }
        public bool DIRECT_DEPOSIT { get; set; }
        public string PRODUCT_TYPE { get; set; }
        public string ORIG_CODE { get; set; }
        public Nullable<int> ORIG_LOAN_KEY { get; set; }
        public Nullable<int> PAID_LOAN_KEY { get; set; }
        public Nullable<int> PAYMENT_PLAN_KEY { get; set; }
        public short ROLLOVER_NUM { get; set; }
        public decimal RATE_PCT { get; set; }
        public decimal DISC_AMT { get; set; }
        public decimal REBATE_AMT { get; set; }
        public decimal GRACE_AMT { get; set; }
        public decimal FEE_AMT { get; set; }
        public decimal L_TRANS_FEE_AMT { get; set; }
        public decimal LIEN_FEE_AMT { get; set; }
        public bool CHARGE_TRANS_FEE { get; set; }
        public bool CHARGE_LIEN_FEE { get; set; }
        public decimal TOT_FEE_AMT { get; set; }
        public decimal INSURANCE_FEE_AMT { get; set; }
        public System.DateTime ORIG_DUE_DATE { get; set; }
        public System.DateTime ADJUSTED_DUE_DATE { get; set; }
        public System.DateTime CALC_DUE_DATE { get; set; }
        public System.DateTime LOAN_STATUS_DATE { get; set; }
        public bool REVERSED { get; set; }
        public Nullable<System.DateTime> REVERSED_DATE { get; set; }
        public Nullable<decimal> ORIG_APR { get; set; }
        public Nullable<int> DRAWERZ_KEY { get; set; }
        public bool JOINT_LOAN { get; set; }
        public string PRINT_LANGUAGE { get; set; }
        public Nullable<int> DWDOCID { get; set; }
        public bool DOCLOST { get; set; }
        public string DW_LOAN_NO { get; set; }
    }
}