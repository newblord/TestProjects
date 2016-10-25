using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class RiccPayments
    {
        public int Id { get; set; }
        public int LoanKey { get; set; }
        public decimal Amount { get; set; }
        public int RiccPaymentsKey { get; set; }
        public int? OptplusCardDetailKey { get; set; }
    }
}
