namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OpenEndInterestRate")]
    public partial class OpenEndInterestRate
    {
        [Key]
        public int OPEN_END_INTEREST_RATE_KEY { get; set; }

        public int LOAN_KEY { get; set; }

        [Column(TypeName = "date")]
        public DateTime INTEREST_START_DATE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ANNUAL_RATE_PCT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal MONTHLY_RATE_PCT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal DAILY_RATE_PCT { get; set; }

        public virtual Loan Loan { get; set; }
    }
}
