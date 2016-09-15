namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EarnedCreditTran
    {
        [Key]
        public int EARNED_CREDIT_TRANS_KEY { get; set; }

        public int CUSTOMER_EARNED_CREDIT_KEY { get; set; }

        public int TRANS_DETAIL_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal EARNED_AMT { get; set; }

        public bool REVERSED { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? REVERSED_DATE { get; set; }

        public virtual CustomerEarnedCredit CustomerEarnedCredit { get; set; }

        public virtual TransDetail TransDetail { get; set; }
    }
}
