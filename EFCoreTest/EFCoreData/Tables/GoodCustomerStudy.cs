using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class GoodCustomerStudy
    {
        public int GoodCustomerStudyKey { get; set; }
        public int CustomerKey { get; set; }
        public DateTime DateEntered { get; set; }
        public decimal InitialApprovedAmt { get; set; }
        public decimal IncreaseAmt { get; set; }
        public decimal StateMaxAmt { get; set; }
        public decimal LoanTakenAmt { get; set; }

        public virtual Customer CustomerKeyNavigation { get; set; }
    }
}
