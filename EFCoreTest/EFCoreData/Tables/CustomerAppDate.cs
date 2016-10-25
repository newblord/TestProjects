using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class CustomerAppDate
    {
        public int CustomerCertKey { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }
        public short Location { get; set; }
        public int CustomerKey { get; set; }
        public DateTime CertDate { get; set; }
    }
}
