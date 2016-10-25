using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class VaultMgrAuthorization
    {
        public VaultMgrAuthorization()
        {
            VaultMgrAuthorizationDetail = new HashSet<VaultMgrAuthorizationDetail>();
            VaultMgrAuthorizationNote = new HashSet<VaultMgrAuthorizationNote>();
        }

        public int VmAuthKey { get; set; }
        public short Location { get; set; }
        public string LoggedOnInits { get; set; }
        public string CurrentVmInits { get; set; }
        public string OtherAuthInits { get; set; }
        public DateTime TimeAuthorized { get; set; }
        public decimal TransAmt { get; set; }
        public int TransRightsKey { get; set; }
        public int VmaTransTypeKey { get; set; }

        public virtual ICollection<VaultMgrAuthorizationDetail> VaultMgrAuthorizationDetail { get; set; }
        public virtual ICollection<VaultMgrAuthorizationNote> VaultMgrAuthorizationNote { get; set; }
        public virtual Company LocationNavigation { get; set; }
        public virtual VmatransType VmaTransTypeKeyNavigation { get; set; }
    }
}
