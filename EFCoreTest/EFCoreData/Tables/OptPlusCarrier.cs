using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class OptPlusCarrier
    {
        public OptPlusCarrier()
        {
            Customer = new HashSet<Customer>();
        }

        public int OptplusCarrierKey { get; set; }
        public string CarrierId { get; set; }
        public string CarrierName { get; set; }
        public string DisplayName { get; set; }
        public string EmailGateway { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }
        public DateTime? DateTerminated { get; set; }

        public virtual ICollection<Customer> Customer { get; set; }
    }
}
