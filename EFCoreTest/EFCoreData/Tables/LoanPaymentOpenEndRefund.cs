using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LoanPaymentOpenEndRefund
    {
        public int LoanPaymentOpenEndRefundKey { get; set; }
        public int AccountingLoanPaymentKey { get; set; }
        public int LoanPaymentRefundXrefKey { get; set; }
        public decimal PastDueTransFeeRefunded { get; set; }
        public decimal PastDueLienFeeRefunded { get; set; }
        public decimal PastDueActivityFeeRefunded { get; set; }
        public decimal PastDueCollFeeRefunded { get; set; }
        public decimal PastDueInterestRefunded { get; set; }
        public decimal PastDuePrincRefunded { get; set; }
        public decimal PastDueCsoLenderCollFeeRefunded { get; set; }
        public decimal PastDueCsoLenderInterestRefunded { get; set; }
        public decimal CurrDueTransFeeRefunded { get; set; }
        public decimal CurrDueLienFeeRefunded { get; set; }
        public decimal CurrDueActivityFeeRefunded { get; set; }
        public decimal CurrDueInterestRefunded { get; set; }
        public decimal CurrDuePrincRefunded { get; set; }
        public decimal CurrDueCsoLenderInterestRefunded { get; set; }
        public decimal NextDueTransFeeRefunded { get; set; }
        public decimal NextDueLienFeeRefunded { get; set; }
        public decimal NextDueActivityFeeRefunded { get; set; }
        public decimal NextDueInterestRefunded { get; set; }
        public decimal NextDuePrincRefunded { get; set; }
        public decimal NextDueCsoLenderInterestRefunded { get; set; }
        public decimal NotDueTransFeeRefunded { get; set; }
        public decimal NotDueLienFeeRefunded { get; set; }
        public decimal NotDueActivityFeeRefunded { get; set; }
        public decimal NotDueInterestRefunded { get; set; }
        public decimal NotDuePrincRefunded { get; set; }
        public decimal NotDueCsoLenderInterestRefunded { get; set; }

        public virtual LoanPaymentRefundXref LoanPaymentRefundXrefKeyNavigation { get; set; }
    }
}
