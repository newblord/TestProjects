namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebCallQueueAudit")]
    public partial class WebCallQueueAudit
    {
        [Key]
        public int WEB_CALL_QUEUE_AUDIT_KEY { get; set; }

        public DateTime AUDIT_DATE { get; set; }

        [Required]
        [StringLength(3)]
        public string USER { get; set; }

        public int WEB_CALL_QUEUE_KEY { get; set; }

        [Required]
        [StringLength(50)]
        public string FIELD_NAME { get; set; }

        [StringLength(2000)]
        public string OLD_VALUE { get; set; }

        [StringLength(2000)]
        public string NEW_VALUE { get; set; }
    }
}
