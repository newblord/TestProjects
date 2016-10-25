namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebCallRecordingArchive")]
    public partial class WebCallRecordingArchive
    {
        [Key]
        public int WEB_CALL_RECORDING_ARCHIVE_KEY { get; set; }

        public int WEB_ARCHIVE_KEY { get; set; }

        [Required]
        [StringLength(100)]
        public string SESSION_ID { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        public DateTime CALL_DATE { get; set; }

        public DateTime DATE_ENTERED { get; set; }

        public virtual WebArchive WebArchive { get; set; }
    }
}
