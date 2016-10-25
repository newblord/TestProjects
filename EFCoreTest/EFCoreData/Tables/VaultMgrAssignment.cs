using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class VaultMgrAssignment
    {
        public int VmAssignKey { get; set; }
        public short Location { get; set; }
        public string LoggedOnInits { get; set; }
        public string CurrentVmInits { get; set; }
        public string NewVmInits { get; set; }
        public string OtherAuthInits { get; set; }
        public DateTime TimeAssigned { get; set; }

        public virtual Company LocationNavigation { get; set; }
    }
}
