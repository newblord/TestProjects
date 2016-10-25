using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class UtilRecalcLog
    {
        public string RecalcType { get; set; }
        public short Location { get; set; }
        public DateTime DateEntered { get; set; }
        public string UserLogin { get; set; }
        public int UtilRecalcLogKey { get; set; }
    }
}
