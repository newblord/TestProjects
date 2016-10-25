using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebCallCsrreportColumn
    {
        public WebCallCsrreportColumn()
        {
            WebCallCsrreportColumnRarr = new HashSet<WebCallCsrreportColumnRarr>();
        }

        public int WebCallCsrreportColumnsKey { get; set; }
        public string ColumnName { get; set; }

        public virtual ICollection<WebCallCsrreportColumnRarr> WebCallCsrreportColumnRarr { get; set; }
    }
}
