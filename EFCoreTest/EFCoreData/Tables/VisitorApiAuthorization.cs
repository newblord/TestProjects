using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class VisitorApiAuthorization
    {
        public int VisitorApiAuthorizationKey { get; set; }
        public int ApiApplicationKey { get; set; }
        public int VisitorKey { get; set; }
        public DateTime DateTokenExpires { get; set; }
        public string Pin { get; set; }
        public DateTime DateEntered { get; set; }
        public Guid? Token { get; set; }
        public int? VisitorDeviceKey { get; set; }

        public virtual ApiApplication ApiApplicationKeyNavigation { get; set; }
        public virtual VisitorDevice VisitorDeviceKeyNavigation { get; set; }
        public virtual Visitor VisitorKeyNavigation { get; set; }
    }
}
