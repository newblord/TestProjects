namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LoanProductConfigLoanStat
    {
        [Key]
        public int LOAN_PRODUCT_CONFIG_LOAN_STATS_KEY { get; set; }

        public int LOAN_PRODUCT_CONFIG_KEY { get; set; }

        public short LOCATION { get; set; }

        public int LOANS_COUNT { get; set; }

        public int OPEN_LOANS_COUNT { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        public virtual Company Company { get; set; }

        public virtual LoanProductConfig LoanProductConfig { get; set; }
    }
}
