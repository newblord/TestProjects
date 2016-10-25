using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class Receipt
    {
        public int ReceiptKey { get; set; }
        public int TransDetailKey { get; set; }
        public string ReceiptData { get; set; }
        public DateTime DateEntered { get; set; }

        public virtual TransDetail TransDetailKeyNavigation { get; set; }
    }
}
