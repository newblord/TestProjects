using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class PrepaidCardGroup
    {
        public PrepaidCardGroup()
        {
            PrepaidCardBinCompany = new HashSet<PrepaidCardBinCompany>();
        }

        public int PrepaidCardGroupKey { get; set; }
        public string GroupName { get; set; }
        public string GroupDescription { get; set; }
        public int? CardAmountGlAcct { get; set; }
        public bool IsActive { get; set; }
        public DateTime? DateActiveChanged { get; set; }
        public string TellerActiveChanged { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }

        public virtual ICollection<PrepaidCardBinCompany> PrepaidCardBinCompany { get; set; }
    }
}
