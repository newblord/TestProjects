using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class OptPlusCardRipayment
    {
        public int OptplusCardRiPaymentKey { get; set; }
        public int OptplusCardDetailKey { get; set; }
        public int RisreptKey { get; set; }
        public int TransDetailKey { get; set; }
        public short Location { get; set; }
        public string Teller { get; set; }
        public DateTime DateEntered { get; set; }
        public string Note { get; set; }
        public decimal PaidAmt { get; set; }
        public bool Reversed { get; set; }
        public DateTime? ReversedDate { get; set; }
        public short PaymentMethod { get; set; }
        public byte TransCode { get; set; }

        public virtual OptPlusCardDetail OptplusCardDetailKeyNavigation { get; set; }
        public virtual Risrept RisreptKeyNavigation { get; set; }
    }
}
