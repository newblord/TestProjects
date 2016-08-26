namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoanProductConfigTitle")]
    public partial class LoanProductConfigTitle
    {
        [Key]
        public int LOAN_PRODUCT_CONFIG_TITLE_KEY { get; set; }

        public int LOAN_PRODUCT_CONFIG_KEY { get; set; }

        public int LOAN_PRODUCT_KEY { get; set; }

        public decimal APPROVAL_PCT_EMPLOYED_24_PLUS_MONTHS { get; set; }

        public decimal APPROVAL_PCT_EMPLOYED_6_TO_23_MONTHS { get; set; }

        public decimal APPROVAL_PCT_EMPLOYED_UP_TO_5_MONTHS { get; set; }

        public decimal APPROVAL_PCT_WHOLESALE_GREATER_THAN_1500_CHECKING_ACCT { get; set; }

        public decimal APPROVAL_PCT_WHOLESALE_GREATER_THAN_1500_CHECKING_ACCT_DIRECT_DEPOSIT { get; set; }

        public decimal APPROVAL_PCT_WHOLESALE_GREATER_THAN_1500_DEBIT_CARD { get; set; }

        public decimal APPROVAL_PCT_WHOLESALE_UP_TO_1500_CHECKING_ACCT { get; set; }

        public decimal APPROVAL_PCT_WHOLESALE_UP_TO_1500_CHECKING_ACCT_DIRECT_DEPOSIT { get; set; }

        public decimal APPROVAL_PCT_WHOLESALE_UP_TO_1500_DEBIT_CARD { get; set; }

        public short LEGAL_MAX_LOAN_VEHICLE_VALUE_PCT { get; set; }

        [Required]
        [StringLength(1)]
        public string LEGAL_MAX_LOAN_VEHICLE_VALUE_WHOLESALE_OR_RETAIL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal LIEN_FEE_AMT { get; set; }

        public bool LIEN_FEE_FINANCED_ENABLED { get; set; }

        public int LOAN_AMT_MGR_OVERRIDE_VEHICLE_VALUE_PCT { get; set; }

        [Required]
        [StringLength(1)]
        public string LOAN_AMT_MGR_OVERRIDE_VEHICLE_WHOLESALE_OR_RETAIL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal LOAN_AMT_NO_INSURANCE_MAX_AMT { get; set; }

        public bool MAX_LOAN_VEHICLE_VALUE_PCT_ENABLED { get; set; }

        public bool MULT_LOANS_VIN_ENABLED { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ORIG_FEE_PCT_2ND_LIEN { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal REPO_ASSIGNMENT_MIN_BALANCE { get; set; }

        public bool REQUIRE_COPLEDGE_DETAILS { get; set; }

        public bool REQUIRE_COPLEDGE_EYE_COLOR { get; set; }

        public bool REQUIRE_COPLEDGE_GENDER { get; set; }

        public bool REQUIRE_COPLEDGE_HAIR_COLOR { get; set; }

        public bool REQUIRE_COPLEDGE_HEIGHT { get; set; }

        public bool REQUIRE_COPLEDGE_RACE { get; set; }

        public bool REQUIRE_COPLEDGE_SSN { get; set; }

        public bool REQUIRE_DETAILS { get; set; }

        public bool REQUIRE_EYE_COLOR { get; set; }

        public bool REQUIRE_GENDER { get; set; }

        public bool REQUIRE_HAIR_COLOR { get; set; }

        public bool REQUIRE_HEIGHT { get; set; }

        public bool REQUIRE_RACE { get; set; }

        public bool USE_FUEL_TYPE { get; set; }

        public bool USE_LEGAL_STATUS { get; set; }

        public bool USE_LIEN_HOLDER { get; set; }

        public bool USE_ODO_CODE { get; set; }

        public bool USE_REGISTRATION_DATE { get; set; }

        public bool USE_REGISTRATION_EXPIRES { get; set; }

        public bool USE_STATE_NUM { get; set; }

        public bool USE_STICKER_NUM { get; set; }

        public bool USE_TITLE_NUM { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal VEH_VALUE_MIN_AMT { get; set; }

        public byte MAX_LOAN_VEHICLE_VALUE_PCT { get; set; }

        [Required]
        [StringLength(1)]
        public string MAX_LOAN_VEHICLE_VALUE_PCT_WHOLESALE_OR_RETAIL { get; set; }

        public virtual LoanProduct LoanProduct { get; set; }

        public virtual LoanProductConfig LoanProductConfig { get; set; }
    }
}
