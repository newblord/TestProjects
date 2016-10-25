using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CustomerFlashResponse
    {
        public long CustomerFlashResponseKey { get; set; }
        public byte CustomerFlashQuestionsKey { get; set; }
        public int CustomerKey { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }
        public short Location { get; set; }
        public short Response { get; set; }
        public bool IsNew { get; set; }

        public virtual Customer CustomerKeyNavigation { get; set; }
        public virtual Tellerid TellerNavigation { get; set; }
    }
}
