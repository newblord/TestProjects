namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoanProductConfigEdit")]
    public partial class LoanProductConfigEdit
    {
        [Key]
        public int LOAN_PRODUCT_CONFIG_EDIT_KEY { get; set; }

        public int LOAN_PRODUCT_CONFIG_KEY { get; set; }

        [Required]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(100)]
        public string TABLE_NAME { get; set; }

        [Required]
        [StringLength(100)]
        public string FIELD_NAME { get; set; }

        [StringLength(200)]
        public string OLD_VALUE { get; set; }

        [StringLength(200)]
        public string NEW_VALUE { get; set; }

        public virtual LoanProductConfig LoanProductConfig { get; set; }
    }
}
