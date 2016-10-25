using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class RiccUpdates
    {
        public int RiccUpdatesKey { get; set; }
        public string Sql { get; set; }
        public bool Processed { get; set; }
        public int? RiccHoldId { get; set; }
        public string UpdateTable { get; set; }
    }
}
