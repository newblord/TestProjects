namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoanProductFeature")]
    public partial class LoanProductFeature
    {
        [Key]
        public int LOAN_PRODUCT_FEATURE_KEY { get; set; }

        public int LOAN_PRODUCT_KEY { get; set; }

        public int LOAN_PRODUCT_FEATURE_TYPE_KEY { get; set; }

        [Required]
        [StringLength(300)]
        public string DESCRIPTION { get; set; }

        public int? DISPLAY_COLOR { get; set; }

        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        public DateTime LAST_UPDATE_DATE { get; set; }

        [Required]
        [StringLength(3)]
        public string LAST_UPDATED_BY { get; set; }

        public virtual LoanProduct LoanProduct { get; set; }

        public virtual LoanProductFeatureType LoanProductFeatureType { get; set; }
    }
}
