namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TempLoanProductSplit")]
    public partial class TempLoanProductSplit
    {
        [Key]
        public int TEMP_LOAN_PRODUCT_SPLIT_KEY { get; set; }

        public int ORIG_LOAN_PRODUCT_KEY { get; set; }

        [Required]
        [StringLength(100)]
        public string ORIG_LOAN_PRODUCT_NAME { get; set; }

        public int? NEW_LOAN_PRODUCT_KEY { get; set; }

        [Required]
        [StringLength(100)]
        public string NEW_LOAN_PRODUCT_NAME { get; set; }

        public int ORIG_LOAN_PRODUCT_CONFIG_KEY { get; set; }

        public int? NEW_LOAN_PRODUCT_CONFIG_KEY { get; set; }

        public short LOCATION { get; set; }

        [Required]
        [StringLength(1)]
        public string PRODUCT_TYPE { get; set; }

        [Required]
        [StringLength(1)]
        public string LOAN_TYPE { get; set; }

        public virtual LoanProduct LoanProduct { get; set; }

        public virtual LoanProduct LoanProduct1 { get; set; }

        public virtual LoanProductConfig LoanProductConfig { get; set; }

        public virtual LoanProductConfig LoanProductConfig1 { get; set; }
    }
}
