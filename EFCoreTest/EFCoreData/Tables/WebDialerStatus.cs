using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebDialerStatus
    {
        public int WebDialerStatusKey { get; set; }
        public short Status { get; set; }
        public DateTime DateModified { get; set; }
    }
}
