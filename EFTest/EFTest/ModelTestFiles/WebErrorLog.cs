namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebErrorLog")]
    public partial class WebErrorLog
    {
        [Key]
        public int WEB_ERROR_LOG_KEY { get; set; }

        public int? VISITOR_KEY { get; set; }

        public int? APPLICATION_KEY { get; set; }

        public int? CUSTOMER_KEY { get; set; }

        public int? LOAN_KEY { get; set; }

        [Required]
        [StringLength(500)]
        public string CURRENT_PAGE { get; set; }

        [Required]
        [StringLength(500)]
        public string EXCEPTION_TYPE { get; set; }

        public DateTime DATE_ENTERED { get; set; }

        public string ERROR_MSG { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Loan Loan { get; set; }

        public virtual LoanApplication LoanApplication { get; set; }

        public virtual Visitor Visitor { get; set; }
    }
}
