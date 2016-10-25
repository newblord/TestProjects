using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class IncomeTypeLocation
    {
        public int IncomeTypeLocKey { get; set; }
        public int IncomeTypeKey { get; set; }
        public short Location { get; set; }
        public bool IsActive { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public string LastUpdatedBy { get; set; }
        public string EnumListForIncomeMaintRequiredFields { get; set; }

        public virtual IncomeType IncomeTypeKeyNavigation { get; set; }
        public virtual Company LocationNavigation { get; set; }
    }
}
