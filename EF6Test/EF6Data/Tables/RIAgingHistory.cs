namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RIAgingHistory")]
    public partial class RIAgingHistory
    {
        [Key]
        public int RI_AGING_HISTORY_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        public byte EVENT_TYPE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime EVENT_DATE { get; set; }

        public int RISREPT_KEY { get; set; }

        public int CUSTOMER_KEY { get; set; }

        public int LOAN_KEY { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal LOAN_PRINC_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal RI_BALANCE { get; set; }

        public bool IS_PAYOFF { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal MIN_PAYMENT_NEEDED { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PAID_AMT { get; set; }

        public int PAYMENT_METHOD { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        public int? COLL_STRATEGY { get; set; }

        public byte RISK_ASSESSMENT { get; set; }

        public bool VOLUNTARY_PTP { get; set; }

        public int? LOANPAYMENT_KEY { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int? CUST_EVENT_NUM { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int? LOAN_EVENT_NUM { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Loan Loan { get; set; }

        public virtual RISREPT RISREPT { get; set; }
    }
}
