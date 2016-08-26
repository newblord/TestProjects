namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PrepaidFISAuthTran
    {
        [Key]
        public int AUTH_TRANS_KEY { get; set; }

        public int? CUSTOMER_KEY { get; set; }

        public short? PROCESS_STATUS { get; set; }

        public DateTime? DATE_UPDATED { get; set; }

        public int? ISSUER_CLIENT_ID { get; set; }

        [StringLength(30)]
        public string ISSUER_CLIENT_NAME { get; set; }

        public int? SUBPROGRAM_ID { get; set; }

        [StringLength(80)]
        public string SUBPROGRAM_NAME { get; set; }

        public int? BIN_NUM { get; set; }

        [StringLength(3)]
        public string BIN_CURR_ALPHA { get; set; }

        [StringLength(3)]
        public string BIN_CURR_CODE { get; set; }

        [StringLength(23)]
        public string BANK_NAME { get; set; }

        [StringLength(19)]
        public string PRIME_ACCT_NUM { get; set; }

        [StringLength(19)]
        public string CARD_ACCT_NUM { get; set; }

        [StringLength(36)]
        public string TXN_UID { get; set; }

        public int? TXN_TYPE_CODE { get; set; }

        [StringLength(40)]
        public string TXN_TYPE_NAME { get; set; }

        public int? PURSE_NUM { get; set; }

        [StringLength(40)]
        public string PURSE_NAME { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? TRANS_DATETIME { get; set; }

        [StringLength(6)]
        public string AUTHORIZE_CODE { get; set; }

        public int? REQUEST_CODE { get; set; }

        [StringLength(80)]
        public string REQUEST_DESC { get; set; }

        public int? RESPONSE_CODE { get; set; }

        [StringLength(80)]
        public string RESPONSE_DESC { get; set; }

        public int? REASON_CODE { get; set; }

        [StringLength(80)]
        public string REASON_DESC { get; set; }

        public int? SOURCE_CODE { get; set; }

        [StringLength(80)]
        public string SOURCE_DESC { get; set; }

        public decimal? AUTHORIZE_AMT { get; set; }

        public decimal? TXN_LOCAL_AMT { get; set; }

        public short? TRANS_SIGN { get; set; }

        public int? TRANS_CURR_CODE { get; set; }

        [StringLength(3)]
        public string TRANS_CURR_ALPHA { get; set; }

        [StringLength(23)]
        public string RETRIEVAL_REFNO { get; set; }

        public short? REVERSED { get; set; }

        [StringLength(80)]
        public string AVS_INFO { get; set; }

        [StringLength(1)]
        public string AVS_RESP_CODE { get; set; }

        public short? PIN { get; set; }

        [StringLength(26)]
        public string POS_DATA { get; set; }

        public int? POS_ENTRY_CODE { get; set; }

        [StringLength(80)]
        public string POS_ENTRY_DESC { get; set; }

        [StringLength(80)]
        public string MERC_MCC_CODE { get; set; }

        [StringLength(80)]
        public string MCC_DESCRIPTION { get; set; }

        [StringLength(3)]
        public string MERC_CURR_ALPHA { get; set; }

        [StringLength(3)]
        public string MERC_CURR_CODE { get; set; }

        [StringLength(40)]
        public string MERC_NAME { get; set; }

        [StringLength(16)]
        public string MERC_NUM { get; set; }

        [StringLength(80)]
        public string MERC_STREET { get; set; }

        [StringLength(25)]
        public string MERC_CITY { get; set; }

        [StringLength(30)]
        public string MERC_PROV { get; set; }

        [StringLength(80)]
        public string MERC_STATE { get; set; }

        [StringLength(9)]
        public string MERC_ZIP { get; set; }

        [StringLength(3)]
        public string MERC_CTRY_CODE { get; set; }

        [StringLength(45)]
        public string MERC_CTRY_NAME { get; set; }

        [StringLength(8)]
        public string TERM_NUM { get; set; }

        [StringLength(18)]
        public string ACQ_ID { get; set; }

        [StringLength(30)]
        public string CAN_PROXY_NUM { get; set; }

        [StringLength(30)]
        public string CLIENT_UNIQUE_ID { get; set; }

        public decimal? AUTH_BAL { get; set; }

        public decimal? SETTLE_BAL { get; set; }

        public decimal? TOLERANCE_AMT { get; set; }

        [StringLength(2)]
        public string CARD_VERIFY_METHOD { get; set; }

        [StringLength(1)]
        public string CVC_RESPONSE { get; set; }

        [StringLength(30)]
        public string PAN_PROXY_NUM { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
