namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Xcct")]
    public partial class Xcct
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cctkey { get; set; }

        public int? tdkey { get; set; }

        public int? rtdkey { get; set; }

        public int? rrkey { get; set; }

        public int? ckey { get; set; }

        public int? tpkey { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CREDIT_CARD_TRANS_KEY { get; set; }

        public int? CUSTOMER_KEY { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short LOCATION { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(3)]
        public string REQ_FILE_TYPE { get; set; }

        [Key]
        [Column(Order = 6)]
        public byte EXP_MONTH { get; set; }

        [Key]
        [Column(Order = 7)]
        public byte EXP_YEAR { get; set; }

        [StringLength(19)]
        public string CCARD_NUM { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(30)]
        public string CCARD_NAME { get; set; }

        [StringLength(117)]
        public string MAG_STRIP { get; set; }

        [Key]
        [Column(Order = 9, TypeName = "smallmoney")]
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

        [Key]
        [Column(Order = 10)]
        [StringLength(5)]
        public string DECLINE_CODE { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(3)]
        public string AVS_CODE { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(2)]
        public string CVV_CODE { get; set; }

        [Key]
        [Column(Order = 13)]
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
    }
}
