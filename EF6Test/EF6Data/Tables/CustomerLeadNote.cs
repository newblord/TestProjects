namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerLeadNote")]
    public partial class CustomerLeadNote
    {
        [Key]
        public int CUSTOMER_LEAD_NOTE_KEY { get; set; }

        public int CUSTOMER_LEAD_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Required]
        public string NOTE { get; set; }

        public virtual CustomerLead CustomerLead { get; set; }
    }
}
