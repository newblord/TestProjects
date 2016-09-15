namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Global")]
    public partial class Global
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GLOBAL_KEY { get; set; }

        public double MAX_SVC { get; set; }

        public double MAX_CHK { get; set; }

        [Required]
        [StringLength(120)]
        public string VAULT_MGR_SG_VALUES { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Last_Release { get; set; }

        public DateTime LAST_DIALER_IMPORT { get; set; }

        public short? TMP_BS_FLAG { get; set; }

        public int? LAST_TD_KEY_INT_SHORT { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DOC_TRACK_START_DATE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DOC_STATUS_START_DATE { get; set; }

        [StringLength(100)]
        public string OE_STATEMENT_EMAIL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal MAX_DRAWER_CLOSE_AMT { get; set; }

        public byte DAYS_CHECKS_NOT_RERETURNABLE { get; set; }

        [Required]
        [StringLength(20)]
        public string APP_NAME { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? SDN_LIST_LAST_UPDATE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal INCOME_GROSS_UPPER_LIMIT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal INCOME_GROSS_LOWER_LIMIT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal INCOME_NET_UPPER_LIMIT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal INCOME_NET_LOWER_LIMIT { get; set; }

        [Required]
        [StringLength(40)]
        public string SPROC_NAME1 { get; set; }

        [Required]
        [StringLength(40)]
        public string SPROC_NAME2 { get; set; }

        [Required]
        [StringLength(40)]
        public string SPROC_NAME3 { get; set; }

        [Required]
        [StringLength(500)]
        public string SPROC_LIVE_CONN1 { get; set; }

        [Required]
        [StringLength(500)]
        public string SPROC_LIVE_CONN2 { get; set; }

        [Required]
        [StringLength(500)]
        public string SPROC_LIVE_CONN3 { get; set; }

        [Required]
        [StringLength(500)]
        public string SPROC_TEST_CONN1 { get; set; }

        [Required]
        [StringLength(500)]
        public string SPROC_TEST_CONN2 { get; set; }

        [Required]
        [StringLength(500)]
        public string SPROC_TEST_CONN3 { get; set; }

        [Required]
        [StringLength(255)]
        public string LOAN_DOC_SYNC_PATH_1 { get; set; }

        [Required]
        [StringLength(255)]
        public string LOAN_DOC_SYNC_PATH_2 { get; set; }

        [Required]
        [StringLength(255)]
        public string LOAN_DOC_SYNC_PATH_3 { get; set; }

        [Required]
        [StringLength(255)]
        public string LOAN_DOC_SYNC_PATH_4 { get; set; }

        public bool LOAN_DOC_SYNC_INC_REV_1 { get; set; }

        public bool LOAN_DOC_SYNC_INC_REV_2 { get; set; }

        public bool LOAN_DOC_SYNC_INC_REV_3 { get; set; }

        public bool LOAN_DOC_SYNC_INC_REV_4 { get; set; }

        public bool LOAN_DOC_SYNC_IGNORE_EXT_1 { get; set; }

        public bool LOAN_DOC_SYNC_IGNORE_EXT_2 { get; set; }

        public bool LOAN_DOC_SYNC_IGNORE_EXT_3 { get; set; }

        public bool LOAN_DOC_SYNC_IGNORE_EXT_4 { get; set; }

        public byte? CHECKAGAIN_DEFAULTED_DAYS { get; set; }

        public short NETSPEND_PORT_NUM { get; set; }

        [Required]
        [StringLength(15)]
        public string NETSPEND_SERVER_IP { get; set; }

        [Required]
        [StringLength(30)]
        public string NETSPEND_USER_ID { get; set; }

        [Required]
        [StringLength(15)]
        public string NETSPEND_PASSWORD { get; set; }

        public byte AD_ASTRA_COMMISSION_PCT { get; set; }

        [Required]
        [StringLength(16)]
        public string KARPOWER_PASSWORD { get; set; }

        [Required]
        [StringLength(40)]
        public string KBB_USERNAME { get; set; }

        [Required]
        [StringLength(40)]
        public string KBB_PASSWORD { get; set; }

        public bool CONVERSION_SQL_UPDATED { get; set; }

        [Required]
        [StringLength(25)]
        public string CONVERSION_SQL_FILENAME { get; set; }

        [Required]
        [StringLength(50)]
        public string AD_ASTRA_NPA_EPP_KEY { get; set; }

        public int KBB_MILEAGE_THRESHOLD { get; set; }

        public DateTime? WEB_EOD_START { get; set; }

        public decimal? APP_VERSION { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal GOLD_PRICE_PER_GRAM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime GOLD_LAST_UPDATE { get; set; }

        public decimal LESS_TARGET_VARIANCE { get; set; }

        public decimal GREATER_TARGET_VARIANCE { get; set; }

        public bool PRINT_CUSTOMER_REGISTRATION { get; set; }

        public short LAST_USED_TELPAY_SEQUENCE_NBR { get; set; }

        [Required]
        [StringLength(30)]
        public string FIELD_SOLUTIONS_PASSWORD { get; set; }

        [Column(TypeName = "date")]
        public DateTime NEXT_RICC_MASTERCARD_DATE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? RESTORE_DATE { get; set; }

        public short MIN_NBR_BLOCKED_ADDRESS_FIELDS_TO_MATCH { get; set; }

        public short MAX_CC_ATTEMPTS_PER_DAY { get; set; }

        public short MAX_CC_ATTEMPTS_PER_MONTH { get; set; }

        public short MAX_CC_ATTEMPTS_WITHIN_XDAYS { get; set; }

        public short MAX_CC_DAYS_FOR_ATTEMPTS_WITHIN_XDAYS { get; set; }

        public bool RESTART_MAX_CC_ATTEMPS_AFTER_PAID { get; set; }

        public int? MAX_AVS_VALIDATION_DECLINES { get; set; }

        public int? AVS_VALIDATION_COOL_OFF_HOURS { get; set; }

        public bool INCLUDE_PRE_AUTH_IN_MAX_ATTEMPTS_CNT { get; set; }

        public short ACCOUNT_VERIFICATION_VALID_FOR_X_DAYS { get; set; }

        public bool USE_RECURRING_IN_MAX_ATTEMPTS_CNT { get; set; }

        public short CAPS_CC_MAXATTEMPT_SPAY { get; set; }

        public short CAPS_CC_MAXATTEMPT_MPAY { get; set; }

        public short CAPS_CC_MAXATTEMPT_OEND { get; set; }

        [Required]
        [StringLength(25)]
        public string DATA_PROTECTION_REGISTRATION_NUM { get; set; }

        [Required]
        [StringLength(25)]
        public string INTERIM_PERMISSION_NUM { get; set; }

        [Required]
        [StringLength(25)]
        public string COMPANY_NUM { get; set; }

        public bool ENABLE_DECLINE_COOLING_OFF { get; set; }

        public int DECLINE_COOLING_OFF_MIN { get; set; }

        [Required]
        [StringLength(50)]
        public string CHIEF_EXECUTIVE_OFFICER { get; set; }

        public bool ENABLE_AML_REPORTING { get; set; }

        public bool BREAKING_OUT_OF_COLLECTIONS_AND_FEE_ATTEMPTS_ENABLED { get; set; }

        public int MAX_DAYS_FOR_ACH_REPRESENTMENT { get; set; }

        public int MIN_ACH_PAYMENT_AMOUNT_PCT { get; set; }

        public int MAX_ACH_PAYMENT_AMOUNT_PCT { get; set; }

        public bool CUSTOMER_FEEDBACK_ENABLED { get; set; }
    }
}
