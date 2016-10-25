using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebCallApplicationStatusHistory
    {
        public int WebCallApplicationStatusHistoryKey { get; set; }
        public int LoanApplicationKey { get; set; }
        public int WebCallRarrHistoryKey { get; set; }
        public int LoanApplicationStatus { get; set; }
        public DateTime? ApplicationStatusChangeDate { get; set; }
        public DateTime Createdate { get; set; }
    }
}
