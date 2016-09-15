namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Xflr")]
    public partial class Xflr
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int flrkey { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int flpkey { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int flkey { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int flbkey { get; set; }

        public int? flodkey { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ckey { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cakey { get; set; }

        public int? lkey { get; set; }

        public int? cckey { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FORM_LETTER_RESULT_KEY { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FORM_LETTER_PRINTED_KEY { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FORM_LETTER_BATCH_KEY { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CUSTOMER_KEY { get; set; }

        public int? CUSTOMER_ADDRESS_KEY { get; set; }

        [Key]
        [Column(Order = 10)]
        public byte FORM_LETTER_RESULT_FILE_TYPE { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(4)]
        public string FORM_LETTER_RESULT_ERROR_CODE { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(1)]
        public string FORM_LETTER_RESULT_FFWD_CODE { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(1)]
        public string FORM_LETTER_RESULT_DPV_CODE { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(2)]
        public string FORM_LETTER_RESULT_RET_CODE { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(10)]
        public string MAILING_SVC_JOB_NUM { get; set; }

        [StringLength(50)]
        public string Spell_FL_RESULT_FILE_TYPE { get; set; }

        [StringLength(50)]
        public string Spell_FL_RESULT_ERROR_CODE { get; set; }

        [StringLength(100)]
        public string Spell_FL_FFWD_CODE { get; set; }

        [StringLength(100)]
        public string Spell_FL_DPV_CODE { get; set; }

        [StringLength(20)]
        public string Spell_FL_RET_CODE { get; set; }

        [Key]
        [Column(Order = 16)]
        [StringLength(1)]
        public string x { get; set; }

        [Key]
        [Column(Order = 17, TypeName = "smalldatetime")]
        public DateTime BATCH_DATE { get; set; }

        [Key]
        [Column(Order = 18)]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Key]
        [Column(Order = 19)]
        [StringLength(1)]
        public string UPLOAD_OR_DOWNLOAD { get; set; }

        [Key]
        [Column(Order = 20)]
        [StringLength(1)]
        public string y { get; set; }

        [Key]
        [Column(Order = 21)]
        [StringLength(30)]
        public string FORM_LETTER_NAME { get; set; }

        [Key]
        [Column(Order = 22)]
        [StringLength(100)]
        public string FORM_LETTER_DESCRIPTION { get; set; }

        [Column(TypeName = "text")]
        public string FORM_LETTER_BODY { get; set; }

        [Key]
        [Column(Order = 23)]
        [StringLength(1)]
        public string LANGUAGE { get; set; }

        [Key]
        [Column(Order = 24)]
        public bool IS_DELETED { get; set; }

        [Key]
        [Column(Order = 25)]
        public bool IS_AD_ASTRA { get; set; }

        [Key]
        [Column(Order = 26)]
        public bool IS_INITIAL_LETTER { get; set; }

        [Key]
        [Column(Order = 27)]
        public bool IS_AD_ASTRA_ACH_LETTER { get; set; }

        [Key]
        [Column(Order = 28)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short AFTER_DAYS { get; set; }

        [Key]
        [Column(Order = 29)]
        public bool IS_AFTER_CREDIT_REPORT { get; set; }

        [Key]
        [Column(Order = 30, TypeName = "smalldatetime")]
        public DateTime PRINT_AFTER_COLL_DATE { get; set; }

        [Key]
        [Column(Order = 31, TypeName = "smallmoney")]
        public decimal MINIMUM_BALANCE { get; set; }

        public int? SET_AUDIT_CODE_KEY { get; set; }

        [Key]
        [Column(Order = 32)]
        [StringLength(50)]
        public string ON_DEMAND_PROMPT_1 { get; set; }

        [Key]
        [Column(Order = 33)]
        [StringLength(50)]
        public string ON_DEMAND_PROMPT_2 { get; set; }

        [Key]
        [Column(Order = 34)]
        [StringLength(50)]
        public string ON_DEMAND_PROMPT_3 { get; set; }

        [Key]
        [Column(Order = 35)]
        [StringLength(50)]
        public string ON_DEMAND_PROMPT_4 { get; set; }

        [Key]
        [Column(Order = 36)]
        [StringLength(50)]
        public string ON_DEMAND_PROMPT_5 { get; set; }

        [Key]
        [Column(Order = 37, TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Key]
        [Column(Order = 38)]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        [Key]
        [Column(Order = 39, TypeName = "smalldatetime")]
        public DateTime DATE_UPDATED { get; set; }

        [Key]
        [Column(Order = 40)]
        [StringLength(3)]
        public string UPDATED_BY { get; set; }

        [StringLength(3)]
        public string DELETED_BY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DELETED_DATE { get; set; }
    }
}
