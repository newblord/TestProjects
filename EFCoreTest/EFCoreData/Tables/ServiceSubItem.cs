using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class ServiceSubItem
    {
        public int ServiceSubitemKey { get; set; }
        public int ServiceMasterKeyRequisite { get; set; }
        public int ServiceMasterKeySubitem { get; set; }
        public DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? LastUpdated { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ServiceMaster ServiceMasterKeyRequisiteNavigation { get; set; }
        public virtual ServiceMaster ServiceMasterKeySubitemNavigation { get; set; }
    }
}
