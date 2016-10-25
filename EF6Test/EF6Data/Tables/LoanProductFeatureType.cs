namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoanProductFeatureType")]
    public partial class LoanProductFeatureType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoanProductFeatureType()
        {
            LoanProductFeatures = new HashSet<LoanProductFeature>();
        }

        [Key]
        public int LOAN_PRODUCT_FEATURE_TYPE_KEY { get; set; }

        [Required]
        [StringLength(300)]
        public string DESCRIPTION { get; set; }

        public bool IS_ACTIVE { get; set; }

        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        public DateTime LAST_UPDATE_DATE { get; set; }

        [Required]
        [StringLength(3)]
        public string LAST_UPDATED_BY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanProductFeature> LoanProductFeatures { get; set; }
    }
}
