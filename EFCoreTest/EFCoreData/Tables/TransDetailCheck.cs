using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class TransDetailCheck
    {
        public int TransDetailCheckKey { get; set; }
        public int TransDetailKey { get; set; }
        public short Location { get; set; }
        public string CheckFrom { get; set; }
        public string CheckTo { get; set; }
        public decimal CheckAmt { get; set; }
        public short CheckQty { get; set; }
        public byte CheckType { get; set; }
        public int? DrawerKey { get; set; }
        public string DepositMethod { get; set; }

        public virtual TransDetail TransDetailKeyNavigation { get; set; }
    }
}
