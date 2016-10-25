using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebLeadGenStatistics
    {
        public int WebLeadGenKey { get; set; }
        public int NumApproved { get; set; }
        public int NumLoans { get; set; }
        public DateTime DateEntered { get; set; }
        public int WebLeadGenStatisticsKey { get; set; }

        public virtual WebLeadGen WebLeadGenKeyNavigation { get; set; }
    }
}
