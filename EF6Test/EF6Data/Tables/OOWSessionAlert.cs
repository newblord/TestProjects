namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OOWSessionAlert")]
    public partial class OOWSessionAlert
    {
        [Key]
        public int OOW_SESSION_ALERT_KEY { get; set; }

        public int OOW_SESSION_KEY { get; set; }

        [Required]
        [StringLength(20)]
        public string ALERT_CODE { get; set; }

        [StringLength(500)]
        public string ALERT_TEXT { get; set; }

        public DateTime DATE_ENTERED { get; set; }

        public virtual OOWSession OOWSession { get; set; }
    }
}
