using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class MessageScenario
    {
        public MessageScenario()
        {
            Message = new HashSet<Message>();
        }

        public int MessageScenarioKey { get; set; }
        public string MessageScenarioName { get; set; }
        public string MessageScenarioDescription { get; set; }
        public int MessageScenarioId { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }

        public virtual ICollection<Message> Message { get; set; }
    }
}
