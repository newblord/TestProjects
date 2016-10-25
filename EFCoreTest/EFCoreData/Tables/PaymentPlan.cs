using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class PaymentPlan
    {
        public int PaymentPlanKey { get; set; }
        public decimal PpPrincipal { get; set; }
        public decimal PpCommission { get; set; }
    }
}
