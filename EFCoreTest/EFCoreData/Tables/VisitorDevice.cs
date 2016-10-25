using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class VisitorDevice
    {
        public VisitorDevice()
        {
            PushNotification = new HashSet<PushNotification>();
            VisitorApiAuthorization = new HashSet<VisitorApiAuthorization>();
        }

        public int VisitorDeviceKey { get; set; }
        public string Uuid { get; set; }
        public string SubscriptionToken { get; set; }
        public string Name { get; set; }
        public int NumPushErrors { get; set; }
        public int VisitorKey { get; set; }
        public bool IsExpired { get; set; }
        public byte DeviceType { get; set; }
        public DateTime DateEntered { get; set; }
        public DateTime? DateLastPush { get; set; }
        public string ApplicationVersion { get; set; }

        public virtual ICollection<PushNotification> PushNotification { get; set; }
        public virtual ICollection<VisitorApiAuthorization> VisitorApiAuthorization { get; set; }
        public virtual Visitor VisitorKeyNavigation { get; set; }
    }
}
