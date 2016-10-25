using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class TellerComputer
    {
        public int TellerComputerKey { get; set; }
        public string Teller { get; set; }
        public string ComputerName { get; set; }

        public virtual Tellerid TellerNavigation { get; set; }
    }
}
