using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class BalSheetColumns2
    {
        public int BscKey { get; set; }
        public int BalsheetKey { get; set; }
        public int GlAcct { get; set; }
        public byte AcctType { get; set; }
        public decimal DbAmount { get; set; }
        public decimal CrAmount { get; set; }
        public string AcctTypeDesc { get; set; }

        public virtual BalSheet2 BalsheetKeyNavigation { get; set; }
        public virtual Glacct GlAcctNavigation { get; set; }
    }
}
