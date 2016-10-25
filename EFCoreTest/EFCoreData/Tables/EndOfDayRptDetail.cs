using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class EndOfDayRptDetail
    {
        public int EodrDetKey { get; set; }
        public int EodrKey { get; set; }
        public short OrderNum { get; set; }
        public string EodrDesc { get; set; }
        public string Account1 { get; set; }
        public string Qty1 { get; set; }
        public string Amount1 { get; set; }
        public string Fee1 { get; set; }
        public string Account2 { get; set; }
        public string Qty2 { get; set; }
        public string Amount2 { get; set; }
        public string Fee2 { get; set; }
        public bool Header { get; set; }
        public bool Footer { get; set; }

        public virtual EndOfDayRpt EodrKeyNavigation { get; set; }
    }
}
