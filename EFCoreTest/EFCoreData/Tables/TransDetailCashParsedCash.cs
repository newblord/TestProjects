using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class TransDetailCashParsedCash
    {
        public int TransDetailCashParsedCashKey { get; set; }
        public int TransDetailCashKey { get; set; }
        public int DenominationKey { get; set; }
        public decimal Amount { get; set; }

        public virtual Denomination DenominationKeyNavigation { get; set; }
        public virtual TransDetailCash TransDetailCashKeyNavigation { get; set; }
    }
}
