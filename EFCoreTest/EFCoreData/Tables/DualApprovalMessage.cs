using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class DualApprovalMessage
    {
        public DualApprovalMessage()
        {
            VaultMgrAuthorizationDetail = new HashSet<VaultMgrAuthorizationDetail>();
        }

        public int DualApprovalMessageKey { get; set; }
        public string ApprovalMessage { get; set; }
        public int MessageId { get; set; }

        public virtual ICollection<VaultMgrAuthorizationDetail> VaultMgrAuthorizationDetail { get; set; }
    }
}
