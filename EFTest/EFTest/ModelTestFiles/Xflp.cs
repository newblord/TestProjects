namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Xflp")]
    public partial class Xflp
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int flpkey { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int flkey { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int flbkey { get; set; }

        public int? flodkey { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ckey { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cakey { get; set; }

        public int? lkey { get; set; }

        public int? cckey { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FORM_LETTER_PRINTED_KEY { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FORM_LETTER_KEY { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CUSTOMER_KEY { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CUSTOMER_ADDRESS_KEY { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FORM_LETTER_BATCH_KEY { get; set; }

        public int? FORM_LETTER_ON_DEMAND_KEY { get; set; }

        public int? LOAN_KEY { get; set; }

        public int? PROMISE_TO_PAY_DETAIL_KEY { get; set; }

        [Key]
        [Column(Order = 10)]
        public byte FORM_LETTER_RESULT_FILE_TYPE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? VENDOR_DATE_PRINTED { get; set; }

        [StringLength(10)]
        public string VENDOR_JOB_CODE { get; set; }

        public byte? PROCESSING_STATE_KEY { get; set; }

        public int? CASHED_CHECK_KEY { get; set; }

        public int? OPTPLUS_CARD_DETAIL_KEY { get; set; }

        public int? DWDOCID { get; set; }

        public int? RISREPT_KEY { get; set; }

        [StringLength(50)]
        public string Spell_FL_RESULT_FILE_TYPE { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(1)]
        public string x { get; set; }

        [Key]
        [Column(Order = 12, TypeName = "smalldatetime")]
        public DateTime BATCH_DATE { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(1)]
        public string UPLOAD_OR_DOWNLOAD { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(1)]
        public string y { get; set; }

        [Key]
        [Column(Order = 16)]
        [StringLength(30)]
        public string FORM_LETTER_NAME { get; set; }

        [Key]
        [Column(Order = 17)]
        [StringLength(100)]
        public string FORM_LETTER_DESCRIPTION { get; set; }

        [Column(TypeName = "text")]
        public string FORM_LETTER_BODY { get; set; }

        [Key]
        [Column(Order = 18)]
        [StringLength(1)]
        public string LANGUAGE { get; set; }

        [Key]
        [Column(Order = 19)]
        public bool IS_DELETED { get; set; }

        [Key]
        [Column(Order = 20)]
        public bool IS_AD_ASTRA { get; set; }

        [Key]
        [Column(Order = 21)]
        public bool IS_INITIAL_LETTER { get; set; }

        [Key]
        [Column(Order = 22)]
        public bool IS_AD_ASTRA_ACH_LETTER { get; set; }

        [Key]
        [Column(Order = 23)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short AFTER_DAYS { get; set; }

        [Key]
        [Column(Order = 24)]
        public bool IS_AFTER_CREDIT_REPORT { get; set; }

        [Key]
        [Column(Order = 25, TypeName = "smalldatetime")]
        public DateTime PRINT_AFTER_COLL_DATE { get; set; }

        [Key]
        [Column(Order = 26, TypeName = "smallmoney")]
        public decimal MINIMUM_BALANCE { get; set; }

        public int? SET_AUDIT_CODE_KEY { get; set; }

        [Key]
        [Column(Order = 27)]
        [StringLength(50)]
        public string ON_DEMAND_PROMPT_1 { get; set; }

        [Key]
        [Column(Order = 28)]
        [StringLength(50)]
        public string ON_DEMAND_PROMPT_2 { get; set; }

        [Key]
        [Column(Order = 29)]
        [StringLength(50)]
        public string ON_DEMAND_PROMPT_3 { get; set; }

        [Key]
        [Column(Order = 30)]
        [StringLength(50)]
        public string ON_DEMAND_PROMPT_4 { get; set; }

        [Key]
        [Column(Order = 31)]
        [StringLength(50)]
        public string ON_DEMAND_PROMPT_5 { get; set; }

        [Key]
        [Column(Order = 32, TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Key]
        [Column(Order = 33)]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        [Key]
        [Column(Order = 34, TypeName = "smalldatetime")]
        public DateTime DATE_UPDATED { get; set; }

        [Key]
        [Column(Order = 35)]
        [StringLength(3)]
        public string UPDATED_BY { get; set; }

        [StringLength(3)]
        public string DELETED_BY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DELETED_DATE { get; set; }
    }
}
