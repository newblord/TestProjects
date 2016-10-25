using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class PromiseToPayTimeSlotConfig
    {
        public byte PtpCcTimeSlot { get; set; }
        public byte PtpRunTime { get; set; }
        public string PtpTimeslotDesc { get; set; }
    }
}
