using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LoanProductBlocked
    {
        public int LoanProductBlockedKey { get; set; }
        public DateTime? SpecificStartDate { get; set; }
        public DateTime? SpecificEndDate { get; set; }
        public byte DayOfWeek { get; set; }
        public byte TypeOfBlock { get; set; }
        public string BlockedUntilTime { get; set; }
        public string BlockedAfterTime { get; set; }
        public DateTime? DateToDelete { get; set; }
        public DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public int LoanProductKey { get; set; }
        public short Location { get; set; }

        public virtual LoanProductConfig LoanProductKeyNavigation { get; set; }
        public virtual Company LocationNavigation { get; set; }
    }
}
