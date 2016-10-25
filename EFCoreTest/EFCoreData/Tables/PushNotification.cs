using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class PushNotification
    {
        public int PushNotificationKey { get; set; }
        public int VisitorDeviceKey { get; set; }
        public DateTime DateEntered { get; set; }
        public DateTime DateUpdated { get; set; }
        public byte Status { get; set; }
        public string Arguments { get; set; }
        public byte Type { get; set; }
        public DateTime DateScheduled { get; set; }

        public virtual VisitorDevice VisitorDeviceKeyNavigation { get; set; }
    }
}
