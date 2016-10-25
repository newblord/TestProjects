using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LoanChkAcctChange
    {
        public int ChkAcctChangeKey { get; set; }
        public int LoanKey { get; set; }
        public int CustomerKey { get; set; }
        public short Location { get; set; }
        public string Teller { get; set; }
        public DateTime DateEntered { get; set; }
        public int IssuerKey { get; set; }
        public bool DirectDeposit { get; set; }
        public int? PrvCreditCardKey { get; set; }
        public int? NewCreditCardKey { get; set; }
        public bool? PrvDeclinedAutoPay { get; set; }
        public bool? NewDeclinedAutoPay { get; set; }
        public int PrvIssuerKey { get; set; }
        public bool PrvDirectDeposit { get; set; }
        public string IssuerChkAcctChangeReason { get; set; }
        public string CcardChkAcctChangeReason { get; set; }
        public string Note { get; set; }
    }
}
