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
    
    public partial class MPayLoanInSyncAdj
    {
        public int MPAY_LOAN_IN_SYNC_ADJ_KEY { get; set; }
        public System.DateTime DATE_ENTERED { get; set; }
        public string ENTERED_BY { get; set; }
        public int LOAN_KEY { get; set; }
        public string LOAN_STATUS { get; set; }
        public decimal LOAN_BALANCE { get; set; }
        public decimal RI_BALANCE { get; set; }
        public decimal PRINC_AMT { get; set; }
        public decimal CASH_AMT { get; set; }
        public decimal TRANS_FEE_AMT { get; set; }
        public bool CHARGE_TRANS_FEE { get; set; }
        public decimal LIEN_FEE_AMT { get; set; }
        public bool CHARGE_LIEN_FEE { get; set; }
        public Nullable<System.DateTime> ORIG_DUE_DATE { get; set; }
        public Nullable<System.DateTime> ADJUSTED_DUE_DATE { get; set; }
        public bool DEFAULTED { get; set; }
        public Nullable<System.DateTime> DEFAULT_DATE { get; set; }
        public decimal LAST_PAYMENT_AMT { get; set; }
        public Nullable<System.DateTime> LAST_PAYMENT_DATE { get; set; }
        public Nullable<System.DateTime> NEXT_DUE_DATE { get; set; }
        public decimal NEXT_DUE_AMT { get; set; }
        public Nullable<System.DateTime> PENDING_SCHED_ACH_SENT { get; set; }
        public decimal PENDING_SCHED_ACH_AMT { get; set; }
        public string C_LOAN_STATUS { get; set; }
        public decimal C_LOAN_BALANCE { get; set; }
        public decimal C_RI_BALANCE { get; set; }
        public decimal C_PRINC_AMT { get; set; }
        public decimal C_CASH_AMT { get; set; }
        public decimal C_TRANS_FEE_AMT { get; set; }
        public bool C_CHARGE_TRANS_FEE { get; set; }
        public decimal C_LIEN_FEE_AMT { get; set; }
        public bool C_CHARGE_LIEN_FEE { get; set; }
        public Nullable<System.DateTime> C_ORIG_DUE_DATE { get; set; }
        public Nullable<System.DateTime> C_ADJUSTED_DUE_DATE { get; set; }
        public bool C_DEFAULTED { get; set; }
        public Nullable<System.DateTime> C_DEFAULT_DATE { get; set; }
        public decimal C_LAST_PAYMENT_AMT { get; set; }
        public Nullable<System.DateTime> C_LAST_PAYMENT_DATE { get; set; }
        public Nullable<System.DateTime> C_NEXT_DUE_DATE { get; set; }
        public decimal C_NEXT_DUE_AMT { get; set; }
        public Nullable<System.DateTime> C_PENDING_SCHED_ACH_SENT { get; set; }
        public decimal C_PENDING_SCHED_ACH_AMT { get; set; }
        public int C_ADJ_CNT_INT { get; set; }
        public int C_ADJ_CNT_PENDING_ACH_INT { get; set; }
        public int C_ADJ_CNT_LP_MPAY_RECORD { get; set; }
        public Nullable<decimal> TRANS_FEE_COLORADO_POSTPONE_AMT { get; set; }
        public Nullable<decimal> C_TRANS_FEE_COLORADO_POSTPONE_AMT { get; set; }
        public decimal COLL_FEE_PAST_DUE_BAL { get; set; }
        public decimal LEGAL_FEE_PAST_DUE_BAL { get; set; }
        public decimal LOAN_FEE_DUE_BAL { get; set; }
        public decimal TRANS_FEE_DUE_BAL { get; set; }
        public decimal INTEREST_DUE_BAL { get; set; }
        public decimal PRINC_DUE_BAL { get; set; }
        public decimal C_COLL_FEE_PAST_DUE_BAL { get; set; }
        public decimal C_LEGAL_FEE_PAST_DUE_BAL { get; set; }
        public decimal C_LOAN_FEE_DUE_BAL { get; set; }
        public decimal C_TRANS_FEE_DUE_BAL { get; set; }
        public decimal C_INTEREST_DUE_BAL { get; set; }
        public decimal C_PRINC_DUE_BAL { get; set; }
        public decimal PAYMENT_DUE_BAL { get; set; }
        public decimal PAYMENT_PAST_DUE_BAL { get; set; }
        public decimal C_PAYMENT_DUE_BAL { get; set; }
        public decimal C_PAYMENT_PAST_DUE_BAL { get; set; }
        public Nullable<decimal> INVENTORY_AMT { get; set; }
        public Nullable<decimal> C_INVENTORY_AMT { get; set; }
        public decimal CAB_INTEREST_DUE_BAL { get; set; }
        public decimal CAB_COLL_FEE_PAST_DUE_BAL { get; set; }
        public decimal C_CAB_INTEREST_DUE_BAL { get; set; }
        public decimal C_CAB_COLL_FEE_PAST_DUE_BAL { get; set; }
        public decimal LOAN_AMT { get; set; }
        public decimal C_LOAN_AMT { get; set; }
        public decimal NSF_FEE_PAST_DUE_BAL { get; set; }
        public decimal C_NSF_FEE_PAST_DUE_BAL { get; set; }
        public Nullable<decimal> REBATE_AMT { get; set; }
        public Nullable<decimal> C_REBATE_AMT { get; set; }
        public Nullable<decimal> DISC_AMT { get; set; }
        public Nullable<decimal> C_DISC_AMT { get; set; }
        public Nullable<bool> IS_IN_LEGAL_STATUS { get; set; }
        public int CYCLES_PAST_DUE { get; set; }
        public int C_CYCLES_PAST_DUE { get; set; }
        public decimal PENDING_PMT_AMT { get; set; }
        public decimal C_PENDING_PMT_AMT { get; set; }
        public Nullable<System.DateTime> PENDING_PMT_DATE { get; set; }
        public Nullable<System.DateTime> C_PENDING_PMT_DATE { get; set; }
        public decimal PENDING_PMT_PRINC { get; set; }
        public decimal C_PENDING_PMT_PRINC { get; set; }
        public decimal PENDING_PMT_INTEREST_CAP { get; set; }
        public decimal C_PENDING_PMT_INTEREST_CAP { get; set; }
        public decimal PENDING_PMT_CAB_INTEREST_CAP { get; set; }
        public decimal C_PENDING_PMT_CAB_INTEREST_CAP { get; set; }
        public decimal INSURANCE_DUE_BAL { get; set; }
        public decimal C_INSURANCE_DUE_BAL { get; set; }
        public decimal DUE_DATE_PAYMENT_QUEUE_BAL { get; set; }
        public decimal C_DUE_DATE_PAYMENT_QUEUE_BAL { get; set; }
        public decimal INVENTORY_BAL { get; set; }
        public decimal C_INVENTORY_BAL { get; set; }
    }
}