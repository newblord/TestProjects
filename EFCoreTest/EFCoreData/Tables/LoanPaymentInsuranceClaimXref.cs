using System;
using System.Collections.Generic;

namespace EFCoreData
{
    public partial class LoanPaymentInsuranceClaimXref
    {
        public int LoanPaymentInsuranceClaimXrefKey { get; set; }
        public int InsuranceClaimKey { get; set; }
        public int LoanPaymentKey { get; set; }

        public virtual InsuranceClaim InsuranceClaimKeyNavigation { get; set; }
        public virtual LoanPayment LoanPaymentKeyNavigation { get; set; }
    }
}
