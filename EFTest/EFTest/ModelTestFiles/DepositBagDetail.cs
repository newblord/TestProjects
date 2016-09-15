namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DepositBagDetail")]
    public partial class DepositBagDetail
    {
        [Key]
        public int DEPOSIT_BAG_DETAIL_KEY { get; set; }

        public int DEPOSIT_BAG_KEY { get; set; }

        public int CUSTOMER_KEY { get; set; }

        public int TRANS_DETAIL_KEY { get; set; }

        public int? LOAN_KEY { get; set; }

        public int? CASHED_CHECK_KEY { get; set; }

        public bool? REVERSED_DELETE { get; set; }

        [StringLength(3)]
        public string REVERSED_BY_DELETE { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? REVERSED_DATE_DELETE { get; set; }

        public int? DRAWER_KEY { get; set; }

        public int? LOAN_CHECK_KEY { get; set; }

        public virtual CashedCheck CashedCheck { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual DepositBag DepositBag { get; set; }

        public virtual Loan Loan { get; set; }
    }
}
