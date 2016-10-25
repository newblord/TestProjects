using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CustomerEmployerEdit
    {
        public int CustomerEmployerEditKey { get; set; }
        public int CustomerEmployerKey { get; set; }
        public short Location { get; set; }
        public string Teller { get; set; }
        public DateTime DateEntered { get; set; }
        public string FieldName { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
    }
}
