using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CpiuExceptionReport
    {
        public int CpiuExceptionReportKey { get; set; }
        public int CpiuDetailKey { get; set; }
        public DateTime DatetimeEntered { get; set; }
        public string Message { get; set; }
        public short ExceptionType { get; set; }

        public virtual CpiuDetail CpiuDetailKeyNavigation { get; set; }
    }
}
