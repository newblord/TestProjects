using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class Ddistatus
    {
        public Ddistatus()
        {
            AuddisreasonCodeMapping = new HashSet<AuddisreasonCodeMapping>();
            Ddi = new HashSet<Ddi>();
        }

        public int DdiStatusKey { get; set; }
        public int StatusCode { get; set; }
        public string Display { get; set; }
        public string CodeDescription { get; set; }

        public virtual ICollection<AuddisreasonCodeMapping> AuddisreasonCodeMapping { get; set; }
        public virtual ICollection<Ddi> Ddi { get; set; }
    }
}
