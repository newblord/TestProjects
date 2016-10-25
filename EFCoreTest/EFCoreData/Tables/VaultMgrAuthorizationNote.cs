using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class VaultMgrAuthorizationNote
    {
        public int VmaNoteKey { get; set; }
        public int VmAuthKey { get; set; }
        public string Note { get; set; }
        public int ScoreSummaryKey { get; set; }

        public virtual VaultMgrAuthorization VmAuthKeyNavigation { get; set; }
    }
}
