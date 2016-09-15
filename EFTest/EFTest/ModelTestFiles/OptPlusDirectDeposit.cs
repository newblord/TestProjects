namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OptPlusDirectDeposit")]
    public partial class OptPlusDirectDeposit
    {
        [Key]
        public int OPTPLUS_DIRECT_DEPOSIT_KEY { get; set; }

        public int CUSTOMER_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal DEPOSIT_AMT { get; set; }

        public bool IS_ELIGIBLE_DEPOSIT { get; set; }

        public int OPTPLUS_MERCHANT_KEY { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual OptPlusMerchant OptPlusMerchant { get; set; }
    }
}
