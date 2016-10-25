using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class OptInOutEdit
    {
        public int OptinoutEditKey { get; set; }
        public int OptinoutKey { get; set; }
        public string Tellerid { get; set; }
        public DateTime DateEntered { get; set; }
        public string FieldName { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }

        public virtual OptInOut OptinoutKeyNavigation { get; set; }
    }
}
