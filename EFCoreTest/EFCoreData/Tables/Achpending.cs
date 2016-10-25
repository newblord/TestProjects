using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class Achpending
    {
        public int AchPendingKey { get; set; }
        public DateTime DateEntered { get; set; }
        public int CustomerKey { get; set; }
        public int Location { get; set; }
        public int RisreptKey { get; set; }
        public decimal RiBalance { get; set; }
        public decimal AchAmount { get; set; }
        public int? LoanKey { get; set; }
        public int? CashedCheckKey { get; set; }
        public int? PtpDetailKey { get; set; }
        public DateTime ProjSendDate { get; set; }
        public int? ProcessConfigInstanceKey { get; set; }
        public bool IsMarkedAchBlock { get; set; }
        public bool IsMarkedStopPayment { get; set; }
        public bool IsDirectDeposit { get; set; }
        public bool IsPayInfoComplete { get; set; }
        public int? RiAge { get; set; }
        public string AuditCode { get; set; }
        public string BankAba { get; set; }
        public string AcctNo { get; set; }
        public bool IsManualAch { get; set; }
        public bool HasCc { get; set; }
        public bool IsAdAstra { get; set; }
        public DateTime? CalcPayDate { get; set; }
        public string StatementId { get; set; }
        public int AchPresentmentKey { get; set; }
        public int BpStepDataKey { get; set; }

        public virtual Customer CustomerKeyNavigation { get; set; }
    }
}
