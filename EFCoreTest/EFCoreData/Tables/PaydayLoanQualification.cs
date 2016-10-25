using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class PaydayLoanQualification
    {
        public int PaydayLoanQualificationKey { get; set; }
        public int CustomerKey { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }
        public short Location { get; set; }
        public bool BankStatement { get; set; }
        public bool BankDirectDeposit { get; set; }
        public bool BankContacted { get; set; }
        public bool IncomeStatement { get; set; }
        public bool IncomePayStub { get; set; }
        public bool IncomeDeposits { get; set; }
        public bool HomePhoneWorking { get; set; }

        public virtual Customer CustomerKeyNavigation { get; set; }
    }
}
