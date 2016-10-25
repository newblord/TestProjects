using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CustomerIdentificationEdit
    {
        public int CustomerIdentificationEditKey { get; set; }
        public int CustomerIdentificationKey { get; set; }
        public short Location { get; set; }
        public string Teller { get; set; }
        public DateTime DateEntered { get; set; }
        public string FieldName { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }

        public virtual CustomerIdentification CustomerIdentificationKeyNavigation { get; set; }
    }
}
