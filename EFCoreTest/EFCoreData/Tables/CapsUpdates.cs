using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CapsUpdates
    {
        public int CapsUpdatesKey { get; set; }
        public string Sql { get; set; }
        public bool Processed { get; set; }
        public int CapsHoldKey { get; set; }
        public int CapsRunKey { get; set; }
        public string UpdateTable { get; set; }
    }
}
