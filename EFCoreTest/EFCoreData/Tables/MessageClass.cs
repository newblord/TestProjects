using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class MessageClass
    {
        public MessageClass()
        {
            Message = new HashSet<Message>();
        }

        public int MessageClassKey { get; set; }
        public string MessageClassName { get; set; }
        public string MessageClassDescription { get; set; }
        public int MessageClassId { get; set; }

        public virtual ICollection<Message> Message { get; set; }
    }
}
