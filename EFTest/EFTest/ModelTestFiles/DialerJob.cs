namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DialerJob")]
    public partial class DialerJob
    {
        [Key]
        public int DIALER_JOB_KEY { get; set; }

        [Required]
        [StringLength(100)]
        public string JOB_NAME { get; set; }

        public short STEP_ORDER { get; set; }

        [Required]
        [StringLength(255)]
        public string DESCRIPTION { get; set; }

        [Required]
        [StringLength(255)]
        public string EXPORT_FILE_NAME { get; set; }

        [StringLength(2)]
        public string JOB_TYPE { get; set; }

        public bool IS_AD_ASTRA { get; set; }

        [Required]
        [StringLength(1000)]
        public string LOCATIONS { get; set; }

        [Required]
        [StringLength(100)]
        public string PRODUCTS { get; set; }

        [Required]
        [StringLength(1000)]
        public string AUDIT_CATEGORIES { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal BALANCE_FROM { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal BALANCE_TO { get; set; }

        public int AGE_FROM { get; set; }

        public int AGE_TO { get; set; }

        public short SCORE_FROM { get; set; }

        public short SCORE_TO { get; set; }

        [Required]
        [StringLength(10)]
        public string LAST_NAME_FROM { get; set; }

        [Required]
        [StringLength(10)]
        public string LAST_NAME_TO { get; set; }

        [Required]
        [StringLength(10)]
        public string FOLLOW_UP_FROM { get; set; }

        [Required]
        [StringLength(10)]
        public string FOLLOW_UP_TO { get; set; }

        public bool PTP_CALL { get; set; }

        public bool VALID_CC { get; set; }

        public bool DIRECT_DEPOSIT { get; set; }

        public bool TODAY_PRIOR { get; set; }

        public bool TODAY_PLUS1 { get; set; }

        public bool TODAY_PLUS2 { get; set; }

        public bool RUN_SUNDAY { get; set; }

        public bool RUN_MONDAY { get; set; }

        public bool RUN_TUESDAY { get; set; }

        public bool RUN_WEDNESDAY { get; set; }

        public bool RUN_THURSDAY { get; set; }

        public bool RUN_FRIDAY { get; set; }

        public bool RUN_SATURDAY { get; set; }

        [StringLength(10)]
        public string RISK_ASSESSMENT { get; set; }

        public int ADASTRA_AGE_FROM { get; set; }

        public int ADASTRA_AGE_TO { get; set; }

        [Required]
        [StringLength(512)]
        public string EXCLUDE_PHONE_AREACODES { get; set; }

        public bool HAS_BROKEN_PTPS { get; set; }

        public int BROKEN_PTP_DAYS { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal BALANCE_TEST { get; set; }

        [Required]
        [StringLength(1)]
        public string PREFERRED_LANGUAGE { get; set; }
    }
}
