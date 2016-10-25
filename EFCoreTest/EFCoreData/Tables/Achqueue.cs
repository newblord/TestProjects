using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class Achqueue
    {
        public int AchQueueKey { get; set; }
        public DateTime DateEntered { get; set; }
        public DateTime DateToSend { get; set; }
        public string Teller { get; set; }
        public int LoanKey { get; set; }
        public decimal Amount { get; set; }
        public string Aba { get; set; }
        public string Account { get; set; }
        public short AchReasonCode { get; set; }
        public bool IsCredit { get; set; }
        public decimal LoanBalance { get; set; }

        public virtual Banks AbaNavigation { get; set; }
        public virtual Achreason AchReasonCodeNavigation { get; set; }
        public virtual Loan LoanKeyNavigation { get; set; }
        public virtual Tellerid TellerNavigation { get; set; }
    }
}
