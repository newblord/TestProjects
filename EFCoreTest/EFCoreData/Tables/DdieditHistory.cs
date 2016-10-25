using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class DdieditHistory
    {
        public int DdiEditHistoryKey { get; set; }
        public int DdiKey { get; set; }
        public string FieldName { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public DateTime EnteredDate { get; set; }

        public virtual Ddi DdiKeyNavigation { get; set; }
    }
}
