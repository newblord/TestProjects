namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Xah")]
    public partial class Xah
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ahkey { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int askey { get; set; }

        public int? arkey { get; set; }

        public int? tdkey { get; set; }

        public int? slpkey { get; set; }

        public int? rlpkey { get; set; }

        [StringLength(50)]
        public string Spell_TRANS_CODE { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ckey { get; set; }

        public int? lkey { get; set; }

        public DateTime? ds { get; set; }

        public bool? sp { get; set; }

        public DateTime? dr { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(1)]
        public string ah { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ACH_HISTORY_KEY { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CUSTOMER_KEY { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short LOCATION { get; set; }

        public int? LOAN_KEY { get; set; }

        [Column(TypeName = "money")]
        public decimal? ACH_AMOUNT { get; set; }

        [Key]
        [Column(Order = 7)]
        public byte ACH_ATTEMPT { get; set; }

        [Key]
        [Column(Order = 8, TypeName = "smalldatetime")]
        public DateTime PROJ_SEND_DATE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? MANUAL_SEND_DATE { get; set; }

        [StringLength(3)]
        public string MANUAL_TELLER { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ACH_SENT_KEY { get; set; }

        public int? ACH_RECV_KEY { get; set; }

        [StringLength(3)]
        public string ACH_RESULT_CODE { get; set; }

        [Key]
        [Column(Order = 10)]
        public DateTime DATE_ENTERED { get; set; }

        [StringLength(20)]
        public string ABA_NO { get; set; }

        [StringLength(20)]
        public string BANK_NO { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int jobid { get; set; }

        public int? TRANS_DETAIL_KEY { get; set; }

        public int? SEND_LOAN_PAYMENT_KEY { get; set; }

        public int? RECV_LOAN_PAYMENT_KEY { get; set; }

        [Key]
        [Column(Order = 12)]
        public bool IS_AD_ASTRA { get; set; }

        [Key]
        [Column(Order = 13)]
        public bool IS_ACH_PAID { get; set; }

        public int? REFUND_LOAN_PAYMENT_KEY { get; set; }

        public short? ACH_REASON_CODE { get; set; }

        public int? OPTPLUS_CARD_DETAIL_KEY { get; set; }

        [StringLength(20)]
        public string STATEMENT_ID { get; set; }

        [Key]
        [Column(Order = 14, TypeName = "smallmoney")]
        public decimal PRINC_AMT_FOR_INTEREST_CREDIT { get; set; }

        [Key]
        [Column(Order = 15, TypeName = "smallmoney")]
        public decimal FEES_AMT_FOR_INTEREST_CREDIT { get; set; }

        [Key]
        [Column(Order = 16, TypeName = "smallmoney")]
        public decimal INTEREST_DUE_CAP { get; set; }

        [Key]
        [Column(Order = 17, TypeName = "smallmoney")]
        public decimal CAB_INTEREST_DUE_CAP { get; set; }

        [Key]
        [Column(Order = 18)]
        public bool SCHED_PAYMENT { get; set; }

        [Key]
        [Column(Order = 19)]
        public bool IS_CREDIT { get; set; }

        [Key]
        [Column("as", Order = 20)]
        [StringLength(1)]
        public string _as { get; set; }

        public short? as_LOCATION { get; set; }

        [StringLength(50)]
        public string FILE_NAME_SENT { get; set; }

        [StringLength(50)]
        public string FILE_NAME_UPDATED { get; set; }

        public int? ITEM_COUNT { get; set; }

        [Column(TypeName = "money")]
        public decimal? ITEM_TOTAL { get; set; }

        public DateTime? DATE_SENT { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? EXPECTED_RESULTS { get; set; }

        public bool? SCHEDULED_PAYMENTS { get; set; }

        [Key]
        [Column(Order = 21)]
        [StringLength(1)]
        public string ar { get; set; }

        [StringLength(50)]
        public string FILE_NAME_RECV { get; set; }

        public DateTime? DATE_RECV { get; set; }

        public int? PAID_COUNT { get; set; }

        [Column(TypeName = "money")]
        public decimal? PAID_TOTAL { get; set; }

        public int? UNPAID_COUNT { get; set; }

        [Column(TypeName = "money")]
        public decimal? UNPAID_TOTAL { get; set; }

        [Key]
        [Column(Order = 22)]
        public DateTime de { get; set; }
    }
}
