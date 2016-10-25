namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WebEmailNote
    {
        [Key]
        public int WEB_EMAIL_NOTES_KEY { get; set; }

        [Required]
        [StringLength(50)]
        public string WEB_EMAIL_UNIQUE_ID { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [StringLength(4000)]
        public string NOTES { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }
    }
}
