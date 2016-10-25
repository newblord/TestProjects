using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class AgentAction
    {
        public AgentAction()
        {
            CollectionAction = new HashSet<CollectionAction>();
            TaskActionResult = new HashSet<TaskActionResult>();
        }

        public int AgentActionKey { get; set; }
        public string LongDescr { get; set; }
        public string ShortDescr { get; set; }
        public bool CollectorOnly { get; set; }
        public bool LegalOnly { get; set; }
        public string Security { get; set; }
        public byte? PhoneTypeCode { get; set; }
        public byte? AddressTypeCode { get; set; }
        public bool UseOnAdastraRi { get; set; }

        public virtual ICollection<CollectionAction> CollectionAction { get; set; }
        public virtual ICollection<TaskActionResult> TaskActionResult { get; set; }
    }
}
