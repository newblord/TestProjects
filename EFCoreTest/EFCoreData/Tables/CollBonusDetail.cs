using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CollBonusDetail
    {
        public string Tellerid { get; set; }
        public int? Location { get; set; }
        public long? Rikey { get; set; }
        public DateTime? Rdate { get; set; }
        public DateTime? Pdate { get; set; }
        public DateTime? Cdate { get; set; }
        public byte? Timeframe { get; set; }
        public decimal? Creditamt { get; set; }
        public byte? Product { get; set; }
        public byte? Paytype { get; set; }
        public bool? FecBec { get; set; }
        public int? Riage { get; set; }
        public byte? Task { get; set; }
        public string Reference { get; set; }
        public int CollBonusDetailKey { get; set; }
    }
}
