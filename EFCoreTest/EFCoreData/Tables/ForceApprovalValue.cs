using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class ForceApprovalValue
    {
        public int ForceApprovalValueKey { get; set; }
        public int ForceApprovalQuestionKey { get; set; }
        public int LoanApplicationKey { get; set; }
        public string Value { get; set; }
        public bool BankStatementSupplied { get; set; }
        public DateTime DateEntered { get; set; }
    }
}
