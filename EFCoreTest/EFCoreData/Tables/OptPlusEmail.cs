using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class OptPlusEmail
    {
        public OptPlusEmail()
        {
            OptPlusEmailLocation = new HashSet<OptPlusEmailLocation>();
        }

        public int OptplusEmailKey { get; set; }
        public string EmailAddress { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }

        public virtual ICollection<OptPlusEmailLocation> OptPlusEmailLocation { get; set; }
    }
}
