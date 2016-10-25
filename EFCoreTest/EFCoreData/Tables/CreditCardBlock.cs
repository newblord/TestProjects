using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CreditCardBlock
    {
        public int CreditCardBlockKey { get; set; }
        public int BlockReasonKey { get; set; }
        public DateTime? DateEntered { get; set; }
        public bool IsToken { get; set; }
        public short? CreditCardResultCodeKey { get; set; }
        public int CountAtBlock { get; set; }
        public string CardNum { get; set; }

        public virtual BlockReason BlockReasonKeyNavigation { get; set; }
    }
}
