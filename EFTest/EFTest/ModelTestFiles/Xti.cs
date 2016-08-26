namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Xti")]
    public partial class Xti
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int sgkey { get; set; }

        [StringLength(3)]
        public string TELLER { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string PASSWORD { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string FIRSTNAME { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(15)]
        public string LSTNAME { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? LAST_LOGIN { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short location { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SECURITYGROUP_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? LastPWChg { get; set; }

        [StringLength(30)]
        public string RSAPassword { get; set; }

        [StringLength(12)]
        public string SWIPE_ID { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool DisplayReleaseInfo { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(9)]
        public string SSN { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(10)]
        public string ADP_ID { get; set; }

        [Key]
        [Column(Order = 9)]
        public bool AUDIT_REQUIRED { get; set; }

        [Column(TypeName = "date")]
        public DateTime? HIRE_DATE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CERT_DATE { get; set; }

        [StringLength(3)]
        public string CERT_BY { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short LAST_LOCATION { get; set; }

        [Key]
        [Column(Order = 11)]
        public bool ACCOUNT_LOCKED { get; set; }

        [Key]
        [Column(Order = 12)]
        public byte ATTEMPTS { get; set; }

        [Key]
        [Column(Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TELLER_ID_KEY { get; set; }

        public int? LAST_SELECTED_CUSTOMER_KEY { get; set; }

        public int? LAST_SELECTED_LOAN_KEY { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(500)]
        public string LOCATION_LISTVIEW_COLUMNS { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(40)]
        public string LOCATION_LISTVIEW_COLUMN_WIDTHS { get; set; }

        [Key]
        [Column(Order = 16)]
        [StringLength(40)]
        public string LOCATION_LISTVIEW_SORT { get; set; }

        [Key]
        [Column(Order = 17)]
        public bool SHOW_OPS_NEWS { get; set; }

        [Key]
        [Column(Order = 18)]
        public byte QUESTION_ATTEMPTS { get; set; }

        [Key]
        [Column(Order = 19)]
        public byte TELLER_TYPE { get; set; }

        public int? TITLE_KEY { get; set; }

        [StringLength(20)]
        public string SAM_ACCOUNT_NAME { get; set; }

        [Key]
        [Column(Order = 20)]
        [StringLength(1)]
        public string X { get; set; }

        [StringLength(40)]
        public string SG_NAME { get; set; }

        public bool? IS_COLLECTOR { get; set; }

        public bool? IS_AD_ASTRA { get; set; }

        [StringLength(256)]
        public string SG_VALUES { get; set; }
    }
}
