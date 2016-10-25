namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PrepaidFISCustomerMaster")]
    public partial class PrepaidFISCustomerMaster
    {
        [Key]
        public int CUSTOMER_MASTER_KEY { get; set; }

        public int? CUSTOMER_KEY { get; set; }

        public short? PROCESS_STATUS { get; set; }

        public DateTime? DATE_UPDATED { get; set; }

        public int? TOP_CLIENT_ID { get; set; }

        [StringLength(30)]
        public string TOP_CLIENT_NAME { get; set; }

        public int? ISSUER_CLIENT_ID { get; set; }

        [StringLength(30)]
        public string CLIENT_NAME { get; set; }

        public int? PROGRAM_ID { get; set; }

        [StringLength(40)]
        public string PROGRAM_NAME { get; set; }

        public int? SUBPROGRAM_ID { get; set; }

        [StringLength(80)]
        public string SUBPROGRAM_NAME { get; set; }

        public int? BIN_NUM { get; set; }

        [StringLength(3)]
        public string BIN_CURR_ALPHA { get; set; }

        [StringLength(3)]
        public string BIN_CURR_CODE { get; set; }

        public int? PACKAGE_ID { get; set; }

        [StringLength(80)]
        public string PACKAGE_NAME { get; set; }

        [StringLength(19)]
        public string PRIME_ACCT_NUM { get; set; }

        [StringLength(19)]
        public string CARD_ACCT_NUM { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ACTIVATE_DATE { get; set; }

        public int? CARD_STATUS { get; set; }

        [StringLength(50)]
        public string CARDHOLDER_FIRSTNAME { get; set; }

        [StringLength(50)]
        public string CARDHOLDER_LASTNAME { get; set; }

        [StringLength(1)]
        public string CARDHOLDER_MIDDLENAME { get; set; }

        [StringLength(50)]
        public string MAIL_ADDR_LINE1 { get; set; }

        [StringLength(50)]
        public string MAIL_ADDR_LINE2 { get; set; }

        [StringLength(35)]
        public string MAIL_CITY { get; set; }

        [StringLength(25)]
        public string MAIL_STATE { get; set; }

        [StringLength(30)]
        public string MAIL_ZIP { get; set; }

        [StringLength(45)]
        public string MAIL_CTRY { get; set; }

        public int? CARDHOLDER_CTRY_CODE { get; set; }

        [StringLength(23)]
        public string CARDHOLDER_PHONE { get; set; }

        [StringLength(8)]
        public string CARDHOLDER_PHONE_EXT { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CAN_CREATE_DATE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CAN_EXPIRE_DATE { get; set; }

        public int? MARKET_SEG_ID { get; set; }

        [StringLength(40)]
        public string MARKET_SEG_DESC { get; set; }

        public int? REQUEST_CODE { get; set; }

        public int? SOURCE_CODE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? WCSUTC_INSERTED { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CAN_STATUS_EFFECTIVE_DATE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CARDHOLDER_DOB { get; set; }

        [StringLength(80)]
        public string CARDHOLDER_EMAIL { get; set; }

        [StringLength(9)]
        public string CARDHOLDER_SSN { get; set; }

        [StringLength(3)]
        public string CARDHOLDER_SUFFIX { get; set; }

        [StringLength(30)]
        public string CARD_STATUS_DESC { get; set; }

        [StringLength(512)]
        public string CLIENT_MEMO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ACCOUNT_CREATE_DATE { get; set; }

        [StringLength(30)]
        public string CAN_PROXY_NUM { get; set; }

        [StringLength(3)]
        public string PRIVACY_OPT_OUT { get; set; }

        [StringLength(12)]
        public string PRIMARY_RELATIONSHIP { get; set; }

        [StringLength(80)]
        public string REQUEST_CODE_DESC { get; set; }

        [StringLength(80)]
        public string SOURCE_CODE_DESC { get; set; }

        public int? PERSON_ID { get; set; }

        [StringLength(30)]
        public string CLIENT_UNIQUE_ID { get; set; }

        [StringLength(80)]
        public string ALERTS_EMAIL { get; set; }

        [StringLength(13)]
        public string DIRECT_ACCESS_NUMBER { get; set; }

        [StringLength(23)]
        public string SMS_MOBILE_PHONE { get; set; }

        [StringLength(30)]
        public string PAN_PROXY_NUM { get; set; }

        [Column(TypeName = "date")]
        public DateTime? INIT_VALUE_LOAD { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PERSON_CREATE_DATE { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
