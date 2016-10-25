namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoanFundingMethodHistory")]
    public partial class LoanFundingMethodHistory
    {
        [Key]
        public int LOAN_FUNDING_METHOD_HISTORY_KEY { get; set; }

        public int LOAN_KEY { get; set; }

        public byte FUNDING_METHOD { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        public virtual Loan Loan { get; set; }
    }
}
