using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class TellerIdedit
    {
        public int TellerIdEditKey { get; set; }
        public string Teller { get; set; }
        public short OldSecuritygroupKey { get; set; }
        public short NewSecuritygroupKey { get; set; }
        public DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
    }
}
