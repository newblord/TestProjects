using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class BalSheet2
    {
        public BalSheet2()
        {
            BalSheetColumns2 = new HashSet<BalSheetColumns2>();
            BalSheetTransDetail = new HashSet<BalSheetTransDetail>();
            EndOfDayRpt = new HashSet<EndOfDayRpt>();
        }

        public int BalsheetKey { get; set; }
        public short Location { get; set; }
        public string Teller { get; set; }
        public DateTime DateEntered { get; set; }
        public DateTime BusinessDate { get; set; }
        public bool Exported { get; set; }
        public bool? TrecsExport { get; set; }
        public bool? AdastraExported { get; set; }

        public virtual ICollection<BalSheetColumns2> BalSheetColumns2 { get; set; }
        public virtual ICollection<BalSheetTransDetail> BalSheetTransDetail { get; set; }
        public virtual ICollection<EndOfDayRpt> EndOfDayRpt { get; set; }
        public virtual Tellerid TellerNavigation { get; set; }
    }
}
