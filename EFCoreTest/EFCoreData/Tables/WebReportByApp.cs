using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebReportByApp
    {
        public int WebReportByAppKey { get; set; }
        public int LoanApplicationKey { get; set; }
        public DateTime DateReported { get; set; }
        public int CustomerKey { get; set; }
        public int LoanKey { get; set; }
        public string SourceAppDescription { get; set; }
        public string Zipcode { get; set; }
        public string Msa { get; set; }
        public string DefState { get; set; }
        public int Location { get; set; }
        public bool? IsNewCustomer { get; set; }
        public bool? IsAppComplete { get; set; }
        public bool? IsAppApproved { get; set; }
        public bool? IsAppForceApproved { get; set; }
        public decimal? NetIncome { get; set; }
        public decimal? ApprovedAmt { get; set; }
        public decimal? PrincAmt { get; set; }
        public decimal? FeeAmt { get; set; }
        public string WebReferralMethod { get; set; }
        public string Source { get; set; }
    }
}
