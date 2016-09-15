namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DiscountMaster")]
    public partial class DiscountMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DiscountMaster()
        {
            DiscountLocations = new HashSet<DiscountLocation>();
            DiscountMasterLoanProducts = new HashSet<DiscountMasterLoanProduct>();
            DiscountSecurities = new HashSet<DiscountSecurity>();
            DiscountUseds = new HashSet<DiscountUsed>();
            LoanApplicationDiscounts = new HashSet<LoanApplicationDiscount>();
        }

        [Key]
        public int DISCOUNT_MASTER_KEY { get; set; }

        public int? DISCOUNT_TYPE_KEY { get; set; }

        [Required]
        [StringLength(4)]
        public string DISCOUNT_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string DISCOUNT_NAME { get; set; }

        [Required]
        [StringLength(300)]
        public string DESCRIPTION { get; set; }

        public int? GL_ACCT { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? START_DATE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? END_DATE { get; set; }

        public byte AMOUNT_TYPE { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal DEFAULT_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal MAX_AMT { get; set; }

        public bool APPLY_TO_CHECKS { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        public bool IS_ACTIVE { get; set; }

        public bool ROUTE_REQUIRED { get; set; }

        public byte CUSTOMER_LEVEL { get; set; }

        public int? EARNED_CREDIT_TYPE_KEY { get; set; }

        [Required]
        [StringLength(1)]
        public string APPLY_DISCOUNT_TO { get; set; }

        public bool IS_AUTO_APPLIED { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiscountLocation> DiscountLocations { get; set; }

        public virtual DiscountType DiscountType { get; set; }

        public virtual EarnedCreditType EarnedCreditType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiscountMasterLoanProduct> DiscountMasterLoanProducts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiscountSecurity> DiscountSecurities { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiscountUsed> DiscountUseds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanApplicationDiscount> LoanApplicationDiscounts { get; set; }
    }
}
