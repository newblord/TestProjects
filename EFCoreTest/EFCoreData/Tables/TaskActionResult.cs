using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class TaskActionResult
    {
        public TaskActionResult()
        {
            TaskActionResultXref = new HashSet<TaskActionResultXref>();
        }

        public int TaskActionResultKey { get; set; }
        public int AgentActionKey { get; set; }
        public int AgentResultKey1 { get; set; }
        public int AgentResultKey2 { get; set; }
        public int RisAuditId { get; set; }
        public bool AllowNote { get; set; }
        public int FollowupMax { get; set; }
        public bool ShowPaymentForm { get; set; }
        public bool? ShowPtpForm { get; set; }
        public bool CollectorBonusRpt { get; set; }
        public bool OptAuditCatCode { get; set; }
        public byte? CbrOutOrInCall { get; set; }
        public int FollowupDefault { get; set; }
        public bool RequireReasonForArrears { get; set; }
        public bool ShowFlodForm { get; set; }
        public byte HotKey { get; set; }
        public bool ShowRepoVendorList { get; set; }

        public virtual ICollection<TaskActionResultXref> TaskActionResultXref { get; set; }
        public virtual AgentAction AgentActionKeyNavigation { get; set; }
    }
}
