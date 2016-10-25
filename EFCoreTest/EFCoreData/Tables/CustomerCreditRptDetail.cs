using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CustomerCreditRptDetail
    {
        public int CrDetailKey { get; set; }
        public int CreditRptKey { get; set; }
        public DateTime DateEntered { get; set; }
        public string LineType { get; set; }
        public string LineText { get; set; }
        public short LineOrder { get; set; }

        public virtual CustomerCreditRpt CreditRptKeyNavigation { get; set; }
    }
}
