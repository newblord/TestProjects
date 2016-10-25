using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class Message
    {
        public int MessageKey { get; set; }
        public int MessageClassKey { get; set; }
        public int MessageScenarioKey { get; set; }
        public int MessageClientKey { get; set; }
        public string MessageText { get; set; }
        public string MessageDirective { get; set; }

        public virtual MessageClass MessageClassKeyNavigation { get; set; }
        public virtual MessageClient MessageClientKeyNavigation { get; set; }
        public virtual MessageScenario MessageScenarioKeyNavigation { get; set; }
    }
}
