using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class Riccconfig
    {
        public int RiccConfigKey { get; set; }
        public string AuditCategories { get; set; }
        public string Locations { get; set; }
        public short AgeFrom { get; set; }
        public short AgeTo { get; set; }
        public bool IncludeNetspend { get; set; }
        public bool IncludeDebit { get; set; }
        public decimal Balance { get; set; }
        public byte NumberThreads { get; set; }
        public bool ProcessSpay { get; set; }
        public bool ProcessMpay { get; set; }
        public bool ProcessOend { get; set; }
    }
}
