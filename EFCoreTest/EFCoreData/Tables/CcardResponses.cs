using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CcardResponses
    {
        public int CcardResponseKey { get; set; }
        public int CustomerKey { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }
        public short Location { get; set; }
        public byte Response { get; set; }
        public bool IsNew { get; set; }

        public virtual Customer CustomerKeyNavigation { get; set; }
        public virtual Company LocationNavigation { get; set; }
        public virtual Tellerid TellerNavigation { get; set; }
    }
}
