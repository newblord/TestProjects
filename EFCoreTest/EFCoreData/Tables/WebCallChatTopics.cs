using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class WebCallChatTopics
    {
        public int WebCallChatTopicsKey { get; set; }
        public string Description { get; set; }
        public short SortPriority { get; set; }
        public bool Deleted { get; set; }
    }
}
