namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DocumentPrinting")]
    public partial class DocumentPrinting
    {
        [Key]
        public int DOCUMENT_PRINTING_KEY { get; set; }

        public short LOCATION { get; set; }

        [Required]
        [StringLength(3)]
        public string TELLER { get; set; }

        [Required]
        [StringLength(100)]
        public string COMPUTER_NAME { get; set; }

        [Required]
        [StringLength(500)]
        public string PRINTER_NAME { get; set; }

        public DateTime DATE_ENTERED { get; set; }
    }
}
