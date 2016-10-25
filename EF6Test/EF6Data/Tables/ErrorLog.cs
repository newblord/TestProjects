namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ErrorLog")]
    public partial class ErrorLog
    {
        [Key]
        public int ErrorLogKey { get; set; }

        [Required]
        [StringLength(250)]
        public string ErrorMessage { get; set; }

        [StringLength(1000)]
        public string SupportMessage { get; set; }

        public int? VISITOR_KEY { get; set; }

        public int? CUSTOMER_KEY { get; set; }

        public int? APPLICATION_KEY { get; set; }

        public int? LOAN_KEY { get; set; }

        public int? Severity { get; set; }

        [StringLength(30)]
        public string Client { get; set; }

        [StringLength(30)]
        public string Tier { get; set; }

        [StringLength(100)]
        public string CodeLocation { get; set; }

        [StringLength(8000)]
        public string ExceptionText { get; set; }

        public string StateDump { get; set; }

        public int? TransDetail { get; set; }

        [StringLength(30)]
        public string WebServer { get; set; }

        [StringLength(30)]
        public string AppServer { get; set; }

        [StringLength(500)]
        public string UserAgent { get; set; }

        [StringLength(50)]
        public string Browser { get; set; }

        public DateTime DateEntered { get; set; }

        [StringLength(200)]
        public string CurrentPage { get; set; }

        [StringLength(200)]
        public string ReferringPage { get; set; }

        public bool? SupportRedirect { get; set; }

        public DateTime? DateEnteredDay { get; set; }

        public DateTime? DateEnteredHour { get; set; }

        public DateTime? DateEnteredMinute { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Loan Loan { get; set; }

        public virtual LoanApplication LoanApplication { get; set; }
    }
}
