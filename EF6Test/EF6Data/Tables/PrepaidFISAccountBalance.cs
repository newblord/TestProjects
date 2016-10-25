namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PrepaidFISAccountBalance")]
    public partial class PrepaidFISAccountBalance
    {
        [Key]
        public int ACCOUNT_BALANCE_KEY { get; set; }

        public int? CUSTOMER_KEY { get; set; }

        public short? PROCESS_STATUS { get; set; }

        public DateTime? DATE_UPDATED { get; set; }

        public int? ISSUER_CLIENT_ID { get; set; }

        [StringLength(30)]
        public string CLIENT_NAME { get; set; }

        public int? BIN_NUM { get; set; }

        [StringLength(23)]
        public string BANK_NAME { get; set; }

        [StringLength(19)]
        public string PRIME_ACCT_NUM { get; set; }

        public decimal? OPENING_BAL { get; set; }

        public decimal? TOT_VAL_LOAD_AMT { get; set; }

        public int? TOT_VAL_LOAD_CNT { get; set; }

        public decimal? TOT_PURCHASE_AMT { get; set; }

        public int? TOT_PURCHASE_CNT { get; set; }

        public decimal? TOT_OTC_AMT { get; set; }

        public int? TOT_OTC_CNT { get; set; }

        public decimal? TOT_ATM_WD_AMT { get; set; }

        public int? TOT_ATM_WD_CNT { get; set; }

        public decimal? TOT_RTN_AMT { get; set; }

        public int? TOT_RTN_CNT { get; set; }

        public decimal? TOT_ADJ_AMT { get; set; }

        public int? TOT_ADJ_CNT { get; set; }

        public decimal? TOT_FEE_AMT { get; set; }

        public int? TOT_FEE_CNT { get; set; }

        public decimal? OTH_CR_AMT { get; set; }

        public int? OTH_CR_CNT { get; set; }

        public decimal? OTH_DB_AMT { get; set; }

        public int? OTH_DB_CNT { get; set; }

        public decimal? TOT_CR_AMT { get; set; }

        public int? TOT_CRE_CNT { get; set; }

        public decimal? TOT_DB_AMT { get; set; }

        public int? TOT_DB_CNT { get; set; }

        public decimal? TOT_TRANS_AMT { get; set; }

        public int? TOT_TRANS_CNT { get; set; }

        public decimal? CLOSING_BALANCE { get; set; }

        [StringLength(3)]
        public string BIN_CURR_ALPHA { get; set; }

        [StringLength(3)]
        public string BIN_CURR_CODE { get; set; }

        [StringLength(30)]
        public string PAN_PROXY_NUM { get; set; }

        public int? PERSON_ID { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
