namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoanProduct")]
    public partial class LoanProduct
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoanProduct()
        {
            DiscountMasterLoanProducts = new HashSet<DiscountMasterLoanProduct>();
            FurtherFinanceExecutionLogDetails = new HashSet<FurtherFinanceExecutionLogDetail>();
            FurtherFinanceResultDetails = new HashSet<FurtherFinanceResultDetail>();
            LoanApplicationProducts = new HashSet<LoanApplicationProduct>();
            LoanDocUseds = new HashSet<LoanDocUsed>();
            LoanProductConfigs = new HashSet<LoanProductConfig>();
            LoanProductConfigOpenEnds = new HashSet<LoanProductConfigOpenEnd>();
            LoanProductConfigTitles = new HashSet<LoanProductConfigTitle>();
            LoanProductFeatures = new HashSet<LoanProductFeature>();
            LoanProductRollovers = new HashSet<LoanProductRollover>();
            ProductOpenLoanMatrices = new HashSet<ProductOpenLoanMatrix>();
            ProductOpenLoanMatrices1 = new HashSet<ProductOpenLoanMatrix>();
            SpecialMessageLoanProducts = new HashSet<SpecialMessageLoanProduct>();
            TempLoanProductSplits = new HashSet<TempLoanProductSplit>();
            TempLoanProductSplits1 = new HashSet<TempLoanProductSplit>();
            WebCallLoanProductConfigs = new HashSet<WebCallLoanProductConfig>();
        }

        [Key]
        public int LOAN_PRODUCT_KEY { get; set; }

        [Required]
        [StringLength(75)]
        public string PRODUCT_NAME { get; set; }

        [Required]
        [StringLength(1)]
        public string PRODUCT_TYPE { get; set; }

        [Required]
        [StringLength(1)]
        public string LOAN_TYPE { get; set; }

        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        public bool IS_EXPRESS { get; set; }

        public bool IS_BUSINESS { get; set; }

        public bool IS_EASYPAY { get; set; }

        [Required]
        [StringLength(2)]
        public string BUSINESS_STATE { get; set; }

        [Required]
        [StringLength(2000)]
        public string NOTE { get; set; }

        public DateTime? DATE_UPDATED { get; set; }

        [StringLength(3)]
        public string UPDATED_BY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiscountMasterLoanProduct> DiscountMasterLoanProducts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FurtherFinanceExecutionLogDetail> FurtherFinanceExecutionLogDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FurtherFinanceResultDetail> FurtherFinanceResultDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanApplicationProduct> LoanApplicationProducts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanDocUsed> LoanDocUseds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanProductConfig> LoanProductConfigs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanProductConfigOpenEnd> LoanProductConfigOpenEnds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanProductConfigTitle> LoanProductConfigTitles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanProductFeature> LoanProductFeatures { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanProductRollover> LoanProductRollovers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductOpenLoanMatrix> ProductOpenLoanMatrices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductOpenLoanMatrix> ProductOpenLoanMatrices1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SpecialMessageLoanProduct> SpecialMessageLoanProducts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TempLoanProductSplit> TempLoanProductSplits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TempLoanProductSplit> TempLoanProductSplits1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebCallLoanProductConfig> WebCallLoanProductConfigs { get; set; }
    }
}
