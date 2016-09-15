namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DepositChkDetail")]
    public partial class DepositChkDetail
    {
        [Key]
        public int DEPOSIT_CHK_DETAIL_KEY { get; set; }

        public int DEPOSIT_CHK_KEY { get; set; }

        public int CUSTOMER_KEY { get; set; }

        public int TRANS_DETAIL_KEY { get; set; }

        public int? LOAN_KEY { get; set; }

        public int? CASHED_CHECK_KEY { get; set; }

        public virtual CashedCheck CashedCheck { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual DepositChk DepositChk { get; set; }

        public virtual Loan Loan { get; set; }
    }
}
