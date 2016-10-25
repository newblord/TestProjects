using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class AuddisreasonCodeMapping
    {
        public string AuddisReasonCode { get; set; }
        public int DdiStatusCode { get; set; }

        public virtual Ddistatus DdiStatusCodeNavigation { get; set; }
    }
}
