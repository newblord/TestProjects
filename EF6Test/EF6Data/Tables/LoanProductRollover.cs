namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoanProductRollover")]
    public partial class LoanProductRollover
    {
        [Key]
        public int LOAN_PRODUCT_ROLLOVER_KEY { get; set; }

        public int LOAN_PRODUCT_KEY_PAID_LOAN { get; set; }

        public int LOAN_PRODUCT_KEY_NEW_LOAN { get; set; }

        public short LOCATION { get; set; }

        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        public DateTime? DATE_UPDATED { get; set; }

        [StringLength(3)]
        public string UPDATED_BY { get; set; }

        public virtual Company Company { get; set; }

        public virtual LoanProduct LoanProduct { get; set; }

        public virtual LoanProductConfig LoanProductConfig { get; set; }
    }
}
