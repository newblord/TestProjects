using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CustomerEdit
    {
        public int CustomerEditKey { get; set; }
        public int CustomerKey { get; set; }
        public short Location { get; set; }
        public string Teller { get; set; }
        public DateTime DateEntered { get; set; }
        public string FieldName { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }

        public virtual Customer CustomerKeyNavigation { get; set; }
    }
}
