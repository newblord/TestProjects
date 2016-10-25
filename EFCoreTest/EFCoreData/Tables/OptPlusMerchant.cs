using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class OptPlusMerchant
    {
        public OptPlusMerchant()
        {
            OptPlusDirectDeposit = new HashSet<OptPlusDirectDeposit>();
            OptPlusRdfpostedTrans = new HashSet<OptPlusRdfpostedTrans>();
        }

        public int OptplusMerchantKey { get; set; }
        public DateTime DateEntered { get; set; }
        public string Teller { get; set; }
        public string MerchantNum { get; set; }
        public string MerchantName { get; set; }
        public string MerchantCategory { get; set; }
        public string MerchantCountry { get; set; }

        public virtual ICollection<OptPlusDirectDeposit> OptPlusDirectDeposit { get; set; }
        public virtual ICollection<OptPlusRdfpostedTrans> OptPlusRdfpostedTrans { get; set; }
    }
}
