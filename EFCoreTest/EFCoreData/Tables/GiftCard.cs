using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class GiftCard
    {
        public int GiftCardKey { get; set; }
        public DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public int ServiceDetailKey { get; set; }
        public short Location { get; set; }
        public decimal CardAmount { get; set; }
        public string CardNumber { get; set; }
        public string CardData { get; set; }
        public int? LoanKey { get; set; }

        public virtual Company LocationNavigation { get; set; }
        public virtual ServiceDetail ServiceDetailKeyNavigation { get; set; }
    }
}
