using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class TellerTitleEdit
    {
        public int TitleEditKey { get; set; }
        public int TitleKey { get; set; }
        public string Modification { get; set; }
        public DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }

        public virtual TellerTitle TitleKeyNavigation { get; set; }
    }
}
