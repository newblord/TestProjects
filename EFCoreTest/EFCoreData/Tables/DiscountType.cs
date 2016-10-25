using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class DiscountType
    {
        public DiscountType()
        {
            DiscountMaster = new HashSet<DiscountMaster>();
        }

        public int DiscountTypeKey { get; set; }
        public string Description { get; set; }

        public virtual ICollection<DiscountMaster> DiscountMaster { get; set; }
    }
}
