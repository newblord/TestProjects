using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class EndOfDayRpt
    {
        public EndOfDayRpt()
        {
            EndOfDayRptDetail = new HashSet<EndOfDayRptDetail>();
        }

        public int EodrKey { get; set; }
        public int BalsheetKey { get; set; }
        public DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public bool ReGen { get; set; }

        public virtual ICollection<EndOfDayRptDetail> EndOfDayRptDetail { get; set; }
        public virtual BalSheet2 BalsheetKeyNavigation { get; set; }
    }
}
