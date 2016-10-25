using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class SecurityGroup
    {
        public SecurityGroup()
        {
            DiscountSecurity = new HashSet<DiscountSecurity>();
            ProcessConfigInstanceGroup = new HashSet<ProcessConfigInstanceGroup>();
            Tellerid = new HashSet<Tellerid>();
        }

        public int SecuritygroupKey { get; set; }
        public string SgName { get; set; }
        public string SgValues { get; set; }
        public bool IsCollector { get; set; }
        public bool IsAdAstra { get; set; }
        public bool IsActive { get; set; }
        public bool IsManager { get; set; }
        public bool IsCorporate { get; set; }
        public bool IsAccountant { get; set; }

        public virtual ICollection<DiscountSecurity> DiscountSecurity { get; set; }
        public virtual ICollection<ProcessConfigInstanceGroup> ProcessConfigInstanceGroup { get; set; }
        public virtual ICollection<Tellerid> Tellerid { get; set; }
    }
}
