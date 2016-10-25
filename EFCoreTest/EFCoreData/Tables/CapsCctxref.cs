using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CapsCctxref
    {
        public int CreditCardTransKey { get; set; }
        public int CapsHoldKey { get; set; }
        public bool Approved { get; set; }
        public bool Posted { get; set; }
        public decimal Amt { get; set; }

        public virtual CapsHold CapsHoldKeyNavigation { get; set; }
    }
}
