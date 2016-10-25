using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CollBonusTasks
    {
        public string Tellerid { get; set; }
        public byte? Product { get; set; }
        public DateTime? Tdate { get; set; }
        public byte? Task { get; set; }
        public int? Riage { get; set; }
        public int CollBonusTasksKey { get; set; }
    }
}
