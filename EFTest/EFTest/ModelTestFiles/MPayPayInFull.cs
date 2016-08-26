namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MPayPayInFull")]
    public partial class MPayPayInFull
    {
        [Key]
        public int MPAY_PAY_IN_FULL_KEY { get; set; }

        public int LOAN_KEY { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        public int PAYMENT_NUM { get; set; }

        [Required]
        [StringLength(1)]
        public string PIF_STATUS { get; set; }

        public int? TRANS_DETAIL_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DISABLED_DATE { get; set; }

        [StringLength(3)]
        public string DISABLED_BY { get; set; }
    }
}
