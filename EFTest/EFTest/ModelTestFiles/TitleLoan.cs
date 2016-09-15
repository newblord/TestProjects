namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TitleLoan")]
    public partial class TitleLoan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TitleLoan()
        {
            RepoCaseHistories = new HashSet<RepoCaseHistory>();
            TitleLoanApprovals = new HashSet<TitleLoanApproval>();
        }

        [Key]
        public int TITLELOAN_KEY { get; set; }

        public int LOAN_KEY { get; set; }

        public int VEHICLE_KEY { get; set; }

        public int CUSTOMER_KEY { get; set; }

        public short LOCATION { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        public DateTime DATE_ENTERED { get; set; }

        [Column(TypeName = "money")]
        public decimal VEH_WHOLESALE { get; set; }

        public int VEH_MILEAGE { get; set; }

        [Required]
        [StringLength(1)]
        public string VEH_CONDITION { get; set; }

        [Required]
        [StringLength(10)]
        public string VEH_PLATE { get; set; }

        [Required]
        [StringLength(20)]
        public string VEH_STICKER { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? VEH_REG_DATE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? VEH_REG_EXPIRE { get; set; }

        [Required]
        [StringLength(2)]
        public string VEH_REG_STATE { get; set; }

        [Required]
        [StringLength(15)]
        public string VEH_TITLE_NUM { get; set; }

        [Required]
        [StringLength(1)]
        public string VEH_ODO_CODE { get; set; }

        [Required]
        [StringLength(1)]
        public string LEGAL_STATUS { get; set; }

        [Required]
        [StringLength(20)]
        public string STATE_CUST_NUM { get; set; }

        [Required]
        [StringLength(40)]
        public string INS_NAME { get; set; }

        [Required]
        [StringLength(12)]
        public string INS_PHONE { get; set; }

        public bool INS_FULL_COVER { get; set; }

        [Required]
        [StringLength(40)]
        public string INS_POLICY_NUM { get; set; }

        public bool PAY_VERIFIED { get; set; }

        [StringLength(59)]
        public string AND_OR_NAME { get; set; }

        public int? LIEN_HOLDER_KEY { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? LIEN_BALANCE { get; set; }

        [StringLength(20)]
        public string LIEN_ACCT_NUM { get; set; }

        [StringLength(40)]
        public string VEH_VIN { get; set; }

        [StringLength(40)]
        public string VEH_MAKE { get; set; }

        [StringLength(100)]
        public string VEH_MODEL { get; set; }

        [StringLength(100)]
        public string VEH_BODY { get; set; }

        [StringLength(40)]
        public string VEH_ENGINE { get; set; }

        [StringLength(40)]
        public string VEH_TRANS { get; set; }

        [StringLength(40)]
        public string VEH_DRIVE { get; set; }

        [StringLength(40)]
        public string VEH_MISC_EQUIP1 { get; set; }

        [StringLength(40)]
        public string VEH_MISC_EQUIP2 { get; set; }

        [StringLength(40)]
        public string VEH_MISC_EQUIP3 { get; set; }

        public short VEH_YEAR { get; set; }

        [Column(TypeName = "money")]
        public decimal LIST_PRICE { get; set; }

        [StringLength(20)]
        public string VEH_COLOR { get; set; }

        [StringLength(1)]
        public string FUEL_TYPE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal VEH_RETAIL { get; set; }

        [StringLength(1)]
        public string VEH_KOV { get; set; }

        public bool IS_CLEAR_TITLE { get; set; }

        public bool IS_EXPRESS { get; set; }

        [Required]
        [StringLength(1)]
        public string GENDER { get; set; }

        public byte HEIGHT_FEET { get; set; }

        public byte HEIGHT_INCHES { get; set; }

        public short WEIGHT { get; set; }

        public byte RACE { get; set; }

        public byte EYE_COLOR { get; set; }

        public byte HAIR_COLOR { get; set; }

        [Required]
        [StringLength(10)]
        public string VEH_ENGINE_SIZE { get; set; }

        [Required]
        [StringLength(20)]
        public string VEH_ENGINE_NUMBER { get; set; }

        public bool VEH_NO_LONGER_OWNED_BY_CUST { get; set; }

        [Required]
        [StringLength(50)]
        public string LENDER_NAME { get; set; }

        [Required]
        [StringLength(20)]
        public string LENDER_CERTIFICATE_ID { get; set; }

        public int? AGREEMENT_NUMBER { get; set; }

        public int? LOAN_CO_PLEDGER_KEY { get; set; }

        [Required]
        [StringLength(24)]
        public string AND_OR_FIRSTNAME { get; set; }

        [Required]
        [StringLength(10)]
        public string AND_OR_MIDNAME { get; set; }

        [Required]
        [StringLength(25)]
        public string AND_OR_LASTNAME { get; set; }

        [Required]
        [StringLength(20)]
        public string REPO_CASE_NUM { get; set; }

        [Required]
        [StringLength(3)]
        public string REPO_AGENT_TELLER { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? REPO_DATE_ENTERED { get; set; }

        public bool TITLE_RELEASED { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal TRANS_FEE_INCL_DOC_PREP_FEE_AMT { get; set; }

        public virtual Company Company { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual LienHolder LienHolder { get; set; }

        public virtual LoanCoPledger LoanCoPledger { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RepoCaseHistory> RepoCaseHistories { get; set; }

        public virtual Vehicle Vehicle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TitleLoanApproval> TitleLoanApprovals { get; set; }
    }
}
