namespace EF6Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DocImage")]
    public partial class DocImage
    {
        [Key]
        public int DOCIMAGE_KEY { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string DOC_DATA { get; set; }

        [Required]
        [StringLength(255)]
        public string IMAGE_NAME { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        [Required]
        [StringLength(3)]
        public string IMAGE_TYPE { get; set; }

        [Required]
        [StringLength(8)]
        public string IMAGE_FORMAT { get; set; }
    }
}
