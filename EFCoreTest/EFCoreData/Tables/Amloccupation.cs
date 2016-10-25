using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class Amloccupation
    {
        public Amloccupation()
        {
            AmladditionalParty = new HashSet<AmladditionalParty>();
        }

        public int AmlOccupationKey { get; set; }
        public int? VisitorKey { get; set; }
        public int? TransDetailKey { get; set; }
        public string Occupation { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }
        public int OccupationReason { get; set; }

        public virtual ICollection<AmladditionalParty> AmladditionalParty { get; set; }
        public virtual TransDetail TransDetailKeyNavigation { get; set; }
        public virtual Visitor VisitorKeyNavigation { get; set; }
    }
}
