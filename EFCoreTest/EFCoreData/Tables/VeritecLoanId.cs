using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class VeritecLoanId
    {
        public int LoanKey { get; set; }
        public string TransNum { get; set; }
        public bool ManuallyEntered { get; set; }
        public int VeritecLoanIdKey { get; set; }
        public int? CustomerKey { get; set; }
    }
}
