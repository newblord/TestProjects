namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoanOverride")]
    public partial class LoanOverride
    {
        [Key]
        public int LOAN_OVERRIDE_KEY { get; set; }

        public int LOAN_NOTE_KEY { get; set; }

        public int LOAN_KEY { get; set; }

        [Required]
        [StringLength(1)]
        public string LOAN_OVERRIDE_TYPE { get; set; }

        public byte LOAN_OVERRIDE_REASON { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ORIG_VALUE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal OVERRIDE_VALUE { get; set; }

        public virtual Loan Loan { get; set; }

        public virtual LoanNote LoanNote { get; set; }
    }
}
