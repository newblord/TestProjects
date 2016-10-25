namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PaymentPlan")]
    public partial class PaymentPlan
    {
        [Key]
        public int PAYMENT_PLAN_KEY { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PP_PRINCIPAL { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal PP_COMMISSION { get; set; }
    }
}
