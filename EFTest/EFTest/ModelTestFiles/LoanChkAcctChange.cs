namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoanChkAcctChange")]
    public partial class LoanChkAcctChange
    {
        [Key]
        public int CHK_ACCT_CHANGE_KEY { get; set; }

        public int LOAN_KEY { get; set; }

        public int CUSTOMER_KEY { get; set; }

        public short LOCATION { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        public int ISSUER_KEY { get; set; }

        public bool DIRECT_DEPOSIT { get; set; }

        public int? PRV_CREDIT_CARD_KEY { get; set; }

        public int? NEW_CREDIT_CARD_KEY { get; set; }

        public bool? PRV_DECLINED_AUTO_PAY { get; set; }

        public bool? NEW_DECLINED_AUTO_PAY { get; set; }

        public int PRV_ISSUER_KEY { get; set; }

        public bool PRV_DIRECT_DEPOSIT { get; set; }

        [Required]
        [StringLength(1)]
        public string ISSUER_CHK_ACCT_CHANGE_REASON { get; set; }

        [Required]
        [StringLength(1)]
        public string CCARD_CHK_ACCT_CHANGE_REASON { get; set; }

        [Required]
        [StringLength(250)]
        public string NOTE { get; set; }
    }
}
