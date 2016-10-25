namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoanProductConfigRIRate")]
    public partial class LoanProductConfigRIRate
    {
        [Key]
        public int LOAN_PRODUCT_CONFIG_RI_RATE_KEY { get; set; }

        public int LOAN_PRODUCT_CONFIG_KEY { get; set; }

        public short FROM_NUM_DAYS { get; set; }

        public short TO_NUM_DAYS { get; set; }

        public decimal RI_RATE_VAL { get; set; }

        [Required]
        [StringLength(1)]
        public string RI_RATE_PCT_OR_AMT { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DATE_UPDATED { get; set; }

        [StringLength(3)]
        public string UPDATED_BY { get; set; }

        public virtual LoanProductConfig LoanProductConfig { get; set; }
    }
}
