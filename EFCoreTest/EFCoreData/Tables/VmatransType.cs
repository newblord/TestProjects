using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class VmatransType
    {
        public VmatransType()
        {
            VaultMgrAuthorization = new HashSet<VaultMgrAuthorization>();
        }

        public int VmaTransTypeKey { get; set; }
        public string VmaDesc { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }

        public virtual ICollection<VaultMgrAuthorization> VaultMgrAuthorization { get; set; }
    }
}
