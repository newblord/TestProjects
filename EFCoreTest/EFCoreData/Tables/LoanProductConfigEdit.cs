using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LoanProductConfigEdit
    {
        public int LoanProductConfigEditKey { get; set; }
        public int LoanProductConfigKey { get; set; }
        public string EnteredBy { get; set; }
        public DateTime DateEntered { get; set; }
        public string TableName { get; set; }
        public string FieldName { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }

        public virtual LoanProductConfig LoanProductConfigKeyNavigation { get; set; }
    }
}
