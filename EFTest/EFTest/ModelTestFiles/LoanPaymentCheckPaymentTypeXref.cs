namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoanPaymentCheckPaymentTypeXref")]
    public partial class LoanPaymentCheckPaymentTypeXref
    {
        [Key]
        public int LOAN_PAYMENT_CHECK_PAYMENT_TYPE_XREF_KEY { get; set; }

        public int LOAN_PAYMENT_KEY { get; set; }

        public int CHECK_PAYMENT_TYPE_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        public virtual CheckPaymentType CheckPaymentType { get; set; }
    }
}
