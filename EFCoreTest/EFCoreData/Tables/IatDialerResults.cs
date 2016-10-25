using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class IatDialerResults
    {
        public int HostCode { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public int RisTaskId { get; set; }
        public string CuroNote { get; set; }
        public int? TaskActionResultKey { get; set; }
        public int? AgentActionKey { get; set; }
        public int? AgentResultKey1 { get; set; }
    }
}
