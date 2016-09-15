namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Certificate")]
    public partial class Certificate
    {
        [Key]
        public int CERTIFICATE_KEY { get; set; }

        [Required]
        [StringLength(20)]
        public string NAME { get; set; }

        public byte[] DATA { get; set; }

        [StringLength(100)]
        public string PASSWORD { get; set; }

        public DateTimeOffset DATE_ENTERED_UTC { get; set; }

        public DateTimeOffset DATE_EXPIRES_UTC { get; set; }
    }
}
