namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RiccAutoRoll")]
    public partial class RiccAutoRoll
    {
        [Key]
        public int RICC_AUTO_ROLL_KEY { get; set; }

        public int? RISREPT_KEY { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATE_ENTERED { get; set; }

        public int ZERO_LOAN_KEY { get; set; }

        public int ORIG_LOAN_KEY { get; set; }

        public int NEW_LOAN_KEY { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal FEE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal SURCHARGE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal COLLECTED_AMT { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EMAIL_SENT { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LETTER_SENT { get; set; }

        public virtual Loan Loan { get; set; }

        public virtual Loan Loan1 { get; set; }

        public virtual RISREPT RISREPT { get; set; }
    }
}
