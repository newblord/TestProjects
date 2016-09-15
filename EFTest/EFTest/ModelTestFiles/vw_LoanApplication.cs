namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_LoanApplication
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LOAN_APPLICATION_KEY { get; set; }

        [Key]
        [Column(Order = 1)]
        public byte LENDER_KEY { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short LOCATION { get; set; }

        public int? CUSTOMER_KEY { get; set; }

        public int? VISITOR_KEY { get; set; }

        public int? LOAN_KEY { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(25)]
        public string FIRST_NAME { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(25)]
        public string MID_NAME { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(25)]
        public string LAST_NAME { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(12)]
        public string HOME_PHONE { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(12)]
        public string CELL_PHONE { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(9)]
        public string SSN { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(9)]
        public string ABA_NUM { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(20)]
        public string ACCT_NUM { get; set; }

        [Key]
        [Column(Order = 11, TypeName = "smallmoney")]
        public decimal REQ_CASH_AMT { get; set; }

        [StringLength(18)]
        public string CCARD_NUM { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(4)]
        public string CCARD_CVV { get; set; }

        [Key]
        [Column(Order = 13)]
        public byte CCARD_EXP_MONTH { get; set; }

        [Key]
        [Column(Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short CCARD_EXP_YEAR { get; set; }

        [Key]
        [Column(Order = 15)]
        public bool CCARD_IS_DEBIT { get; set; }

        [Key]
        [Column(Order = 16)]
        [StringLength(50)]
        public string CCARD_NAME_ON_CARD { get; set; }

        [Key]
        [Column(Order = 17)]
        [StringLength(1)]
        public string LANGUAGE { get; set; }

        [Key]
        [Column(Order = 18)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int STATUS { get; set; }

        [Key]
        [Column(Order = 19)]
        [StringLength(1000)]
        public string REASON_DENIED { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NEXT_PAY_DATE { get; set; }

        [StringLength(3)]
        public string TELLER { get; set; }

        [StringLength(40)]
        public string ID_NO { get; set; }

        [StringLength(50)]
        public string SPOUSE_FIRST_NAME { get; set; }

        [StringLength(50)]
        public string SPOUSE_MID_NAME { get; set; }

        [StringLength(50)]
        public string SPOUSE_LAST_NAME { get; set; }

        [StringLength(9)]
        public string SPOUSE_SSN { get; set; }

        [StringLength(12)]
        public string SPOUSE_HOME_PHONE { get; set; }

        [StringLength(12)]
        public string SPOUSE_CELL_PHONE { get; set; }

        [StringLength(50)]
        public string SPOUSE_WORK_NAME { get; set; }

        [StringLength(12)]
        public string SPOUSE_WORK_PHONE { get; set; }

        [StringLength(10)]
        public string SPOUSE_WORK_PHONE_EXT { get; set; }

        [StringLength(1)]
        public string GENDER { get; set; }

        public bool? BOUNCED { get; set; }

        [StringLength(1)]
        public string HOW_REF_OBSOLETE { get; set; }

        [StringLength(50)]
        public string EMAIL { get; set; }

        [StringLength(50)]
        public string REF1_FIRST_NAME { get; set; }

        [StringLength(50)]
        public string REF1_LAST_NAME { get; set; }

        [StringLength(12)]
        public string REF1_PHONE { get; set; }

        [StringLength(1)]
        public string REF1_RELATIONSHIP { get; set; }

        [StringLength(50)]
        public string REF2_FIRST_NAME { get; set; }

        [StringLength(50)]
        public string REF2_LAST_NAME { get; set; }

        [StringLength(12)]
        public string REF2_PHONE { get; set; }

        [StringLength(1)]
        public string REF2_RELATIONSHIP { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? RI_BALANCE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? RI_FOLLOWUP { get; set; }

        public byte? OWN_RENT_OTHER { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? RESIDENCE_SINCE { get; set; }

        [StringLength(10)]
        public string LEGAL_NUMBER { get; set; }

        [StringLength(1)]
        public string COURTESY_CALL_NUM { get; set; }

        public int? CUST_ID_TYPE_KEY { get; set; }

        [StringLength(40)]
        public string CUST_ID_NUM { get; set; }

        [StringLength(15)]
        public string CUST_ID_SOURCE { get; set; }

        public int? CUST_ID_VERIFY_KEY { get; set; }

        [StringLength(30)]
        public string CUST_ID_VERIFY_OTHER { get; set; }

        public bool? ACTIVE_MILITARY { get; set; }

        public bool? MILITARY_MEMBER { get; set; }

        public bool? MILITARY_ACTIVE_DUTY { get; set; }

        public bool? MILITARY_COMBAT_DUTY { get; set; }

        public bool? MILITARY_RESERVE_NOT_ACTIVE { get; set; }

        public bool? MILITARY_RESERVE_ACTIVE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? MONTHLY_HOUSING { get; set; }

        public bool? INET_APPROVED { get; set; }

        public bool? CC_BLOCK { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DOB { get; set; }

        [Key]
        [Column(Order = 20)]
        [StringLength(1)]
        public string SOURCE_APP { get; set; }

        [Key]
        [Column(Order = 21, TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Key]
        [Column(Order = 22)]
        [StringLength(1)]
        public string SOURCE_DB { get; set; }

        [Key]
        [Column(Order = 23)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int WEB_REFERRAL_METHOD_KEY_OBSOLETE { get; set; }

        [Key]
        [Column(Order = 24)]
        public byte CC_COUNT { get; set; }

        [Key]
        [Column(Order = 25)]
        [StringLength(15)]
        public string IP_ADDRESS { get; set; }

        public byte? MARITAL_STATUS { get; set; }

        public bool? JOINT_LOAN { get; set; }

        [Key]
        [Column(Order = 26)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short REFERRAL_METHOD_KEY { get; set; }

        [StringLength(1)]
        public string LOAN_TYPE { get; set; }

        [StringLength(1)]
        public string PRODUCT_TYPE { get; set; }

        public int? PENNY_AUTH_KEY { get; set; }

        [StringLength(40)]
        public string VEH_MAKE { get; set; }

        [StringLength(100)]
        public string VEH_MODEL { get; set; }

        public short? VEH_YEAR { get; set; }

        [StringLength(40)]
        public string VEH_VIN { get; set; }

        [StringLength(30)]
        public string VEH_LIEN_HOLDER_NAME { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? VEH_LIEN_BALANCE { get; set; }

        public bool? VEH_LEASED { get; set; }

        public bool? ARBITRATION_OPT_IN { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? CCARD_GUARANTEE_AMT { get; set; }

        [StringLength(40)]
        public string CCARD_TOKEN { get; set; }

        [StringLength(1)]
        public string FUNDING_TYPE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CCARD_FROM_DATE { get; set; }

        public byte? CCARD_ISSUE_NUM { get; set; }

        [Key]
        [Column(Order = 27)]
        public byte CCARD_BRAND { get; set; }

        [Key]
        [Column(Order = 28)]
        public byte CCARD_TYPE { get; set; }

        [Key]
        [Column(Order = 29)]
        public bool IS_EPDQ_ONLY { get; set; }

        [Key]
        [Column(Order = 30)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TITLE { get; set; }

        public int? LOAN_PRODUCT_KEY { get; set; }

        public int? LOAN_PRODUCT_CONFIG_KEY { get; set; }

        public int? LOAN_PRODUCT_TILA_KEY { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? APPROVED_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? SELECTED_AMT { get; set; }

        public bool? SELECTED { get; set; }

        public byte? SELECTED_TERM { get; set; }

        public bool? APPROVED { get; set; }

        public string DETAIL { get; set; }

        public DateTime? PRIMARY_SCORE_DATE { get; set; }

        public short? MODEL_USED { get; set; }

        public decimal? FINAL_SCORE { get; set; }

        public int? SCORE_SUMMARY_KEY { get; set; }

        public bool? IS_PIN_VALIDATED { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? VALIDATED_DATE { get; set; }
    }
}
