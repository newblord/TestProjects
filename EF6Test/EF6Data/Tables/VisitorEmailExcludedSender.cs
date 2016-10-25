namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VisitorEmailExcludedSender
    {
        [Key]
        public int VISITOR_EMAIL_EXCLUDED_SENDERS_KEY { get; set; }

        [StringLength(50)]
        public string EMAIL_USER { get; set; }

        [StringLength(50)]
        public string EMAIL_DOMAIN { get; set; }

        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }
    }
}
