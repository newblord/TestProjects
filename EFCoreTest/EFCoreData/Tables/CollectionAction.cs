using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CollectionAction
    {
        public int CollectionActionKey { get; set; }
        public int RisreptKey { get; set; }
        public DateTime DateEntered { get; set; }
        public short Location { get; set; }
        public string Teller { get; set; }
        public string Note { get; set; }
        public int AgentActionKey { get; set; }
        public int AgentResultKey1 { get; set; }
        public int? AgentResultKey2 { get; set; }
        public int? CollectionMovementKey { get; set; }
        public int? TaskActionResultKey { get; set; }
        public int? CustomerPhoneNumberKey { get; set; }
        public bool IsAdAstra { get; set; }

        public virtual AgentAction AgentActionKeyNavigation { get; set; }
        public virtual Company LocationNavigation { get; set; }
        public virtual Risrept RisreptKeyNavigation { get; set; }
    }
}
