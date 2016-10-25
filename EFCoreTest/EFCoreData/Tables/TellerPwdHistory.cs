using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class TellerPwdHistory
    {
        public int TellerPwdHistoryKey { get; set; }
        public string Teller { get; set; }
        public DateTime DateEntered { get; set; }
        public string Password { get; set; }
        public string EnteredBy { get; set; }
        public bool IsReset { get; set; }

        public virtual Tellerid TellerNavigation { get; set; }
    }
}
