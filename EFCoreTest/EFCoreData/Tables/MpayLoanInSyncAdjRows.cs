using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class MpayLoanInSyncAdjRows
    {
        public int MpayLoanInSyncAdjKey { get; set; }
        public int LoanKey { get; set; }
        public DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public string FieldName { get; set; }
        public string PrvVal { get; set; }
        public string ChgToVal { get; set; }
    }
}
