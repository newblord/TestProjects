using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebCallChatCannedResponses
    {
        public int WebCallChatCannedResponsesKey { get; set; }
        public string Description { get; set; }
        public short SortPriority { get; set; }
        public bool Deleted { get; set; }
    }
}
