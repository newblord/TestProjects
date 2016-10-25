namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoanDocPrinted")]
    public partial class LoanDocPrinted
    {
        [Key]
        public int LOAN_DOC_PRINTED_KEY { get; set; }

        public int? LOAN_KEY { get; set; }

        public int LOAN_DOC_KEY { get; set; }

        public int CUSTOMER_KEY { get; set; }

        public short LOCATION { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        public int TRANS_DETAIL_KEY { get; set; }

        public virtual Loan Loan { get; set; }

        public virtual LoanDoc LoanDoc { get; set; }
    }
}
