namespace EFTest.ModelTestFiles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CpiuExceptionReport")]
    public partial class CpiuExceptionReport
    {
        [Key]
        public int CPIU_EXCEPTION_REPORT_KEY { get; set; }

        public int CPIU_DETAIL_KEY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DATETIME_ENTERED { get; set; }

        [Required]
        [StringLength(500)]
        public string MESSAGE { get; set; }

        public short EXCEPTION_TYPE { get; set; }

        public virtual CpiuDetail CpiuDetail { get; set; }
    }
}
