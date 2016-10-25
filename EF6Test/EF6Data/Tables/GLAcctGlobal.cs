namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GLAcctGlobal")]
    public partial class GLAcctGlobal
    {
        [Key]
        public int GL_ACCT_GLOBAL_KEY { get; set; }

        public int? CASH_IN_STORE_ACCT { get; set; }

        public int? DEPOSIT_BAGS_ACCT { get; set; }

        public int? GOLD_INVESTMENT_ACCT { get; set; }

        public int? GOLD_TRANSIT_ACCT { get; set; }

        public int? GOLD_REVENUE_ACCT { get; set; }

        public int? GOLD_PROCESS_FEE_ACCT { get; set; }

        public int? GOLD_FEES_PAID_ACCT { get; set; }

        public int? GOLD_LOSSES_ACCT { get; set; }

        public int? CURRENCY_EXCHANGE_ON_CHECK_ACCT { get; set; }

        public int? CURRENCY_EXCHANGE_FEE_ACCT { get; set; }

        public int? CURRENCY_EXCHANGE_GAINLOSS_ACCT { get; set; }

        public int? OVER_SHORT_ACCT { get; set; }

        public int? CHECK_RI_ACCT { get; set; }

        public int? CHECK_COLL_ACCT { get; set; }

        public int? COURTESY_PAYOUT_ACCT { get; set; }

        public int? OPTPLUS_RETURNS_ACCT { get; set; }

        public int? OPTPLUS_COLL_ACCT { get; set; }

        public int? ADASTRA_COMMISSIONS_AR_ACCT { get; set; }

        public int? ADASTRA_COMMISSIONS_AP_ACCT { get; set; }

        public int? ADASTRA_COMMISSIONS_FEES_ACCT { get; set; }

        public int? ADASTRA_COMMISSIONS_EXPENSE_ACCT { get; set; }

        public int? ADASTRA_CENTRAL_TRUST_ACCT { get; set; }

        public int? ADASTRA_TRUST_PROCEEDS_AP_ACCT { get; set; }

        public int? ADASTRA_COLLECTION_AGENCY_RECEIVABLE_ACCT { get; set; }

        public int? ADASTRA_CASH_AND_CHECKS_ACCT { get; set; }

        public int? ADASTRA_BAD_DEBT_CHECK_ACCT { get; set; }

        public int? CASHED_CHECK_DISCOUNT_ACCT { get; set; }

        public int? CASHED_CHECK_FLAT_FEES_ACCT { get; set; }

        public int? CASHED_CHECK_PCT_FEES_ACCT { get; set; }

        public int? CASHED_CHECK_POST_DATED_ACCT { get; set; }

        public int? CCARD_FEE_ACCT { get; set; }

        public int? SALES_TAX_ACCT { get; set; }

        public int? SPAY_INTERNET_REVENUE_ACCT { get; set; }

        public int? MPAY_INTERNET_REVENUE_ACCT { get; set; }

        public int? OEND_INTERNET_REVENUE_ACCT { get; set; }

        public int? SPAY_INTERNET_RETURNS_ACCT { get; set; }

        public int? MPAY_INTERNET_RETURNS_ACCT { get; set; }

        public int? OEND_INTERNET_RETURNS_ACCT { get; set; }

        public int? SPAY_INTERNET_COLLECTIONS_ACCT { get; set; }

        public int? MPAY_INTERNET_COLLECTIONS_ACCT { get; set; }

        public int? OEND_INTERNET_COLLECTIONS_ACCT { get; set; }

        public int? SPAY_INTERNET_CREDIT_CLEARING_ACCT { get; set; }

        public int? MPAY_INTERNET_CREDIT_CLEARING_ACCT { get; set; }

        public int? OEND_INTERNET_CREDIT_CLEARING_ACCT { get; set; }

        public int? INTERNAL_SHORT_ACCT { get; set; }
    }
}
