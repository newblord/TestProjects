namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RbcEFundSecurity")]
    public partial class RbcEFundSecurity
    {
        [Key]
        public int RBC_EFUND_SECURITY_KEY { get; set; }

        public int LOAN_KEY { get; set; }

        public int SECURITY_CODE { get; set; }

        public virtual Loan Loan { get; set; }
    }
}
