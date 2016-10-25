namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RiccHold")]
    public partial class RiccHold
    {
        public int RISREPT_KEY { get; set; }

        [StringLength(43)]
        public string REFERENCE { get; set; }

        public int CASHED_CHECK_KEY { get; set; }

        public int? LOAN_KEY { get; set; }

        public short LOCATION { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE { get; set; }

        public int? RIS_AUDIT_ID { get; set; }

        public int CREDITCARD_KEY { get; set; }

        [StringLength(19)]
        public string CARDNUM { get; set; }

        [Required]
        [StringLength(50)]
        public string NAMEONCARD { get; set; }

        public byte EXPMONTH { get; set; }

        public int EXPYEAR { get; set; }

        public bool PINLESS_ELIGIBLE { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        public int CUSTOMER_KEY { get; set; }

        [Required]
        [StringLength(1)]
        public string LOAN_TYPE { get; set; }

        [Required]
        [StringLength(1)]
        public string PRODUCT_TYPE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal RI_BALANCE { get; set; }

        public int riage { get; set; }

        public int DUPE { get; set; }

        public int VOID { get; set; }

        public bool IS_AD_ASTRA { get; set; }

        [Required]
        [StringLength(1)]
        public string DEPOSIT_METHOD { get; set; }

        [Required]
        [StringLength(4)]
        public string CVV { get; set; }

        [Required]
        [StringLength(50)]
        public string BILLING_ADDRESS { get; set; }

        [Required]
        [StringLength(30)]
        public string BILLING_CITY { get; set; }

        [Required]
        [StringLength(2)]
        public string BILLING_STATE { get; set; }

        [Required]
        [StringLength(10)]
        public string BILLING_ZIPCODE { get; set; }

        public bool EXPIRED { get; set; }

        public bool CVVINVALID { get; set; }

        public int ISSUER_KEY { get; set; }

        public int LIEN_HOLDER_KEY { get; set; }

        [Required]
        [StringLength(40)]
        public string TOKEN { get; set; }

        public byte CARD_BRAND { get; set; }

        public byte CARD_TYPE { get; set; }

        public short ROLLOVER_NUM { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal SURCHG { get; set; }

        public int AUTO_ROLL { get; set; }

        public bool SELECTED { get; set; }

        public bool PROCESSED { get; set; }

        public bool APPROVED { get; set; }

        [Required]
        [StringLength(30)]
        public string APP_ERR_CODE { get; set; }

        public int PTP_HEADER_KEY { get; set; }

        public int PTP_DETAIL_KEY { get; set; }

        public int CCARD_TRANS_KEY { get; set; }

        public bool POSTED { get; set; }

        public int id { get; set; }

        public int? OPTPLUS_CARD_DETAIL_KEY { get; set; }
    }
}
