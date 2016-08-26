namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CourtesyPayout")]
    public partial class CourtesyPayout
    {
        [Key]
        public int COURTESY_PAYOUT_KEY { get; set; }

        public int TRANS_DETAIL_KEY { get; set; }

        public int? LOAN_KEY { get; set; }

        public int CUSTOMER_KEY { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal COURTESY_PAYOUT_AMT { get; set; }

        [Required]
        [StringLength(1)]
        public string COURTESY_PAYOUT_TYPE { get; set; }

        public int? SERVICE_TRANS_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string ENTERED_BY { get; set; }

        public short LOCATION { get; set; }

        [Required]
        [StringLength(2000)]
        public string NOTE { get; set; }

        [Required]
        public string RTF_NOTE { get; set; }

        public int? CASHED_CHECK_KEY { get; set; }

        public virtual CashedCheck CashedCheck { get; set; }

        public virtual Loan Loan { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual ServiceTran ServiceTran { get; set; }

        public virtual TransDetail TransDetail { get; set; }
    }
}
