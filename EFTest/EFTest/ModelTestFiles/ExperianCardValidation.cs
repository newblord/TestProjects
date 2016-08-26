namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ExperianCardValidation")]
    public partial class ExperianCardValidation
    {
        [Key]
        public int EXPERIAN_CARD_VALIDATION_KEY { get; set; }

        public DateTime DATE_ENTERED { get; set; }

        public int? CUSTOMER_KEY { get; set; }

        public int? LOAN_APPLICATION_KEY { get; set; }

        [Required]
        [StringLength(50)]
        public string CALL_NAME { get; set; }

        [Required]
        [StringLength(8000)]
        public string SENT_DATA { get; set; }

        [Required]
        [StringLength(40)]
        public string TOKEN { get; set; }

        public bool? SUCCESSFULLY_VERIFIED { get; set; }

        [StringLength(255)]
        public string RESPONSE_ID { get; set; }

        [StringLength(50)]
        public string PRE_AUTHORISED { get; set; }

        public bool? AVS_MATCHED { get; set; }

        public bool? CVV_MATCHED { get; set; }

        public bool? POSTCODE_MATCHED { get; set; }

        public int? CARD_CONDITION_CODE { get; set; }

        public int? CARD_CONDITION_REASON { get; set; }

        [StringLength(10)]
        public string CARD_CONDITION_SEVERITY { get; set; }

        [StringLength(50)]
        public string CARD_TYPE { get; set; }

        [StringLength(50)]
        public string CARD_SUB_TYPE { get; set; }

        [StringLength(50)]
        public string CARD_SCHEME_NAME { get; set; }

        [StringLength(255)]
        public string CARD_ISSUER_NAME { get; set; }

        [StringLength(50)]
        public string ABA_MATCH_RESULT { get; set; }

        [StringLength(8000)]
        public string RAW_RESPONSE_DATA { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual LoanApplication LoanApplication { get; set; }
    }
}
