using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class IncomeVerifyMethodLocation
    {
        public int IncomeVerifyMethodLocKey { get; set; }
        public int IncomeVerifyMethodKey { get; set; }
        public short Location { get; set; }
        public bool IsActive { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public string LastUpdatedBy { get; set; }

        public virtual IncomeVerifyMethod IncomeVerifyMethodKeyNavigation { get; set; }
        public virtual Company LocationNavigation { get; set; }
    }
}
