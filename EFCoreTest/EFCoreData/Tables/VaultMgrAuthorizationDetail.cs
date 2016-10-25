using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class VaultMgrAuthorizationDetail
    {
        public int VmAuthDetailKey { get; set; }
        public int VmAuthKey { get; set; }
        public DateTime ApprovalTime { get; set; }
        public int? MessageId { get; set; }
        public int? CustomerKey { get; set; }
        public int? LoanKey { get; set; }
        public int? TransPosKey { get; set; }
        public decimal? OrigValue { get; set; }
        public decimal? AuthValue { get; set; }
        public bool IsCurrency { get; set; }
        public bool IsPercent { get; set; }
        public string MessageData { get; set; }
        public bool? IsVmAuth { get; set; }

        public virtual Customer CustomerKeyNavigation { get; set; }
        public virtual Loan LoanKeyNavigation { get; set; }
        public virtual DualApprovalMessage Message { get; set; }
        public virtual TransPos TransPosKeyNavigation { get; set; }
        public virtual VaultMgrAuthorization VmAuthKeyNavigation { get; set; }
    }
}
