using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebReportByLoan
    {
        public int WebReportByLoanKey { get; set; }
        public int LoanKey { get; set; }
        public int? CustomerKey { get; set; }
        public DateTime DateEntered { get; set; }
        public DateTime? AdjustedDueDate { get; set; }
        public bool? IsCustomerNew { get; set; }
        public bool? IsLoanRollover { get; set; }
        public bool? IsLoanOpen { get; set; }
        public bool? IsLoanDefaulted { get; set; }
        public bool? IsPaidInFull { get; set; }
        public string Msa { get; set; }
        public int? Location { get; set; }
        public string DefState { get; set; }
        public decimal? PrincAmt { get; set; }
        public decimal? FeeAmt { get; set; }
        public bool? IsFirstInternetLoan { get; set; }
        public string Source { get; set; }
        public bool? IsApprovedByScoring { get; set; }
        public decimal? CashAmt { get; set; }
        public decimal? NetIncome { get; set; }
        public string Gender { get; set; }
        public DateTime? Dob { get; set; }
    }
}
