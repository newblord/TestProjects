using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class SpaySchedRolloverDetail
    {
        public int SpaySchedRolloverDetailKey { get; set; }
        public int SpaySchedRolloverKey { get; set; }
        public DateTime RolloverDate { get; set; }
        public decimal OptBuydownAmt { get; set; }
        public byte RolloverNum { get; set; }
        public decimal LoanAmt { get; set; }
        public decimal PrincAmt { get; set; }
        public decimal LoanAtr { get; set; }
        public DateTime DueDate { get; set; }
        public int? AchHistoryKey { get; set; }
        public int? TransDetailKey { get; set; }
        public int? CancelLoanPaymentKey { get; set; }
        public int? VoidLoanPaymentKey { get; set; }
        public int? SchedLoanPaymentKey { get; set; }

        public virtual SpaySchedRollover SpaySchedRolloverKeyNavigation { get; set; }
    }
}
