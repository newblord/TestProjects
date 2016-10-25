using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class Smssender
    {
        public Smssender()
        {
            Smsoutbound = new HashSet<Smsoutbound>();
        }

        public int SmsSenderKey { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Smsoutbound> Smsoutbound { get; set; }
    }
}
