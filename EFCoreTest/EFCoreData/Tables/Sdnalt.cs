using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class Sdnalt
    {
        public int? EntNum { get; set; }
        public int AltNum { get; set; }
        public string AltType { get; set; }
        public string AltName { get; set; }
        public string AltRemarks { get; set; }

        public virtual Sdnmain EntNumNavigation { get; set; }
    }
}
