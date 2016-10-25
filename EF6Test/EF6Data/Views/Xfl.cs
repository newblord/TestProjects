namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Xfl")]
    public partial class Xfl
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int flkey { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FORM_LETTER_KEY { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(30)]
        public string FORM_LETTER_NAME { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(100)]
        public string FORM_LETTER_DESCRIPTION { get; set; }

        [Column(TypeName = "text")]
        public string FORM_LETTER_BODY { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(1)]
        public string LANGUAGE { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool IS_DELETED { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool IS_AD_ASTRA { get; set; }

        [Key]
        [Column(Order = 7)]
        public bool IS_INITIAL_LETTER { get; set; }

        [Key]
        [Column(Order = 8)]
        public bool IS_AD_ASTRA_ACH_LETTER { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short AFTER_DAYS { get; set; }

        [Key]
        [Column(Order = 10)]
        public bool IS_AFTER_CREDIT_REPORT { get; set; }

        [Key]
        [Column(Order = 11, TypeName = "smalldatetime")]
        public DateTime PRINT_AFTER_COLL_DATE { get; set; }

        [Key]
        [Column(Order = 12, TypeName = "smallmoney")]
        public decimal MINIMUM_BALANCE { get; set; }

        public int? SET_AUDIT_CODE_KEY { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(50)]
        public string ON_DEMAND_PROMPT_1 { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(50)]
        public string ON_DEMAND_PROMPT_2 { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(50)]
        public string ON_DEMAND_PROMPT_3 { get; set; }

        [Key]
        [Column(Order = 16)]
        [StringLength(50)]
        public string ON_DEMAND_PROMPT_4 { get; set; }

        [Key]
        [Column(Order = 17)]
        [StringLength(50)]
        public string ON_DEMAND_PROMPT_5 { get; set; }

        [Key]
        [Column(Order = 18, TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Key]
        [Column(Order = 19)]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        [Key]
        [Column(Order = 20, TypeName = "smalldatetime")]
        public DateTime DATE_UPDATED { get; set; }

        [Key]
        [Column(Order = 21)]
        [StringLength(3)]
        public string UPDATED_BY { get; set; }

        [Key]
        [Column(Order = 22)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MINIMUM_RI_AGE { get; set; }

        [Key]
        [Column(Order = 23)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MAXIMUM_RI_AGE { get; set; }

        [Key]
        [Column(Order = 24)]
        public byte ADD_DAYS_TO_FOLLOWUP_DATE { get; set; }

        [StringLength(3)]
        public string DELETED_BY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DELETED_DATE { get; set; }

        [Key]
        [Column(Order = 25)]
        public bool USE_LAST_KNOWN_ADDRESS { get; set; }

        [Key]
        [Column(Order = 26)]
        public bool IS_LOAN_MATURED { get; set; }

        [Key]
        [Column(Order = 27)]
        public bool IS_LOAN_INACTIVE { get; set; }

        [StringLength(10)]
        public string RISK_ASSESSMENT { get; set; }

        [Key]
        [Column(Order = 28)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MINIMUM_AA_AGE { get; set; }

        [Key]
        [Column(Order = 29)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MAXIMUM_AA_AGE { get; set; }

        [Key]
        [Column(Order = 30)]
        public bool IS_LOAN_NOT_MATURED { get; set; }

        [Key]
        [Column(Order = 31)]
        public bool IS_LOAN_NOT_INACTIVE { get; set; }

        [Key]
        [Column(Order = 32)]
        public bool IS_LOAN_MATURED_OR_INACTIVE { get; set; }

        [Key]
        [Column(Order = 33)]
        public bool IS_LOAN_NOT_MATURED_OR_NOT_INACTIVE { get; set; }

        [Key]
        [Column(Order = 34)]
        public bool INCLUDE_PAYMENTS { get; set; }

        [Key]
        [Column(Order = 35)]
        public byte LETTER_ORDER { get; set; }

        [Key]
        [Column(Order = 36)]
        public bool KEEP_ADDRESS_WHEN_MAIL_RETURNED { get; set; }

        [Key]
        [Column(Order = 37, TypeName = "smallmoney")]
        public decimal MINIMUM_RI_AMOUNT { get; set; }

        [Key]
        [Column(Order = 38, TypeName = "smallmoney")]
        public decimal MAXIMUM_RI_AMOUNT { get; set; }

        [Key]
        [Column(Order = 39)]
        public bool SET_TO_PREV_AUDIT_ID { get; set; }

        [Key]
        [Column(Order = 40)]
        public bool EXCLUDE_SECOND_LIEN_LOANS { get; set; }

        [Key]
        [Column(Order = 41)]
        public bool IS_ACTIVE { get; set; }

        [Key]
        [Column(Order = 42)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short MINIMUM_CYCLES_PAST_DUE { get; set; }

        [Key]
        [Column(Order = 43)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short MAXIMUM_CYCLES_PAST_DUE { get; set; }

        [Key]
        [Column(Order = 44)]
        public bool IS_UK_ARREARS_NOTICE { get; set; }
    }
}
