using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class AchdetailAddendum
    {
        public int AchDetailAddendumKey { get; set; }
        public int AchDetailKey { get; set; }
        public string RecordType { get; set; }
        public string AddendaTypeCode { get; set; }
        public string ReturnNocCode { get; set; }
        public string OriginalTraceNumber { get; set; }
        public string DateOfDeath { get; set; }
        public string OriginalRfdiRtNumber { get; set; }
        public string AddendaInformation { get; set; }
        public string TraceNumber { get; set; }

        public virtual Achdetail AchDetailKeyNavigation { get; set; }
    }
}
