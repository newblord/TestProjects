namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RbcEFundBatchDetail")]
    public partial class RbcEFundBatchDetail
    {
        [Key]
        public int RBC_EFUND_BATCH_DETAIL_KEY { get; set; }

        public int RBC_EFUND_BATCH_KEY { get; set; }

        public int RBC_EFUND_RESPONSE_CODE_KEY { get; set; }

        public int CUSTOMER_KEY { get; set; }

        public int LOAN_KEY { get; set; }

        public int ISSUER_KEY { get; set; }

        public long BANK_ID { get; set; }

        [Required]
        [StringLength(20)]
        public string ACCT_NO { get; set; }

        [Required]
        [StringLength(100)]
        public string EMAIL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal AMOUNT { get; set; }

        public bool PROCESSED { get; set; }

        public bool FUNDED { get; set; }

        public bool VOIDED { get; set; }

        public int? RBC_EFUND_BATCH_SUMMARY_KEY { get; set; }

        [StringLength(2000)]
        public string RESPONSE_TEXT { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Issuer Issuer { get; set; }

        public virtual Loan Loan { get; set; }

        public virtual RbcEFundBatch RbcEFundBatch { get; set; }

        public virtual RbcEFundResponseCode RbcEFundResponseCode { get; set; }
    }
}
