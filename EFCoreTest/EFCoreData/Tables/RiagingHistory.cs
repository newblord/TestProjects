using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class RiagingHistory
    {
        public int RiAgingHistoryKey { get; set; }
        public DateTime DateEntered { get; set; }
        public byte EventType { get; set; }
        public DateTime EventDate { get; set; }
        public int RisreptKey { get; set; }
        public int CustomerKey { get; set; }
        public int LoanKey { get; set; }
        public decimal LoanPrincAmt { get; set; }
        public decimal RiBalance { get; set; }
        public bool IsPayoff { get; set; }
        public decimal MinPaymentNeeded { get; set; }
        public decimal PaidAmt { get; set; }
        public int PaymentMethod { get; set; }
        public string Teller { get; set; }
        public int? CollStrategy { get; set; }
        public byte RiskAssessment { get; set; }
        public bool VoluntaryPtp { get; set; }
        public int? LoanpaymentKey { get; set; }
        public int? CustEventNum { get; set; }
        public int? LoanEventNum { get; set; }

        public virtual Customer CustomerKeyNavigation { get; set; }
        public virtual Loan LoanKeyNavigation { get; set; }
        public virtual Risrept RisreptKeyNavigation { get; set; }
        public virtual Tellerid TellerNavigation { get; set; }
    }
}
