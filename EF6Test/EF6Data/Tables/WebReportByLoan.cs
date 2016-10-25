namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebReportByLoan")]
    public partial class WebReportByLoan
    {
        [Key]
        public int web_report_by_loan_key { get; set; }

        public int loan_key { get; set; }

        public int? customer_key { get; set; }

        public DateTime date_entered { get; set; }

        public DateTime? adjusted_due_date { get; set; }

        public bool? is_customer_new { get; set; }

        public bool? is_loan_rollover { get; set; }

        public bool? is_loan_open { get; set; }

        public bool? is_loan_defaulted { get; set; }

        public bool? is_paid_in_full { get; set; }

        [StringLength(4)]
        public string msa { get; set; }

        public int? location { get; set; }

        [StringLength(2)]
        public string def_state { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? princ_amt { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? fee_amt { get; set; }

        public bool? is_first_internet_loan { get; set; }

        [StringLength(500)]
        public string source { get; set; }

        public bool? is_approved_by_scoring { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? cash_amt { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? net_income { get; set; }

        [StringLength(1)]
        public string gender { get; set; }

        public DateTime? dob { get; set; }
    }
}
