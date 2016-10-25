using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class PromiseToPayDetailEdit
    {
        public int PromiseToPayDetailEditKey { get; set; }
        public int PtpDetailKey { get; set; }
        public short Location { get; set; }
        public string Teller { get; set; }
        public DateTime DateEntered { get; set; }
        public string DmlType { get; set; }
        public string FieldName { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }

        public virtual PromiseToPayDetail PtpDetailKeyNavigation { get; set; }
    }
}
