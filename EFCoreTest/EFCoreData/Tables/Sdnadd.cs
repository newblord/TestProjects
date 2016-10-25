using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class Sdnadd
    {
        public int? EntNum { get; set; }
        public int AddNum { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string AddRemarks { get; set; }

        public virtual Sdnmain EntNumNavigation { get; set; }
    }
}
