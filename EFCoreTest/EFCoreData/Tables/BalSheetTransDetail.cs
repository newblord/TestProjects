using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class BalSheetTransDetail
    {
        public int BalsheetKey { get; set; }
        public int TransDetailKey { get; set; }
        public short Location { get; set; }

        public virtual BalSheet2 BalsheetKeyNavigation { get; set; }
    }
}
