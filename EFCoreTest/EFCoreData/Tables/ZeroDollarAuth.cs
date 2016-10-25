using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class ZeroDollarAuth
    {
        public int CreditCardTransKey { get; set; }
        public int VisitorKey { get; set; }
        public bool CreditcardCoolingOff { get; set; }
        public bool VisitorCoolingOff { get; set; }
        public bool IsAcctVerifyOnly { get; set; }

        public virtual CreditCardTrans CreditCardTransKeyNavigation { get; set; }
        public virtual Visitor VisitorKeyNavigation { get; set; }
    }
}
