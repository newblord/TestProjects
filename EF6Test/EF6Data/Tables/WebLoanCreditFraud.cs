namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebLoanCreditFraud")]
    public partial class WebLoanCreditFraud
    {
        [Key]
        public int WEB_LOAN_CREDIT_FRAUD_KEY { get; set; }

        public int CUSTOMER_KEY { get; set; }

        public int TRANS_DETAIL_KEY { get; set; }

        public short LOCATION { get; set; }

        public int LOAN_KEY { get; set; }

        [Required]
        [StringLength(5000)]
        public string FRAUD_TYPE { get; set; }

        public bool IS_PROCESSED { get; set; }

        public DateTime DATE_ENTERED { get; set; }

        public virtual Company Company { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Loan Loan { get; set; }

        public virtual TransDetail TransDetail { get; set; }
    }
}
