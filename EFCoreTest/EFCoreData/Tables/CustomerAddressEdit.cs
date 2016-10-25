using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CustomerAddressEdit
    {
        public int CustomerAddressEditKey { get; set; }
        public int CustomerAddressKey { get; set; }
        public string Teller { get; set; }
        public DateTime DateEntered { get; set; }
        public string FieldName { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }

        public virtual CustomerAddress CustomerAddressKeyNavigation { get; set; }
    }
}
