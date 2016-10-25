using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class DiscountSecurity
    {
        public int DiscountSecurityKey { get; set; }
        public int DiscountsKey { get; set; }
        public int SecuritygroupKey { get; set; }

        public virtual DiscountMaster DiscountsKeyNavigation { get; set; }
        public virtual SecurityGroup SecuritygroupKeyNavigation { get; set; }
    }
}
