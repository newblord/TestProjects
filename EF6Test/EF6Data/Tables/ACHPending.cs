namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ACHPending")]
    public partial class ACHPending
    {
        [Key]
        public int ACH_PENDING_KEY { get; set; }

        public DateTime DATE_ENTERED { get; set; }

        public int CUSTOMER_KEY { get; set; }

        public int LOCATION { get; set; }

        public int RISREPT_KEY { get; set; }

        [Column(TypeName = "money")]
        public decimal RI_BALANCE { get; set; }

        [Column(TypeName = "money")]
        public decimal ACH_AMOUNT { get; set; }

        public int? LOAN_KEY { get; set; }

        public int? CASHED_CHECK_KEY { get; set; }

        public int? PTP_DETAIL_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime PROJ_SEND_DATE { get; set; }

        public int? PROCESS_CONFIG_INSTANCE_KEY { get; set; }

        public bool IS_MARKED_ACH_BLOCK { get; set; }

        public bool IS_MARKED_STOP_PAYMENT { get; set; }

        public bool IS_DIRECT_DEPOSIT { get; set; }

        public bool IS_PAY_INFO_COMPLETE { get; set; }

        public int? RI_AGE { get; set; }

        [StringLength(2)]
        public string AUDIT_CODE { get; set; }

        [StringLength(10)]
        public string BANK_ABA { get; set; }

        [StringLength(20)]
        public string ACCT_NO { get; set; }

        public bool IS_MANUAL_ACH { get; set; }

        public bool HAS_CC { get; set; }

        public bool IS_AD_ASTRA { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CALC_PAY_DATE { get; set; }

        [Required]
        [StringLength(20)]
        public string STATEMENT_ID { get; set; }

        public int ACH_PRESENTMENT_KEY { get; set; }

        public int BP_STEP_DATA_KEY { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
