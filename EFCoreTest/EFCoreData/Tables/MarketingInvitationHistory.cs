using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class MarketingInvitationHistory
    {
        public int MarketingInvitationHistoryKey { get; set; }
        public long ReservationCode { get; set; }
        public DateTime DateEntered { get; set; }
        public int Attributes { get; set; }
        public string Comments { get; set; }
    }
}
