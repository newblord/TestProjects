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
    
    public partial class MPayLoan
    {
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
        public Nullable<int> INSURANCE_STATUS_KEY { get; set; }
        public Nullable<System.DateTime> RO_CANCEL_INSURANCE_REQUEST_DATE { get; set; }
        public string RO_CANCEL_INSURANCE_REQUEST_BY { get; set; }
        public decimal DUE_DATE_PAYMENT_QUEUE_BAL { get; set; }
        public decimal INVENTORY_BAL { get; set; }
    
        public virtual CreditCard CreditCard { get; set; }
        public virtual Loan Loan { get; set; }
    }
}