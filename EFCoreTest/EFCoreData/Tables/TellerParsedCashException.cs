using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class TellerParsedCashException
    {
        public int TellerParsedcashexceptionKey { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }
        public short Location { get; set; }
        public decimal TransactionAmount { get; set; }
        public decimal EnteredAmount { get; set; }
        public int? CustomerKey { get; set; }
        public int? TransactionKey { get; set; }
    }
}
