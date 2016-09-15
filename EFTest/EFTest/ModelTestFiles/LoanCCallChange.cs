namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoanCCallChange")]
    public partial class LoanCCallChange
    {
        [Key]
        public int LOAN_CCALL_CHANGE_KEY { get; set; }

        public int LOAN_KEY { get; set; }

        public short LOCATION { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        public bool? COURTESY_CALL { get; set; }

        public bool? EMAIL_STATEMENTS { get; set; }

        public virtual Loan Loan { get; set; }
    }
}
