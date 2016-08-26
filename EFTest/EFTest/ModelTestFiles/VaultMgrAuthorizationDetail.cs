namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VaultMgrAuthorizationDetail")]
    public partial class VaultMgrAuthorizationDetail
    {
        [Key]
        public int VM_AUTH_DETAIL_KEY { get; set; }

        public int VM_AUTH_KEY { get; set; }

        public DateTime APPROVAL_TIME { get; set; }

        public int? MESSAGE_ID { get; set; }

        public int? CUSTOMER_KEY { get; set; }

        public int? LOAN_KEY { get; set; }

        public int? TRANS_POS_KEY { get; set; }

        public decimal? ORIG_VALUE { get; set; }

        public decimal? AUTH_VALUE { get; set; }

        public bool IS_CURRENCY { get; set; }

        public bool IS_PERCENT { get; set; }

        public string MESSAGE_DATA { get; set; }

        public bool? IS_VM_AUTH { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Loan Loan { get; set; }

        public virtual TransPOS TransPOS { get; set; }

        public virtual VaultMgrAuthorization VaultMgrAuthorization { get; set; }
    }
}
