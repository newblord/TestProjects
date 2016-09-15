namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoanPaymentInsuranceClaimXRef")]
    public partial class LoanPaymentInsuranceClaimXRef
    {
        [Key]
        public int LOAN_PAYMENT_INSURANCE_CLAIM_XREF_KEY { get; set; }

        public int INSURANCE_CLAIM_KEY { get; set; }

        public int LOAN_PAYMENT_KEY { get; set; }

        public virtual InsuranceClaim InsuranceClaim { get; set; }

        public virtual LoanPayment LoanPayment { get; set; }
    }
}
