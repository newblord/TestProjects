namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoanDueDateChange")]
    public partial class LoanDueDateChange
    {
        [Key]
        public int DUEDATE_CHANGE_KEY { get; set; }

        public int LOAN_KEY { get; set; }

        public int CUSTOMER_KEY { get; set; }

        public short LOCATION { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        public DateTime DATE_ENTERED { get; set; }

        [Column(TypeName = "date")]
        public DateTime ADJUSTED_DUE_DATE { get; set; }

        public int? TRANS_DETAIL_KEY { get; set; }

        public bool IS_DUEDATE_CHANGED { get; set; }

        public int? LOAN_CHECK_KEY { get; set; }

        [StringLength(50)]
        public string CHANGE_NOTE { get; set; }

        public int? OPEN_END_LOAN_STMT_KEY { get; set; }

        public virtual Company Company { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual OpenEndLoanStatement OpenEndLoanStatement { get; set; }
    }
}
