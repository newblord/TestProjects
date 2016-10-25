using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class ApiApplication
    {
        public ApiApplication()
        {
            VisitorApiAuthorization = new HashSet<VisitorApiAuthorization>();
        }

        public int ApiApplicationKey { get; set; }
        public string Name { get; set; }
        public Guid Token { get; set; }
        public string Secret { get; set; }
        public DateTime DateEntered { get; set; }

        public virtual ICollection<VisitorApiAuthorization> VisitorApiAuthorization { get; set; }
    }
}
