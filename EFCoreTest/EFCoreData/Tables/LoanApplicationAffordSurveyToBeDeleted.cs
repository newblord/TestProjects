using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LoanApplicationAffordSurveyToBeDeleted
    {
        public int? LoanApplicationKey { get; set; }
        public int? MonthlyMortgage { get; set; }
        public int? MonthlyUtilities { get; set; }
        public int? MonthlyOtherDebt { get; set; }
        public int? RolloverRequestKey { get; set; }
        public int LoanApplicationAffordSurveyKey { get; set; }
        public int? VisitorKey { get; set; }
        public decimal? NetIncome { get; set; }
        public DateTime DateEntered { get; set; }
        public bool IsCustomerReviewed { get; set; }

        public virtual LoanApplication LoanApplicationKeyNavigation { get; set; }
        public virtual RolloverRequest RolloverRequestKeyNavigation { get; set; }
        public virtual Visitor VisitorKeyNavigation { get; set; }
    }
}
