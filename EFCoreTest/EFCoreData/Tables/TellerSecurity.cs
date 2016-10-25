using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class TellerSecurity
    {
        public int TellerSecurityKey { get; set; }
        public int TellerIdKey { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? EndedOnDate { get; set; }
        public bool IsTemporary { get; set; }
        public string SgValues { get; set; }
        public DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string UpdatedBy { get; set; }

        public virtual Tellerid TellerIdKeyNavigation { get; set; }
    }
}
