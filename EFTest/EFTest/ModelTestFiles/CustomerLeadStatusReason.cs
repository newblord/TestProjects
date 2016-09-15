namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerLeadStatusReason")]
    public partial class CustomerLeadStatusReason
    {
        [Key]
        public int CUSTOMER_LEAD_STATUS_REASON_KEY { get; set; }

        public int CUSTOMER_LEAD_STATUS_KEY { get; set; }

        public int CUSTOMER_LEAD_REASON_KEY { get; set; }

        public virtual CustomerLeadReason CustomerLeadReason { get; set; }

        public virtual CustomerLeadStatu CustomerLeadStatu { get; set; }
    }
}
