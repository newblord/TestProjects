namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Xrr")]
    public partial class Xrr
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int rrkey { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ckey { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ikey { get; set; }

        public int? lkey { get; set; }

        public int? cckey { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATE_no_time { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ad_astra_date { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(1)]
        public string product_type { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "smalldatetime")]
        public DateTime DATE { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(3)]
        public string TLR { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short LOCATION { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? AMOUNT { get; set; }

        [Key]
        [Column(Order = 7, TypeName = "smallmoney")]
        public decimal SURCHG { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? FOLLOWUP { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CUSTOMER_KEY { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ISSUER_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? MANUAL_ACH_DATE { get; set; }

        [StringLength(3)]
        public string MANUAL_TELLER { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RISREPT_KEY { get; set; }

        public int? LOAN_KEY { get; set; }

        [Key]
        [Column(Order = 11, TypeName = "smallmoney")]
        public decimal RI_BALANCE { get; set; }

        [Key]
        [Column(Order = 12)]
        public byte PRA { get; set; }

        [Key]
        [Column(Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ris_type_id { get; set; }

        public int? Ris_Audit_ID { get; set; }

        [Key]
        [Column(Order = 14)]
        public bool STOP_PAYMENT { get; set; }

        [Key]
        [Column(Order = 15)]
        public bool reversed { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? reversed_date { get; set; }

        public int? CASHED_CHECK_KEY { get; set; }

        public int? DOS_REFNO { get; set; }

        [StringLength(50)]
        public string DOS_MIGRATED_ID { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? MANUAL_ACH_AMOUNT { get; set; }

        public int? MANUAL_ACH_PTP { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? LAST_CALL_DATE { get; set; }

        public short? LAST_CALL_HOST_CODE { get; set; }

        [Key]
        [Column(Order = 16)]
        public bool DO_NOT_CALL_HOME { get; set; }

        [Key]
        [Column(Order = 17)]
        public bool DO_NOT_CALL_WORK { get; set; }

        [Key]
        [Column(Order = 18)]
        public bool DO_NOT_CALL_CELL { get; set; }

        [Key]
        [Column(Order = 19)]
        public bool DO_NOT_SEND_LETTERS { get; set; }

        public bool? DO_NOT_CALL_VERBAL_DNC { get; set; }

        public int? OPTPLUS_CARD_DETAIL_KEY { get; set; }

        [StringLength(43)]
        public string REFERENCE { get; set; }

        [Key]
        [Column(Order = 20)]
        public byte RISK_ASSESSMENT { get; set; }

        [Key]
        [Column(Order = 21)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int COLLECTION_AGENCY_KEY { get; set; }

        [Key]
        [Column(Order = 22)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ASSIGNMENT_NUMBER { get; set; }

        [Key]
        [Column(Order = 23)]
        [StringLength(3)]
        public string CR_TELLER { get; set; }

        [Key]
        [Column(Order = 24)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int REASON_FOR_ARREARS_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? LAST_DCARD_ATTEMPT_DATE { get; set; }

        [Key]
        [Column(Order = 25)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RI_URGENT_NOTE_KEY { get; set; }

        [Key]
        [Column(Order = 26)]
        public bool KEEP_WITH_AGENCY { get; set; }

        [Column(TypeName = "date")]
        public DateTime? AD_ASTRA_ASSIGNED_DATE { get; set; }

        [Key]
        [Column(Order = 27)]
        [StringLength(2)]
        public string X1 { get; set; }

        [StringLength(2)]
        public string ra_AUDIT { get; set; }

        [StringLength(50)]
        public string ra_DESC { get; set; }

        [StringLength(10)]
        public string ra_SHORT { get; set; }

        public bool? ra_DISPLAYED { get; set; }

        public bool? ra_IS_AD_ASTRA { get; set; }

        public bool? ra_IS_IN_LEGAL_STATUS { get; set; }

        [Key]
        [Column(Order = 28)]
        [StringLength(2)]
        public string X2 { get; set; }

        [StringLength(1)]
        public string rt_TYPE { get; set; }

        [StringLength(25)]
        public string rt_DESC { get; set; }

        [Key]
        [Column(Order = 29)]
        [StringLength(2)]
        public string X3 { get; set; }

        [StringLength(25)]
        public string c_LASTNAME { get; set; }

        [StringLength(24)]
        public string c_FIRSTNAME { get; set; }
    }
}
