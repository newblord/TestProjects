namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GoodCustomerStudy")]
    public partial class GoodCustomerStudy
    {
        [Key]
        public int GOOD_CUSTOMER_STUDY_KEY { get; set; }

        public int CUSTOMER_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal INITIAL_APPROVED_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal INCREASE_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal STATE_MAX_AMT { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal LOAN_TAKEN_AMT { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
