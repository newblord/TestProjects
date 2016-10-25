namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CreditCardTran
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CreditCardTran()
        {
            LoanApplications = new HashSet<LoanApplication>();
        }

        [Key]
        public int CREDIT_CARD_TRANS_KEY { get; set; }

        public int? CUSTOMER_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        public short LOCATION { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Required]
        [StringLength(3)]
        public string REQ_FILE_TYPE { get; set; }

        [Required]
        [StringLength(30)]
        public string CCARD_NAME { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CHARGE_AMT { get; set; }

        public int? REFUND_TRANS_DETAIL_KEY { get; set; }

        public int? TRANS_DETAIL_KEY { get; set; }

        public bool? SUCCESS_FLAG { get; set; }

        [StringLength(512)]
        public string ERROR_MSG { get; set; }

        public int? TRANS_POS_KEY { get; set; }

        public int? RISREPT_KEY { get; set; }

        [StringLength(100)]
        public string AUTH_CODE { get; set; }

        public int? RITA_TROUTD { get; set; }

        public int? RITA_SEQUENCE_NUM { get; set; }

        [StringLength(10)]
        public string RESULT_CODE { get; set; }

        [Required]
        [StringLength(5)]
        public string DECLINE_CODE { get; set; }

        [Required]
        [StringLength(3)]
        public string AVS_CODE { get; set; }

        [Required]
        [StringLength(2)]
        public string CVV_CODE { get; set; }

        [Required]
        [StringLength(40)]
        public string TOKEN { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? FEE_CHARGED_AMT { get; set; }

        public int? LOAN_KEY { get; set; }

        public string VENDOR_RESPONSE { get; set; }

        [StringLength(255)]
        public string EPDQ_TRANS_ID { get; set; }

        public string VENDOR_POST { get; set; }

        public short? CREDIT_CARD_RESULT_CODE_KEY { get; set; }

        public byte? CREDIT_CARD_VENDOR_KEY { get; set; }

        [StringLength(2)]
        public string DECLINE_CODE_TWO_CHAR { get; set; }

        [StringLength(2)]
        public string AVS_CODE_TWO_CHAR { get; set; }

        [StringLength(19)]
        public string CCARD_NUM { get; set; }

        public byte? EXP_MONTH { get; set; }

        public byte? EXP_YEAR { get; set; }

        [StringLength(117)]
        public string MAG_STRIP { get; set; }

        public virtual CreditCardVendor CreditCardVendor { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual TransDetail TransDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanApplication> LoanApplications { get; set; }

        public virtual ZeroDollarAuth ZeroDollarAuth { get; set; }
    }
}
