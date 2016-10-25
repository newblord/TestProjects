using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class TellerTitle
    {
        public TellerTitle()
        {
            Tellerid = new HashSet<Tellerid>();
            TellerTitleEdit = new HashSet<TellerTitleEdit>();
        }

        public int TitleKey { get; set; }
        public string Title { get; set; }
        public bool Active { get; set; }
        public bool Deleted { get; set; }
        public DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }

        public virtual ICollection<Tellerid> Tellerid { get; set; }
        public virtual ICollection<TellerTitleEdit> TellerTitleEdit { get; set; }
    }
}
