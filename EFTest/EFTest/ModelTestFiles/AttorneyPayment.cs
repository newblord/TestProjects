namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AttorneyPayment")]
    public partial class AttorneyPayment
    {
        [Key]
        public int ATTORNEY_PAYMENT_KEY { get; set; }

        public int ATTORNEY_LOAN_KEY { get; set; }

        public int? CASHED_CHECK_PAYMENT_KEY { get; set; }

        public int? LOAN_PAYMENT_KEY { get; set; }

        public short ATTORNEY_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? SENT_TO_ATTORNEY { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal AMT_DUE_ATTORNEY { get; set; }

        public bool REVERSED { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? REVERSED_DATE { get; set; }

        public virtual Attorney Attorney { get; set; }

        public virtual AttorneyLoan AttorneyLoan { get; set; }

        public virtual CashedCheckPayment CashedCheckPayment { get; set; }

        public virtual LoanPayment LoanPayment { get; set; }
    }
}
