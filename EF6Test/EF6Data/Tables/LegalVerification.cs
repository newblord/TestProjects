namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LegalVerification")]
    public partial class LegalVerification
    {
        [Key]
        public int LEGAL_VERIFICATION_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        public int? RISREPT_KEY { get; set; }

        [Required]
        [StringLength(50)]
        public string RI_REFERENCE { get; set; }

        [Required]
        [StringLength(15)]
        public string DEBTOR_NUMBER { get; set; }

        [Required]
        [StringLength(255)]
        public string PLAINTIFF1 { get; set; }

        [Required]
        [StringLength(255)]
        public string PLAINTIFF2 { get; set; }

        [Required]
        [StringLength(60)]
        public string DEFENDANT_FULLNAME { get; set; }

        [Required]
        [StringLength(100)]
        public string DEFENDANT_ADDRESS_LINE { get; set; }

        [Required]
        [StringLength(100)]
        public string DEFENDANT_ADDRESS_CSZ { get; set; }

        [Required]
        [StringLength(11)]
        public string DEFENDANT_MASKED_SSN { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal CUSTOMER_BALANCE_DUE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal COURT_COSTS { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal DEFENDANT_TOTAL_DUE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal ATTORNEY_FEES { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal ATTORNEY_TITLE_LOAN_BAL_DUE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal ATTORNEY_CURRENT_BAL_DUE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal ATTORNEY_POST_JUDGE_DUE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PRINCIPLE_DUE { get; set; }

        public int EXCEPTION_REPORT_STATUS { get; set; }

        [StringLength(3)]
        public string VERIFIED_TELLER { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? VERIFIED_DATE { get; set; }

        [Required]
        [StringLength(100)]
        public string IMPORT_FILENAME { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime EXCEPTION_STATUS_LAST_UPDATED { get; set; }

        public byte REPORT_TYPE { get; set; }

        public virtual RISREPT RISREPT { get; set; }
    }
}
