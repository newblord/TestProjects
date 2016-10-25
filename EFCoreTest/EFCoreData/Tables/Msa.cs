using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class Msa
    {
        public Msa()
        {
            UsZipcodes = new HashSet<UsZipcodes>();
        }

        public string MsaCode { get; set; }
        public string Typ { get; set; }
        public string Name { get; set; }
        public string Cmsa { get; set; }
        public double? Population { get; set; }

        public virtual ICollection<UsZipcodes> UsZipcodes { get; set; }
    }
}
