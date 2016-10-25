using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class InitGllist
    {
        public int InitGlListKey { get; set; }
        public short TransCode { get; set; }
        public short Location { get; set; }
        public int GlAcct { get; set; }
        public DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }

        public virtual Glacct GlAcctNavigation { get; set; }
    }
}
