using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LoanApplicationProduct
    {
        public int LoanApplicationProductKey { get; set; }
        public int LoanApplicationKey { get; set; }
        public string LoanType { get; set; }
        public string ProductType { get; set; }
        public int? LoanProductKey { get; set; }
        public int? LoanProductConfigKey { get; set; }
        public int? LoanProductTilaKey { get; set; }
        public decimal? ApprovedAmt { get; set; }
        public decimal? SelectedAmt { get; set; }
        public bool Selected { get; set; }
        public byte? SelectedTerm { get; set; }
        public bool? Approved { get; set; }
        public string Detail { get; set; }
        public DateTime? PrimaryScoreDate { get; set; }
        public short? ModelUsed { get; set; }
        public decimal? FinalScore { get; set; }
        public int? ScoreSummaryKey { get; set; }

        public virtual LoanApplication LoanApplicationKeyNavigation { get; set; }
        public virtual LoanProductConfig LoanProductConfigKeyNavigation { get; set; }
        public virtual LoanProduct LoanProductKeyNavigation { get; set; }
        public virtual LoanProductTila LoanProductTilaKeyNavigation { get; set; }
    }
}
