using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class IncomeVerificationMessage
    {
        public int IncomeVerificationMessageKey { get; set; }
        public bool IsActive { get; set; }
        public string State { get; set; }
        public string MessageText { get; set; }

        public virtual GlobalStates StateNavigation { get; set; }
    }
}
