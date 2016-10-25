namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerLeadActivity")]
    public partial class CustomerLeadActivity
    {
        [Key]
        public int CUSTOMER_LEAD_ACTIVITY_KEY { get; set; }

        public int CUSTOMER_LEAD_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        public int CUSTOMER_LEAD_ACTION_KEY { get; set; }

        public int CUSTOMER_LEAD_STATUS_KEY { get; set; }

        public int? CUSTOMER_LEAD_REASON_KEY { get; set; }

        public virtual CustomerLead CustomerLead { get; set; }

        public virtual CustomerLeadAction CustomerLeadAction { get; set; }

        public virtual CustomerLeadStatu CustomerLeadStatu { get; set; }
    }
}
