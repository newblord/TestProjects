using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class Sdnmain
    {
        public Sdnmain()
        {
            Sdnadd = new HashSet<Sdnadd>();
            Sdnalt = new HashSet<Sdnalt>();
        }

        public int EntNum { get; set; }
        public string SdnName { get; set; }
        public string SdnType { get; set; }
        public string Program { get; set; }
        public string Title { get; set; }
        public string Remarks { get; set; }

        public virtual ICollection<Sdnadd> Sdnadd { get; set; }
        public virtual ICollection<Sdnalt> Sdnalt { get; set; }
    }
}
