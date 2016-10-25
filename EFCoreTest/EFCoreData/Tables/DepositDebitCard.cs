using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class DepositDebitCard
    {
        public DepositDebitCard()
        {
            DepositDebitCardDetail = new HashSet<DepositDebitCardDetail>();
        }

        public int DepositDebitCardKey { get; set; }
        public short Location { get; set; }
        public string Teller { get; set; }
        public DateTime DateEntered { get; set; }
        public short DebitCntr { get; set; }
        public decimal DebitTot { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public bool Completed { get; set; }

        public virtual ICollection<DepositDebitCardDetail> DepositDebitCardDetail { get; set; }
    }
}
