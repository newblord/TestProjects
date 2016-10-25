using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class DialerResultCodes
    {
        public int DialerResultsId { get; set; }
        public string ResultCode { get; set; }
        public string Description { get; set; }
        public int? SpeedyResultCode { get; set; }
    }
}
