using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LocationConverted
    {
        public int LocationConvertedKey { get; set; }
        public DateTime? DateEntered { get; set; }
        public int Location { get; set; }
        public bool RunOpenLoanCheck { get; set; }
    }
}
