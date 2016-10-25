using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LoanConfigApplyPaymentOrder
    {
        public LoanConfigApplyPaymentOrder()
        {
            LoanProductConfig = new HashSet<LoanProductConfig>();
        }

        public int LoanConfigApplyPaymentOrderKey { get; set; }
        public string ApplyPaymentOrder { get; set; }
        public string Description { get; set; }

        public virtual ICollection<LoanProductConfig> LoanProductConfig { get; set; }
    }
}
