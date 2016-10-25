using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class MostatusHistory
    {
        public string Error { get; set; }
        public string Monumber { get; set; }
        public byte PrinterNumber { get; set; }
        public string Teller { get; set; }
        public decimal Amount { get; set; }
        public short StatusCode { get; set; }
        public DateTime SubmitTime { get; set; }
        public short Location { get; set; }
        public int SequenceNo { get; set; }
        public string TellerFirstname { get; set; }
        public string TellerLastname { get; set; }
    }
}
