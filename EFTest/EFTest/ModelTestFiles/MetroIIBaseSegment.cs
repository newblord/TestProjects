namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MetroIIBaseSegment")]
    public partial class MetroIIBaseSegment
    {
        [Key]
        public int METROII_BASE_SEGMENT_KEY { get; set; }

        [Column(TypeName = "date")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(1)]
        public string CORRECTION_INDICATOR { get; set; }

        [Required]
        [StringLength(20)]
        public string IDENTIFICATION_NUMBER { get; set; }

        [StringLength(2)]
        public string CYCLE_IDENTIFIER { get; set; }

        public int? CONSUMER_ACCOUNT_NUMBER { get; set; }

        [Required]
        [StringLength(1)]
        public string PORTFOLIO_TYPE { get; set; }

        [Required]
        [StringLength(2)]
        public string ACCOUNT_TYPE { get; set; }

        [Column(TypeName = "date")]
        public DateTime DATE_OPENED { get; set; }

        public int CREDIT_LIMIT { get; set; }

        public int ORIGINAL_LOAN_AMOUNT { get; set; }

        public short TERMS_DURATION { get; set; }

        [Required]
        [StringLength(1)]
        public string TERMS_FREQUENCY { get; set; }

        public int SCHEDULE_PAYMENT_AMOUNT { get; set; }

        public int ACTUAL_PAYMENT_AMOUNT { get; set; }

        [StringLength(2)]
        public string ACCOUNT_STATUS { get; set; }

        [Required]
        [StringLength(1)]
        public string PAYMENT_RATING { get; set; }

        [Required]
        [StringLength(24)]
        public string PAYMENT_HISTORY_PROFILE { get; set; }

        [StringLength(2)]
        public string SPECIAL_COMMENT { get; set; }

        [StringLength(2)]
        public string COMPLIANCE_CONDITION_CODE { get; set; }

        public int CURRENT_BALANCE { get; set; }

        public int AMOUNT_PAST_DUE { get; set; }

        public int ORIGINAL_CHARGE_OFF_AMOUNT { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATE_FIRST_DELINQUENCY { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATE_CLOSED { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATE_LAST_PAYMENT { get; set; }

        [Required]
        [StringLength(1)]
        public string CONSUMER_TRANSACTION_TYPE { get; set; }

        [Required]
        [StringLength(25)]
        public string SURNAME { get; set; }

        [Required]
        [StringLength(20)]
        public string FIRST_NAME { get; set; }

        [Required]
        [StringLength(20)]
        public string MIDDLE_NAME { get; set; }

        [StringLength(1)]
        public string GENERATION_CODE { get; set; }

        [Required]
        [StringLength(9)]
        public string SOCIAL_INSURANCE_NUMBER { get; set; }

        [Column(TypeName = "date")]
        public DateTime DATE_OF_BIRTH { get; set; }

        [Required]
        [StringLength(10)]
        public string TELEPHONE_NUMBER { get; set; }

        [Required]
        [StringLength(1)]
        public string ASSOCIATION_CODE { get; set; }

        [StringLength(2)]
        public string CONSUMER_INFORMATION_INDICATOR { get; set; }

        [StringLength(2)]
        public string COUNTRY_CODE { get; set; }

        [Required]
        [StringLength(32)]
        public string ADDRESS_LINE_1 { get; set; }

        [Required]
        [StringLength(32)]
        public string ADDRESS_LINE_2 { get; set; }

        [Required]
        [StringLength(20)]
        public string CITY { get; set; }

        [Required]
        [StringLength(2)]
        public string PROVINCE { get; set; }

        [Required]
        [StringLength(9)]
        public string POSTAL_CODE { get; set; }

        [Required]
        [StringLength(1)]
        public string ADDRESS_INDICATOR { get; set; }

        [Required]
        [StringLength(1)]
        public string RESIDENCE_CODE { get; set; }

        public int CUSTOMER_KEY { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
