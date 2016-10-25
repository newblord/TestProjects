using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CustomerPhoneNumberEdit
    {
        public int CustomerPhoneNumberEditKey { get; set; }
        public int CustomerPhoneNumberKey { get; set; }
        public string Teller { get; set; }
        public DateTime DateEntered { get; set; }
        public string FieldName { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public short? ChangedAtLocation { get; set; }

        public virtual CustomerPhoneNumber CustomerPhoneNumberKeyNavigation { get; set; }
    }
}
