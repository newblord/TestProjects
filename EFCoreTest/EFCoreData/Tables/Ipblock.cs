using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class Ipblock
    {
        public int IpBlockKey { get; set; }
        public long NumericIp { get; set; }
        public DateTime DateAdded { get; set; }
        public int Hits { get; set; }
        public string Notes { get; set; }
        public bool IsBlocked { get; set; }
        public DateTime? BlockChangeDate { get; set; }
        public string Description { get; set; }
    }
}
