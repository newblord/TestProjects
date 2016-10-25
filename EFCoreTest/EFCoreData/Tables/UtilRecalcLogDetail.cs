using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class UtilRecalcLogDetail
    {
        public int UtilRecalcLogDetailKey { get; set; }
        public short Location { get; set; }
        public DateTime DateEntered { get; set; }
        public string TableName { get; set; }
        public string FieldName { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
    }
}
