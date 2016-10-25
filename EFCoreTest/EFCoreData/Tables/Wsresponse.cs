using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class Wsresponse
    {
        public Wsresponse()
        {
            PrepaidCardTrans = new HashSet<PrepaidCardTrans>();
        }

        public int WsResponseKey { get; set; }
        public int WsConfigKey { get; set; }
        public string ResponseCode { get; set; }
        public string ResponseDescription { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }

        public virtual ICollection<PrepaidCardTrans> PrepaidCardTrans { get; set; }
        public virtual Wsconfig WsConfigKeyNavigation { get; set; }
    }
}
