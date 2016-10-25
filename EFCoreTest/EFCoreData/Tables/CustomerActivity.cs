using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CustomerActivity
    {
        public int CustomerActivityKey { get; set; }
        public int CustomerKey { get; set; }
        public string ProductType { get; set; }
        public string LoanType { get; set; }
        public DateTime FirstActivity { get; set; }
        public DateTime LastActivity { get; set; }
        public DateTime PriorActivity { get; set; }

        public virtual Customer CustomerKeyNavigation { get; set; }
    }
}
