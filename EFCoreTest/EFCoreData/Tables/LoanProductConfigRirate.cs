using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LoanProductConfigRirate
    {
        public int LoanProductConfigRiRateKey { get; set; }
        public int LoanProductConfigKey { get; set; }
        public short FromNumDays { get; set; }
        public short ToNumDays { get; set; }
        public decimal RiRateVal { get; set; }
        public string RiRatePctOrAmt { get; set; }
        public DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string UpdatedBy { get; set; }

        public virtual LoanProductConfig LoanProductConfigKeyNavigation { get; set; }
    }
}
