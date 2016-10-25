using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class MessageClient
    {
        public MessageClient()
        {
            Message = new HashSet<Message>();
        }

        public int MessageClientKey { get; set; }
        public string MessageClientName { get; set; }
        public string MessageClientDescription { get; set; }
        public int MessageClientId { get; set; }

        public virtual ICollection<Message> Message { get; set; }
    }
}
