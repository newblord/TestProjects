using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class MpayPayInFull
    {
        public int MpayPayInFullKey { get; set; }
        public int LoanKey { get; set; }
        public string Teller { get; set; }
        public DateTime DateEntered { get; set; }
        public int PaymentNum { get; set; }
        public string PifStatus { get; set; }
        public int? TransDetailKey { get; set; }
        public DateTime? DisabledDate { get; set; }
        public string DisabledBy { get; set; }
    }
}
