using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CreditCardXref
    {
        public int CreditcardxrefKey { get; set; }
        public int CustomerKey { get; set; }
        public string OriginalPrn { get; set; }
        public string IdNo { get; set; }
        public byte CardBrand { get; set; }
        public int? CreditCardKey { get; set; }

        public virtual CreditCards CreditCardKeyNavigation { get; set; }
        public virtual Customer CustomerKeyNavigation { get; set; }
    }
}
