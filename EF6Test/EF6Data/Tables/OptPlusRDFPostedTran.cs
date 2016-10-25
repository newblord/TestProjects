namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OptPlusRDFPostedTran
    {
        [StringLength(15)]
        public string PROGRAM_ID { get; set; }

        [StringLength(30)]
        public string ACCOUNT_ID { get; set; }

        [StringLength(30)]
        public string CARD_ID { get; set; }

        [StringLength(17)]
        public string TRANS_DATE { get; set; }

        [StringLength(10)]
        public string TRANS_CODE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? TRANS_AMT { get; set; }

        [StringLength(1)]
        public string TRANS_SIGN { get; set; }

        [StringLength(3)]
        public string CURRENCY_CODE { get; set; }

        [StringLength(10)]
        public string AUTH_CODE { get; set; }

        [StringLength(8)]
        public string POST_DATE { get; set; }

        [StringLength(1)]
        public string NETWORK_CODE { get; set; }

        [StringLength(30)]
        public string MERCHANT_NUM { get; set; }

        [StringLength(50)]
        public string MERCHANT_NAME { get; set; }

        [StringLength(4)]
        public string MERCHANT_CATEGORY { get; set; }

        [StringLength(5)]
        public string MERCHANT_COUNTRY { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? INTER_FEE_AMT { get; set; }

        [StringLength(20)]
        public string EXT_TRANS_ID { get; set; }

        [StringLength(20)]
        public string USER_DATA1 { get; set; }

        [StringLength(20)]
        public string USER_DATA2 { get; set; }

        public int? CUSTOMER_KEY { get; set; }

        public int? OPTPLUS_MERCHANT_KEY { get; set; }

        [Key]
        public int POSTED_TRANS_KEY { get; set; }

        public DateTime? DATE_UPDATED { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual OptPlusMerchant OptPlusMerchant { get; set; }
    }
}
