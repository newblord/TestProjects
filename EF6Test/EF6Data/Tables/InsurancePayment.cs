namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InsurancePayment")]
    public partial class InsurancePayment
    {
        [Key]
        public int INSURANCE_PAYMENT_KEY { get; set; }

        public int INSURANCE_PAYMENT_BATCH_KEY { get; set; }

        public int LOAN_KEY { get; set; }

        public int INSURANCE_CLAIM_KEY { get; set; }

        public int TRANS_DETAIL_KEY { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PAID_AMT { get; set; }

        public bool PAST_DUE_BAL_WAIVED { get; set; }

        public virtual InsuranceClaim InsuranceClaim { get; set; }

        public virtual InsurancePaymentBatch InsurancePaymentBatch { get; set; }

        public virtual Loan Loan { get; set; }

        public virtual TransDetail TransDetail { get; set; }
    }
}
