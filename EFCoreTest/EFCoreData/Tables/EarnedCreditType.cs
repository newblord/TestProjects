using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class EarnedCreditType
    {
        public EarnedCreditType()
        {
            CustomerEarnedCredit = new HashSet<CustomerEarnedCredit>();
            DiscountMaster = new HashSet<DiscountMaster>();
        }

        public int EarnedCreditTypeKey { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }
        public bool IsEnabled { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public int Account { get; set; }

        public virtual ICollection<CustomerEarnedCredit> CustomerEarnedCredit { get; set; }
        public virtual ICollection<DiscountMaster> DiscountMaster { get; set; }
    }
}
