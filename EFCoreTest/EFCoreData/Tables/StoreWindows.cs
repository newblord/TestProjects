using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class StoreWindows
    {
        public int StoreWindowsKey { get; set; }
        public short Location { get; set; }
        public string ComputerName { get; set; }
        public string CitrixName { get; set; }
        public string Report { get; set; }
        public string Receipt { get; set; }
        public string Agreement { get; set; }
        public string Dotmatrix { get; set; }
        public short? MoneyOrders { get; set; }
        public bool SharedPrinters { get; set; }
        public DateTime? SystemDate { get; set; }
        public DateTime? SystemDateSet { get; set; }
        public short MoFormsRemaining { get; set; }
        public string WindowsVersion { get; set; }
        public string TellerKeyboard { get; set; }
        public string CustomerKeyboard { get; set; }
        public string MoneyOrderComPort { get; set; }
    }
}
