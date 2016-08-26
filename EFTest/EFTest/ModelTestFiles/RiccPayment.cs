namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RiccPayment
    {
        public int ID { get; set; }

        public int LOAN_KEY { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal AMOUNT { get; set; }

        [Key]
        public int RICC_PAYMENTS_KEY { get; set; }

        public int? OPTPLUS_CARD_DETAIL_KEY { get; set; }
    }
}
