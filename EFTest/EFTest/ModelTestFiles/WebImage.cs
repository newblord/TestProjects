namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebImage")]
    public partial class WebImage
    {
        [Key]
        public int WEB_IMAGE_KEY { get; set; }

        public int LOAN_APPLICATION_KEY { get; set; }

        [Required]
        public byte[] DATA { get; set; }

        [Required]
        [StringLength(2085)]
        public string SOURCE_URL { get; set; }

        [Required]
        public string SOURCE_HTML { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATE_ENTERED { get; set; }

        public virtual LoanApplication LoanApplication { get; set; }
    }
}
